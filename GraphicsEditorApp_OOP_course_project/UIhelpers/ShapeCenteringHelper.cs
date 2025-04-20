using GraphicsEditorShapes.ShapeClasses;
using System.Windows.Forms;

namespace GraphicsEditorForms.UIhelpers
{
    public static class ShapeCenteringHelper
    {
        public static void CenterShapeInPanel(Shape shape, Panel panel)
        {
            int panelCenterX = panel.Width / 2;
            int panelCenterY = panel.Height / 2;

            if (shape is Square square)
            {
                shape.EditPosition(panelCenterX - square.Side / 2, panelCenterY - square.Side / 2);
            }
            else if (shape is Circle circle)
            {
                shape.EditPosition(panelCenterX - circle.Radius / 2, panelCenterY - circle.Radius / 2);
            }
            else if (shape is Rectangle rectangle)
            {
                shape.EditPosition(panelCenterX - rectangle.Width / 2, panelCenterY - rectangle.Height / 2);
            }
            else if (shape is Triangle triangle)
            {
                shape.EditPosition(panelCenterX - triangle.Base / 2, panelCenterY - triangle.Height / 2);
            }
            else if (shape is Parallelogram parallelogram)
            {
                shape.EditPosition(panelCenterX - parallelogram.Width / 2, panelCenterY - parallelogram.Height / 2);
            }
            else if (shape is Rhombus rhombus)
            {
                shape.EditPosition(panelCenterX - rhombus.Side / 2, panelCenterY - rhombus.Side / 2);
            }
            else if (shape is Trapezoid trapezoid)
            {
                shape.EditPosition(panelCenterX - trapezoid.Base1 / 2, panelCenterY - trapezoid.Height / 2);
            }
        }
    }
}
