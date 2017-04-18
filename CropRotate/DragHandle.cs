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
    public enum DragHandleOrientation
    {
        None,
        Horizontal,
        Vertical,
        HorizontalAndVertical
    }

    public class DragHandle : Control
    {
        public event ManipulationDeltaEventHandler DragDelta;
        public event ManipulationCompletedEventHandler DragCompleted;

        public DragHandleOrientation Orientation
        {
            get { return (DragHandleOrientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly DependencyProperty OrientationProperty =
            DependencyProperty.Register("Orientation", typeof(DragHandleOrientation), typeof(DragHandle), new PropertyMetadata(DragHandleOrientation.None, OnOrientationPropertyChanged));

        private static void OnOrientationPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var that = d as DragHandle;
            var orientation = (DragHandleOrientation)e.NewValue;

            switch (orientation)
            {
                case DragHandleOrientation.Horizontal:
                    that.ManipulationMode = ManipulationModes.TranslateX;
                    break;
                case DragHandleOrientation.Vertical:
                    that.ManipulationMode = ManipulationModes.TranslateY;
                    break;
                case DragHandleOrientation.HorizontalAndVertical:
                    that.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateY;
                    break;
            }
        }

        protected override void OnManipulationDelta(ManipulationDeltaRoutedEventArgs e)
        {
            DragDelta?.Invoke(this, e);
        }

        protected override void OnManipulationCompleted(ManipulationCompletedRoutedEventArgs e)
        {
            DragCompleted?.Invoke(this, e);
        }
    }
}
