using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace CropRotate
{
    public sealed partial class SelectionAreaControl : UserControl
    {
        public double HorizontalOffset
        {
            get { return (double)GetValue(HorizontalOffsetProperty); }
            set { SetValue(HorizontalOffsetProperty, value); }
        }

        public static readonly DependencyProperty HorizontalOffsetProperty =
            DependencyProperty.Register("HorizontalOffset", typeof(double), typeof(SelectionAreaControl), new PropertyMetadata(0.0));


        public double VerticalOffset
        {
            get { return (double)GetValue(VerticalOffsetProperty); }
            set { SetValue(VerticalOffsetProperty, value); }
        }

        public static readonly DependencyProperty VerticalOffsetProperty =
            DependencyProperty.Register("VerticalOffset", typeof(double), typeof(SelectionAreaControl), new PropertyMetadata(0.0));


        public double VisualWidth
        {
            get { return (double)GetValue(VisualWidthProperty); }
            set { SetValue(VisualWidthProperty, value); }
        }

        public static readonly DependencyProperty VisualWidthProperty =
            DependencyProperty.Register("VisualWidth", typeof(double), typeof(SelectionAreaControl), new PropertyMetadata(400.0));


        public double VisualHeight
        {
            get { return (double)GetValue(VisualHeightProperty); }
            set { SetValue(VisualHeightProperty, value); }
        }

        public static readonly DependencyProperty VisualHeightProperty =
            DependencyProperty.Register("VisualHeight", typeof(double), typeof(SelectionAreaControl), new PropertyMetadata(300.0));


        public double RotationAngle
        {
            get { return (double)GetValue(RotationAngleProperty); }
            set { SetValue(RotationAngleProperty, value); }
        }

        public static readonly DependencyProperty RotationAngleProperty =
            DependencyProperty.Register("RotationAngle", typeof(double), typeof(SelectionAreaControl), new PropertyMetadata(0.0));


        public double RotationAnchorPoint
        {
            get { return (double)GetValue(RotationAnchorPointProperty); }
            set { SetValue(RotationAnchorPointProperty, value); }
        }

        public static readonly DependencyProperty RotationAnchorPointProperty =
            DependencyProperty.Register("RotationAnchorPoint", typeof(double), typeof(SelectionAreaControl), new PropertyMetadata(0.5));




        public SelectionAreaControl()
        {
            this.InitializeComponent();
        }


        private void TopLeftResizeHandle_ResizeDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            HorizontalOffset += e.Delta.Translation.X;
            VisualWidth -= e.Delta.Translation.X;

            VerticalOffset += e.Delta.Translation.Y;
            VisualHeight -= e.Delta.Translation.Y;
        }

        private void BottomRightResizeHandle_ResizeDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            VisualWidth += e.Delta.Translation.X;
            VisualHeight += e.Delta.Translation.Y;
        }

        private void ResizeHandle_ResizeCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            this.ResizeHandlePanel.SetValue(Canvas.LeftProperty, HorizontalOffset);
            this.ResizeHandlePanel.Width = VisualWidth;

            this.ResizeHandlePanel.SetValue(Canvas.TopProperty, VerticalOffset);
            this.ResizeHandlePanel.Height = VisualHeight;
        }

        private void ResizeHandle_ResizeDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            HorizontalOffset -= e.Delta.Translation.X;
            VerticalOffset -= e.Delta.Translation.Y;
        }
    }
}
