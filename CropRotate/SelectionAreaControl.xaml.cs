using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;

namespace CropRotate
{
    public sealed partial class SelectionAreaControl : UserControl
    {
        public event EventHandler<ManipulationDeltaRoutedEventArgs> PanDelta;
        public event EventHandler<ManipulationDeltaRoutedEventArgs> TopLeftResizeDelta;
        public event EventHandler<ManipulationDeltaRoutedEventArgs> BottomRightResizeDelta;
        
        public event EventHandler DragCompleted;

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


        public double SelectionWidth
        {
            get { return (double)GetValue(SelectionWidthProperty); }
            set { SetValue(SelectionWidthProperty, value); }
        }

        public static readonly DependencyProperty SelectionWidthProperty =
            DependencyProperty.Register("SelectionWidth", typeof(double), typeof(SelectionAreaControl), new PropertyMetadata(0.0));


        public double SelectionHeight
        {
            get { return (double)GetValue(SelectionHeightProperty); }
            set { SetValue(SelectionHeightProperty, value); }
        }

        public static readonly DependencyProperty SelectionHeightProperty =
            DependencyProperty.Register("SelectionHeight", typeof(double), typeof(SelectionAreaControl), new PropertyMetadata(0.0));



        public SelectionAreaControl()
        {
            this.InitializeComponent();
        }

        private void PanHandle_DragDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            PanDelta?.Invoke(this, e);
        }

        private void TopLeftResizeHandle_DragDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            TopLeftResizeDelta?.Invoke(this, e);
        }

        private void BottomRightResizeHandle_DragDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            BottomRightResizeDelta?.Invoke(this, e);
        }

        private void DragHandle_DragCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            DragCompleted?.Invoke(this, EventArgs.Empty);
            RefreshDragHandles();
        }

        public void RefreshDragHandles()
        {
            this.DragHandlePanel.Width = SelectionWidth;
            this.DragHandlePanel.Height = SelectionHeight;

            var transform = this.DragHandlePanel.RenderTransform as TranslateTransform;

            transform.X = HorizontalOffset;
            transform.Y = VerticalOffset;
        }
    }
}
