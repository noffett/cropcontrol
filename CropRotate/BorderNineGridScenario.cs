using System.Numerics;
using Windows.UI;
using Windows.UI.Composition;

namespace CropRotate
{
    public class BorderNineGridScenario
    {
        private readonly CompositionNineGridBrush _nineGridBrush;
        private readonly SpriteVisual _borderedContent;
        private readonly Compositor _compositor;

        public BorderNineGridScenario(Compositor compositor, Vector2 hostVisualSize)
        {
            _nineGridBrush = compositor.CreateNineGridBrush();
            _nineGridBrush.Source = compositor.CreateColorBrush(Colors.Black);
            _nineGridBrush.SetInsets(10.0f);
            _nineGridBrush.IsCenterHollow = true;

            _borderedContent = compositor.CreateSpriteVisual();
            _borderedContent.Size = hostVisualSize - new Vector2(2 * 10.0f);
            _borderedContent.Offset = new Vector3(10.0f, 10.0f, 0);
            _borderedContent.Brush = _nineGridBrush;

            _compositor = compositor;
        }
        

        public void Selected(SpriteVisual hostVisual)
        {
            // Set ColorBrush as Source to NineGridBrush with HollowCenter and insert child Content visual
            hostVisual.Brush = _nineGridBrush;
            hostVisual.Children.InsertAtTop(_borderedContent);

            // Run expression animations to manage the size of borderedContent child visual
            var sizeXExpression = _compositor.CreateExpressionAnimation("parent.Size.X - (ninegrid.LeftInset*ninegrid.LeftInsetScale + ninegrid.RightInset*ninegrid.RightInsetScale)");
            var sizeYExpression = _compositor.CreateExpressionAnimation("parent.Size.Y - (ninegrid.TopInset*ninegrid.TopInsetScale + ninegrid.BottomInset*ninegrid.BottomInsetScale)");
            var offsetXExpression = _compositor.CreateExpressionAnimation("ninegrid.LeftInset*ninegrid.LeftInsetScale");
            var offsetYExpression = _compositor.CreateExpressionAnimation("ninegrid.TopInset*ninegrid.TopInsetScale");
            sizeXExpression.SetReferenceParameter("parent", hostVisual);
            sizeXExpression.SetReferenceParameter("ninegrid", _nineGridBrush);
            sizeYExpression.SetReferenceParameter("parent", hostVisual);
            sizeYExpression.SetReferenceParameter("ninegrid", _nineGridBrush);
            offsetXExpression.SetReferenceParameter("parent", hostVisual);
            offsetXExpression.SetReferenceParameter("ninegrid", _nineGridBrush);
            offsetYExpression.SetReferenceParameter("parent", hostVisual);
            offsetYExpression.SetReferenceParameter("ninegrid", _nineGridBrush);

            _borderedContent.StartAnimation("Size.X", sizeXExpression);
            _borderedContent.StartAnimation("Size.Y", sizeYExpression);
            _borderedContent.StartAnimation("Offset.X", offsetXExpression);
            _borderedContent.StartAnimation("Offset.Y", offsetYExpression);
        }
    }
}
