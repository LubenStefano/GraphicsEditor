using System.Collections.Generic;
using GraphicsEditorShapes.ShapeClasses;
using System.Windows.Forms;

namespace GraphicsEditorForms.UIhelpers
{
    public class PopulateFieldsHelper
    {
            public static void PopulateBasicControls(
                TextBox xTextBox,
                TextBox yTextBox,
                ComboBox colorComboBox,
                CheckBox isFilledCheckBox,
                Shape shape)
            {
                xTextBox.Text = shape.GetX().ToString();
                yTextBox.Text = shape.GetY().ToString();
                colorComboBox.SelectedItem = shape.GetColor().Name;
                isFilledCheckBox.Checked = shape.GetIsFilled();
            }

            public static void PopulateInfoControls(
                TextBox coordinatesTextBox,
                Label colorLabel,
                CheckBox filledCheckBox,
                TextBox colorTextBox,
                TextBox areaTextBox,
                TextBox shapeTypeTextBox,
                Shape shape)
            {
                coordinatesTextBox.Text = $"X: {shape.GetX()}, Y: {shape.GetY()}";
                colorLabel.Text = shape.GetColor().Name;
                filledCheckBox.Checked = shape.GetIsFilled();
                colorTextBox.Text = shape.GetColor().Name;
                areaTextBox.Text = shape.CalculateArea().ToString();
                shapeTypeTextBox.Text = shape.GetType().Name;
            }

            public static void PopulateShapeSpecificControls(
                Shape shape,
                Dictionary<string, Control> c)
            {
                if (shape is Square square)
                {
                    c["aTextBox"].Text = square.Side.ToString();
                }
                else if (shape is GraphicsEditorShapes.ShapeClasses.Rectangle rectangle)
                {
                    c["aTextBox"].Text = rectangle.Width.ToString();
                    c["bTextBox"].Text = rectangle.Height.ToString();
                }
                else if (shape is Circle circle)
                {
                    c["aTextBox"].Text = circle.Radius.ToString();
                }
                else if (shape is Parallelogram parallelogram)
                {
                    c["aTextBox"].Text = parallelogram.Width.ToString();
                    c["bTextBox"].Text = parallelogram.Height.ToString();
                    c["cTextBox"].Text = parallelogram.Angle.ToString();
                }
                else if (shape is Rhombus rhombus)
                {
                    c["aTextBox"].Text = rhombus.Side.ToString();
                    c["bTextBox"].Text = rhombus.Angle.ToString();
                }
                else if (shape is Trapezoid trapezoid)
                {
                    c["aTextBox"].Text = trapezoid.Base1.ToString();
                    c["bTextBox"].Text = trapezoid.Base2.ToString();
                    c["cTextBox"].Text = trapezoid.Height.ToString();
                }
                else if (shape is Triangle triangle)
                {
                    c["aTextBox"].Text = triangle.Base.ToString();
                    c["bTextBox"].Text = triangle.Height.ToString();
                }
            }
        }
}
