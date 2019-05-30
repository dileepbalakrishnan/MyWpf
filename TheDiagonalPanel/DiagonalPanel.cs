using System.Windows;
using System.Windows.Controls;

namespace TheDiagonalPanel
{
    public class DiagonalPanel : Panel
    {
        protected override Size MeasureOverride(Size availableSize)
        {
            var requiredSize = new Size();
            foreach (UIElement child in InternalChildren)
            {
                child.Measure(availableSize);
                requiredSize.Width += child.DesiredSize.Width;
                requiredSize.Height += child.DesiredSize.Height;
            }
            return requiredSize;
        }


        protected override Size ArrangeOverride(Size finalSize)
        {
            var location = new Point();
            foreach (UIElement child in InternalChildren)
            {
                child.Arrange(new Rect(location, child.DesiredSize));
                location.X += child.DesiredSize.Width;
                location.Y += child.DesiredSize.Height;
            }
            return finalSize;
        }
    }
}