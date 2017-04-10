using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
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
            DependencyProperty.Register("CropArea", typeof(Rect), typeof(CropRotateControl), new PropertyMetadata(new Rect()));


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

        private void RootGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (!_imageOpened)
            {
                return;
            }

            var nettoWidth = e.NewSize.Width - SelectionAreaMargin.Left - SelectionAreaMargin.Right;
            var nettoHeight = e.NewSize.Height - SelectionAreaMargin.Top - SelectionAreaMargin.Bottom;

            var image = this.ImageControl;

            if (image.ActualWidth != nettoWidth)
            {
                image.Width = nettoWidth;
            }
            else
            {
                image.Height = nettoHeight;
            }

            //this.SelectionArea.MaxWidth = e.NewSize.Width - 2 * SelectionAreaMargin;
            //this.SelectionArea.MaxHeight = e.NewSize.Height - 2 * SelectionAreaMargin;
        }

        private bool _imageOpened;

        private void ImageControl_ImageOpened(object sender, RoutedEventArgs e)
        {
            //this.SelectionArea.VisualWidth = this.ImageControl.ActualWidth;
            //this.SelectionArea.VisualHeight = this.ImageControl.ActualHeight;

            _imageOpened = true;
        }
    }
}
