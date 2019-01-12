using System.Windows;
using System.Windows.Media;

namespace CreateAttachedProperty
{
    public class RotationManager : DependencyObject
    {
        public static readonly DependencyProperty AngleProperty =
            DependencyProperty.RegisterAttached("AngleProperty", typeof(double), typeof(RotationManager),
                new UIPropertyMetadata(0.0, OnAnagleChanged));

        private static void OnAnagleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is UIElement element)
            {
                element.RenderTransformOrigin = new Point(0.5, 0.5);
                element.RenderTransform = new RotateTransform((double)e.NewValue);
            }
        }


        public static double GetAngle(DependencyObject obj)
        {
            return (double) obj.GetValue(AngleProperty);
        }

        public static void SetAngle(DependencyObject obj, double value)
        {
            obj.SetValue(AngleProperty, value);
        }
    }
}