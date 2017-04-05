using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace CropRotate
{
    public sealed partial class CropRotateControl : UserControl
    {
        public ImageSource Image
        {
            get { return (ImageSource)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty ImageProperty =
            DependencyProperty.Register("Image", typeof(ImageSource), typeof(CropRotateControl), new PropertyMetadata(null));
        

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

        public Point RotationCenter
        {
            get { return (Point)GetValue(RotationCenterProperty); }
            set { SetValue(RotationCenterProperty, value); }
        }

        public static readonly DependencyProperty RotationCenterProperty =
            DependencyProperty.Register("RotationCenter", typeof(Point), typeof(CropRotateControl), new PropertyMetadata(new Point()));
        

        public bool Flipped
        {
            get { return (bool)GetValue(FlippedProperty); }
            set { SetValue(FlippedProperty, value); }
        }

        public static readonly DependencyProperty FlippedProperty =
            DependencyProperty.Register("Flipped", typeof(bool), typeof(CropRotateControl), new PropertyMetadata(false));
        


        public CropRotateControl()
        {
            this.InitializeComponent();
        }
    }
}
