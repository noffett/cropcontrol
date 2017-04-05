using System;
using System.ComponentModel;
using System.Numerics;
using Windows.UI;
using Windows.UI.Composition;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Hosting;

namespace CropRotate
{
    public sealed partial class NineGridResizing : UserControl
    {
        private readonly Compositor _compositor;
        private readonly Visual _backgroundContainer;
        private readonly SpriteVisual _ninegridVisual;
        private readonly CompositionNineGridBrush _ninegridBrush;
        private BorderNineGridScenario _selectedBrushScenario;
        private Vector2 _defaultSize;

        public NineGridResizing()
        {
            this.InitializeComponent();

            _compositor = ElementCompositionPreview.GetElementVisual(this).Compositor;

            // Add page loaded event listener
            this.Loaded += NineGridResizing_Loaded;

            // Set data context for data binding
            DataContext = this;

            // Sprite visual to be painted
            _ninegridVisual = _compositor.CreateSpriteVisual();

            // Create ninegridbrush and paint on visual;
            _ninegridBrush = _compositor.CreateNineGridBrush();
            _ninegridVisual.Brush = _ninegridBrush;

            // Clip compgrid 
            var compGrid = ElementCompositionPreview.GetElementVisual(CompGrid);
            compGrid.Clip = _compositor.CreateInsetClip();

            // Scene container to be scaled
            _backgroundContainer = ElementCompositionPreview.GetElementVisual(bkgHost);

            // Insert Composition island
            ElementCompositionPreview.SetElementChildVisual(ngHost, _ninegridVisual);

            // Set default combo box selection to first item
            _selectedBrushScenario = new BorderNineGridScenario(_compositor, _ninegridVisual.Size);
            _selectedBrushScenario.Selected(_ninegridVisual);

            SizeXSlider.ValueChanged += SizeXSlider_ValueChanged;
            SizeYSlider.ValueChanged += SizeYSlider_ValueChanged;
            ScaleSlider.ValueChanged += ScaleSlider_ValueChanged;
        }

        
        /// <summary>
        /// Called on page load to do initial setup.
        /// </summary>
        private void NineGridResizing_Loaded(object sender, RoutedEventArgs e)
        {
            // Set properties for ninegridVisual and backgroundContainer
            SetDefaultVisualProperties();
        }

        /// <summary>
        /// Recomputes transforms on visual based on updated UIElement size.
        /// </summary>
        private void CompGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            SetDefaultVisualProperties();
        }

        /// <summary>
        /// Called on x slider value changed; calls value timer to start attempt at value change.
        /// </summary>
        private void SizeXSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            // For non-animated case, change Size.X based on the percentage value from the slider
            var p = (float)e.NewValue / 100.0f;
            var x = _defaultSize.X;
            var y = _ninegridVisual.Size.Y;
            _ninegridVisual.Size = new Vector2(x * p, y);
        }
        
        /// <summary>
        /// Called on y slider value changed; calls value timer to start attempt at value change.
        /// </summary>
        private void SizeYSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            // For non-animated case, change Size.Y based on the percentage value from the slider
            var x = _ninegridVisual.Size.X;
            var p = (float)e.NewValue / 100.0f;
            var y = _defaultSize.Y;
            _ninegridVisual.Size = new Vector2(x, y * p);
        }

        /// <summary>
        /// Called on scale slider value changed; calls value timer to start attempt at value change.
        /// </summary>
        private void ScaleSlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            // For non-animated case, change Scale based on the percentage value from the slider
            var s = (float)e.NewValue;
            _ninegridVisual.Scale = new Vector3(s / 100.0f, s / 100.0f, 1);
        }

        /// <summary>
        /// Called on reset button click; reses sliders and visual to original values.
        /// </summary>
        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            // Reset values on controls and restore default transforms
            _ninegridVisual.Size = _defaultSize;
            _ninegridVisual.Scale = new Vector3(1, 1, 0);
            _ninegridBrush.SetInsetScales(1.0f);
            _backgroundContainer.Scale = new Vector3(1, 1, 0);
            SizeXSlider.Value = 100;
            SizeYSlider.Value = 100;
            ScaleSlider.Value = 100;
        }

        /// <summary>
        /// Set/update properties for the visual and container.
        /// </summary>
        private void SetDefaultVisualProperties()
        {
            // Compute size and transforms 
            _defaultSize = new Vector2((float)(Math.Min(ngHost.ActualWidth, ngHost.ActualHeight)) * 0.35f);

            // Specify centerpoint for scale transforms
            _backgroundContainer.CenterPoint = new Vector3(bkgHost.RenderSize.ToVector2() / 2, 0);

            _ninegridVisual.Size = new Vector2((float)SizeXSlider.Value / 100.0f * _defaultSize.X, (float)SizeYSlider.Value / 100.0f * _defaultSize.Y);
            _ninegridVisual.Offset = new Vector3(ngHost.RenderSize.ToVector2() / 2, 0);
            _ninegridVisual.AnchorPoint = new Vector2(0.5f);
        }
    }
}
