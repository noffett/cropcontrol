using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace CropRotate
{
    public enum ResizeHandleOrientation
    {
        None,
        Horizontal,
        Vertical,
        HorizontalAndVertical
    }

    public class ResizeHandle : Control
    {
        public event ManipulationDeltaEventHandler ResizeDelta;
        public event ManipulationCompletedEventHandler ResizeCompleted;

        public ResizeHandleOrientation Orientation
        {
            get { return (ResizeHandleOrientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(ResizeHandleOrientation), typeof(ResizeHandle), new PropertyMetadata(ResizeHandleOrientation.None, OnOrientationPropertyChanged));

        private static void OnOrientationPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var that = d as ResizeHandle;
            var orientation = (ResizeHandleOrientation)e.NewValue;

            switch (orientation)
            {
                case ResizeHandleOrientation.Horizontal:
                    that.ManipulationMode = ManipulationModes.TranslateX;
                    break;
                case ResizeHandleOrientation.Vertical:
                    that.ManipulationMode = ManipulationModes.TranslateY;
                    break;
                case ResizeHandleOrientation.HorizontalAndVertical:
                    that.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;
                    break;
            }
        }

        protected override void OnManipulationDelta(ManipulationDeltaRoutedEventArgs e)
        {
            ResizeDelta?.Invoke(this, e);
        }

        protected override void OnManipulationCompleted(ManipulationCompletedRoutedEventArgs e)
        {
            ResizeCompleted?.Invoke(this, e);
        }
    }
}
