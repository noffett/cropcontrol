﻿using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;


namespace CropRotate
{
    public sealed partial class CropRotateControl : UserControl
    {
        private bool _imageOpened;
        private Size _imageActualSize;

        #region public dependency properties

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
            DependencyProperty.Register("CropArea", typeof(Rect), typeof(CropRotateControl), new PropertyMetadata(new Rect(0.0, 0.0, 1.0, 1.0)));


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

        #endregion public dependency properties


        #region private properties not for outside manipulation

        public double SelectionWidth
        {
            get { return (double)GetValue(SelectionWidthProperty); }
            set { SetValue(SelectionWidthProperty, value); }
        }

        public static readonly DependencyProperty SelectionWidthProperty =
            DependencyProperty.Register("SelectionWidth", typeof(double), typeof(CropRotateControl), new PropertyMetadata(0.0));

        public double SelectionHeight
        {
            get { return (double)GetValue(SelectionHeightProperty); }
            set { SetValue(SelectionHeightProperty, value); }
        }

        public static readonly DependencyProperty SelectionHeightProperty =
            DependencyProperty.Register("SelectionHeight", typeof(double), typeof(CropRotateControl), new PropertyMetadata(0.0));


        public double ImageScale
        {
            get { return (double)GetValue(ImageScaleProperty); }
            set { SetValue(ImageScaleProperty, value); }
        }

        public static readonly DependencyProperty ImageScaleProperty =
            DependencyProperty.Register("ImageScale", typeof(double), typeof(CropRotateControl), new PropertyMetadata(1.0));

        /// <summary>
        /// Offset of the SelectionAreaControl relative to the left side of the control
        /// </summary>
        public double SelectionHorizontalOffset
        {
            get { return (double)GetValue(SelectionHorizontalOffsetProperty); }
            set { SetValue(SelectionHorizontalOffsetProperty, value); }
        }

        public static readonly DependencyProperty SelectionHorizontalOffsetProperty =
            DependencyProperty.Register("SelectionHorizontalOffset", typeof(double), typeof(CropRotateControl), new PropertyMetadata(0.0));

        /// <summary>
        /// Offset of the SelectionAreaControl relative to the top side of the control
        /// </summary>
        public double SelectionVerticalOffset
        {
            get { return (double)GetValue(SelectionVerticalOffsetProperty); }
            set { SetValue(SelectionVerticalOffsetProperty, value); }
        }

        public static readonly DependencyProperty SelectionVerticalOffsetProperty =
            DependencyProperty.Register("SelectionVerticalOffset", typeof(double), typeof(CropRotateControl), new PropertyMetadata(0.0));

        /// <summary>
        /// Offset of the image relative to the left side of the control
        /// The sum of SelectionHorizontalOffset and the inverted value of CropArea.X
        /// </summary>
        public double ImageHorizontalOffset
        {
            get { return (double)GetValue(ImageHorizontalOffsetProperty); }
            set { SetValue(ImageHorizontalOffsetProperty, value); }
        }

        public static readonly DependencyProperty ImageHorizontalOffsetProperty =
            DependencyProperty.Register("ImageHorizontalOffset", typeof(double), typeof(CropRotateControl), new PropertyMetadata(0.0));

        /// <summary>
        /// Offset of the image relative to the top side of the control
        /// The sum of SelectionVerticalOffset and the inverted value of CropArea.Y
        /// </summary>
        public double ImageVerticalOffset
        {
            get { return (double)GetValue(ImageVerticalOffsetProperty); }
            set { SetValue(ImageVerticalOffsetProperty, value); }
        }

        public static readonly DependencyProperty ImageVerticalOffsetProperty =
            DependencyProperty.Register("ImageVerticalOffset", typeof(double), typeof(CropRotateControl), new PropertyMetadata(0.0));

        #endregion


        public CropRotateControl()
        {
            this.InitializeComponent();
        }

        private void ImageControl_ImageOpened(object sender, RoutedEventArgs e)
        {
            var image = sender as Image;
            _imageActualSize = new Size(image.ActualWidth, image.ActualHeight);

            _imageOpened = true;

            SetOffsets();
        }

        private void UserControl_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (!_imageOpened)
            {
                return;
            }

            SetOffsets();
        }

        private void ResizeCropArea(double deltaX, double deltaY)
        {
            double? width = CropArea.Width;
            double? height = CropArea.Height;

            NormalizedToScreenPixels(ref width, ref height);

            width += deltaX;
            height += deltaY;

            ScreenPixelsToNormalized(ref width, ref height);

            var newCrop = new Rect() { X = CropArea.X, Y = CropArea.Y, Width = width.Value, Height = height.Value };

            //Constrain new values
            if ((newCrop.X + newCrop.Width) > 1.0)
            {
                newCrop.Width = 1.0 - newCrop.X;
            }
            else if ((newCrop.Y + newCrop.Height) > 1.0)
            {
                newCrop.Height = 1.0 - newCrop.Y;
            }

            CropArea = newCrop;
        }

