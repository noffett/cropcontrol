using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;


namespace CropRotate
{
    public sealed partial class CropRotateControl : UserControl
    {
        public ImageSource ImageSource
        {
            get { return (ImageSource)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(ImageSource), typeof(CropRotateControl), new PropertyMetadata(null));


        public Rect CropArea
        {
            get { return (Rect)GetValue(CropAreaProperty); }
            set { SetValue(CropAreaProperty, value); }
        }

        public static readonly DependencyProperty CropAreaProperty =
            DependencyProperty.Register("CropArea", typeof(Rect), typeof(CropRotateControl), new PropertyMetadata(new Rect(), new PropertyChangedCallback(OnCropAreaPropertyChanged)));

        private static void OnCropAreaPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var that = d as CropRotateControl;
            var rect = (Rect)e.NewValue;

            that.SelectionArea.SelectionWidth = rect.Width;
            that.SelectionArea.SelectionHeight = rect.Height;
        }

        public double RotationAngle
        {
            get { return (double)GetValue(RotationAngleProperty); }
            set { SetValue(RotationAngleProperty, value); }
        }

        public static readonly DependencyProperty RotationAngleProperty =
            DependencyProperty.Register("RotationAngle", typeof(double), typeof(CropRotateControl), new PropertyMetadata(0.0, new PropertyChangedCallback(OnRotationAnglePropertyChanged)));

        private static void OnRotationAnglePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var that = d as CropRotateControl;
            that.RotateTransfom.Angle = (double)e.NewValue * -1;
        }

        public Point RotationOrigin
        {
            get { return (Point)GetValue(RotationOriginProperty); }
            set { SetValue(RotationOriginProperty, value); }
        }

        public static readonly DependencyProperty RotationOriginProperty =
            DependencyProperty.Register("RotationOrigin", typeof(Point), typeof(CropRotateControl), new PropertyMetadata(new Point()));


        public bool Flipped
        {
            get { return (bool)GetValue(FlippedProperty); }
            set { SetValue(FlippedProperty, value); }
        }

        public static readonly DependencyProperty FlippedProperty =
            DependencyProperty.Register("Flipped", typeof(bool), typeof(CropRotateControl), new PropertyMetadata(false));

        public Thickness SelectionAreaMargin
        {
            get { return (Thickness)GetValue(SelectionAreaMarginProperty); }
            set { SetValue(SelectionAreaMarginProperty, value); }
        }

        public static readonly DependencyProperty SelectionAreaMarginProperty =
            DependencyProperty.Register("SelectionAreaMargin", typeof(Thickness), typeof(CropRotateControl), new PropertyMetadata(new Thickness(75.0, 75.0, 75.0, 75.0)));



        public CropRotateControl()
        {
            this.InitializeComponent();
        }



        public double ImageWidth
        {
            get { return (double)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }

        public static readonly DependencyProperty ImageWidthProperty =
            DependencyProperty.Register("ImageWidth", typeof(double), typeof(CropRotateControl), new PropertyMetadata(0.0));


        public double ImageHeight
        {
            get { return (double)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }

        public static readonly DependencyProperty ImageHeightProperty =
            DependencyProperty.Register("ImageHeight", typeof(double), typeof(CropRotateControl), new PropertyMetadata(0.0));





        private bool _imageOpened;
        private Size _imageActualSize;

        private void ImageControl_ImageOpened(object sender, RoutedEventArgs e)
        {
            var image = sender as Image;
            _imageActualSize = new Size(image.ActualWidth, image.ActualHeight);

            _imageOpened = true;
        }



        public double Scale
        {
            get { return (double)GetValue(ScaleProperty); }
            set { SetValue(ScaleProperty, value); }
        }

        public static readonly DependencyProperty ScaleProperty =
            DependencyProperty.Register("Scale", typeof(double), typeof(CropRotateControl), new PropertyMetadata(1.0));

        public double HorizontalOffset
        {
            get { return (double)GetValue(HorizontalOffsetProperty); }
            set { SetValue(HorizontalOffsetProperty, value); }
        }

        public static readonly DependencyProperty HorizontalOffsetProperty =
            DependencyProperty.Register("HorizontalOffset", typeof(double), typeof(CropRotateControl), new PropertyMetadata(0.0, new PropertyChangedCallback(OnHorizontalOffsetPropertyChanged)));

        private static void OnHorizontalOffsetPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var delta = (double)e.NewValue - (double)e.OldValue;
            ((CropRotateControl)d).ImageHorizontalOffset += delta;
        }

        public double VerticalOffset
        {
            get { return (double)GetValue(VerticalOffsetProperty); }
            set { SetValue(VerticalOffsetProperty, value); }
        }

        public static readonly DependencyProperty VerticalOffsetProperty =
            DependencyProperty.Register("VerticalOffset", typeof(double), typeof(CropRotateControl), new PropertyMetadata(0.0, new PropertyChangedCallback(OnVerticalOffsetPropertyChanged)));

        private static void OnVerticalOffsetPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var delta = (double)e.NewValue - (double)e.OldValue;
            ((CropRotateControl)d).ImageVerticalOffset += delta;
        }