        private void PanCropArea(double deltaX, double deltaY)
        {
            double? x = CropArea.X;
            double? y = CropArea.Y;

            NormalizedToScreenPixels(ref x, ref y);

            x += deltaX;
            y += deltaY;

            ScreenPixelsToNormalized(ref x, ref y);

            CropArea = new Rect() { X = x.Value, Y = y.Value, Width = CropArea.Width, Height = CropArea.Height };
        }

        private void SetOffsets()
        {
            var nettoWidth = this.ActualWidth - SelectionAreaMargin.Left - SelectionAreaMargin.Right;
            var nettoHeight = this.ActualHeight - SelectionAreaMargin.Top - SelectionAreaMargin.Bottom;

            var xScale = nettoWidth / _imageActualSize.Width;
            var yScale = nettoHeight / _imageActualSize.Height;

            ImageScale = xScale < yScale ? xScale : yScale;

            SelectionWidth = ImageScale * _imageActualSize.Width;
            SelectionHeight = ImageScale * _imageActualSize.Height;

            SelectionHorizontalOffset = (this.ActualWidth / 2.0) - (SelectionWidth / 2.0);
            SelectionVerticalOffset = (this.ActualHeight / 2.0) - (SelectionHeight / 2.0);

            ImageHorizontalOffset = (SelectionHorizontalOffset - CropArea.X);
            ImageVerticalOffset = (SelectionVerticalOffset - CropArea.Y);

            //TEMP
            this.SelectionArea.RefreshDragHandles();
            //TEMP
        }

        private void SelectionArea_TopLeftResizeDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            PanCropArea(e.Delta.Translation.X, e.Delta.Translation.Y);
            ResizeCropArea(-e.Delta.Translation.X, -e.Delta.Translation.Y);

            SelectionHorizontalOffset += e.Delta.Translation.X;
            SelectionVerticalOffset += e.Delta.Translation.Y;

            SelectionWidth -= e.Delta.Translation.X;
            SelectionHeight -= e.Delta.Translation.Y;
        }

        private double delta = 0.0;

        private void SelectionArea_BottomRightResizeDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            var deltaY = SelectionWidth += e.Delta.Translation.X;

            if (SelectionWidth + e.Delta.Translation.X > this.ImageControl.Width)
            {
                SelectionWidth += e.Delta.Translation.X;
            }
                SelectionHeight += e.Delta.Translation.Y;

            ResizeCropArea(e.Delta.Translation.X, e.Delta.Translation.Y);
        }

        private void SelectionArea_PanDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            PanCropArea(-e.Delta.Translation.X, -e.Delta.Translation.Y);

            ImageHorizontalOffset += e.Delta.Translation.X;
            ImageVerticalOffset += e.Delta.Translation.Y;
        }

        private void SelectionArea_DragCompleted(object sender, EventArgs e)
        {
            var previousWidth = SelectionWidth;
            MaximizeSelectionArea();
            ScaleImage(previousWidth);
        }

        /// <summary>
        /// Maximizes size of SelectionArea given current ratio and SelectionAreaMargin
        /// </summary>
        private void MaximizeSelectionArea()
        {
            //Get size of viewport minus margins
            var maxWidth = this.ActualWidth - SelectionAreaMargin.Left - SelectionAreaMargin.Right;
            var maxHeight = this.ActualHeight - SelectionAreaMargin.Top - SelectionAreaMargin.Bottom;

            //Determine wether to adjust horizontally or vertically
            var xRatio = maxWidth / SelectionWidth;
            var yRatio = maxHeight / SelectionHeight;

            var ratio = xRatio < yRatio ? xRatio : yRatio;

            //Set size of SelectionArea
            SelectionWidth *= ratio;
            SelectionHeight *= ratio;

            //Adjust SelectionArea offsets
            SelectionHorizontalOffset = (this.ActualWidth / 2.0) - (SelectionWidth / 2.0);
            SelectionVerticalOffset = (this.ActualHeight / 2.0) - (SelectionHeight / 2.0);
        }

        private void ScaleImage(double previousWidth)
        {
            var selectedImagePixels = previousWidth / ImageScale;
            ImageScale = SelectionWidth / selectedImagePixels;

            double? x = CropArea.X;
            double? y = CropArea.Y;
            NormalizedToScreenPixels(ref x, ref y);

            ImageHorizontalOffset = SelectionHorizontalOffset - x.Value;
            ImageVerticalOffset = SelectionVerticalOffset - y.Value;
        }

        private void ScreenPixelsToNormalized(ref double? horizontal, ref double? vertical)
        {
            if (horizontal != null)
            {
                horizontal = horizontal / _imageActualSize.Width / ImageScale;
            }
            if (vertical != null)
            {
                vertical = vertical / _imageActualSize.Height / ImageScale;
            }
        }

        private void NormalizedToScreenPixels(ref double? horizontal, ref double? vertical)
        {
            if (horizontal != null)
            {
                horizontal = horizontal * _imageActualSize.Width * ImageScale;
            }
            if (vertical != null)
            {
                vertical = vertical * _imageActualSize.Height * ImageScale;
            }
        }


    }
}