        public double ImageHorizontalOffset
        {
            get { return (double)GetValue(ImageHorizontalOffsetProperty); }
            set { SetValue(ImageHorizontalOffsetProperty, value); }
        }

        public static readonly DependencyProperty ImageHorizontalOffsetProperty =
            DependencyProperty.Register("ImageHorizontalOffset", typeof(double), typeof(CropRotateControl), new PropertyMetadata(0.0));


        public double ImageVerticalOffset
        {
            get { return (double)GetValue(ImageVerticalOffsetProperty); }
            set { SetValue(ImageVerticalOffsetProperty, value); }
        }

        public static readonly DependencyProperty ImageVerticalOffsetProperty =
            DependencyProperty.Register("ImageVerticalOffset", typeof(double), typeof(CropRotateControl), new PropertyMetadata(0.0));



        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (!_imageOpened)
            {
                return;
            }

            var nettoWidth = e.NewSize.Width - SelectionAreaMargin.Left - SelectionAreaMargin.Right;
            var nettoHeight = e.NewSize.Height - SelectionAreaMargin.Top - SelectionAreaMargin.Bottom;

            var xScale = nettoWidth / _imageActualSize.Width;
            var yScale = nettoHeight / _imageActualSize.Height;

            Scale = xScale < yScale ? xScale : yScale;

            ImageWidth = Scale * _imageActualSize.Width;
            ImageHeight = Scale * _imageActualSize.Height;

            HorizontalOffset = (e.NewSize.Width / 2.0) - (ImageWidth / 2.0);
            VerticalOffset = (e.NewSize.Height / 2.0) - (ImageHeight / 2.0);

            var delta = (double)e.NewValue - (double)e.OldValue;
            ImageHorizontalOffset += delta;
        }

        private void SelectionArea_TopLeftResizeDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            HorizontalOffset += e.Delta.Translation.X;
            VerticalOffset += e.Delta.Translation.Y;

            var width = CropArea.Width - e.Delta.Translation.X;
            var height = CropArea.Height - e.Delta.Translation.Y;

            CropArea = new Rect() { X = CropArea.X, Y = CropArea.Y, Width = width, Height = height };
        }

        private void SelectionArea_BottomRightResizeDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            var width = CropArea.Width + e.Delta.Translation.X;
            var height = CropArea.Height + e.Delta.Translation.Y;

            CropArea = new Rect() { X = CropArea.X, Y = CropArea.Y, Width = width, Height = height };
        }

        private void SelectionArea_PanDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            var x = CropArea.X - e.Delta.Translation.X;
            var y = CropArea.Y - e.Delta.Translation.Y;

            CropArea = new Rect() { X = x, Y = y, Width = CropArea.Width, Height = CropArea.Height };

            ImageHorizontalOffset += e.Delta.Translation.X;
            ImageVerticalOffset += e.Delta.Translation.Y;

            SetInfoText();
        }

        private void SetInfoText()
        {
            InfoText.Text = $"X: {Math.Round(CropArea.X, 0)}\nY: {Math.Round(CropArea.Y, 0)}";
        }
    }
}
