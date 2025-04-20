using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GraphicsEditorApp_OOP_course_project.UIhelpers
{
    public class UIhelper
    {
        public static void ConfigureShapeUI(
            Dictionary<string, Control> controls,
            string selectedShape)
        {
            // Reset visibility of all controls
            foreach (var control in controls.Values)
            {
                control.Visible = false;
            }

            // Clear all text boxes
            ClearTextboxFunc(controls);

            // Set visibility for common controls
            controls["xValueLabel"].Visible = true;
            controls["xValueTextBox"].Visible = true;
            controls["yValueLabel"].Visible = true;
            controls["yValueTextBox"].Visible = true;
            controls["shapeColorComboBox"].Visible = true;
            controls["shapeColorLabel"].Visible = true;
            controls["isFilledCheckBox"].Visible = true;
            controls["isFilledLabel"].Visible = true;
            controls["createButton"].Visible = true;

            // Handle specific shape controls
            switch (selectedShape)
            {
                case "Square":
                    controls["aLabel"].Text = "Side:";
                    controls["aLabel"].Visible = true;
                    controls["aTextBox"].Visible = true;
                    break;

                case "Rectangle":
                    controls["aLabel"].Text = "Width:";
                    controls["aLabel"].Visible = true;
                    controls["aTextBox"].Visible = true;
                    controls["bLabel"].Text = "Height:";
                    controls["bLabel"].Visible = true;
                    controls["bTextBox"].Visible = true;
                    break;

                case "Parallelogram":
                    controls["aLabel"].Text = "Width:";
                    controls["aLabel"].Visible = true;
                    controls["aTextBox"].Visible = true;
                    controls["bLabel"].Text = "Height:";
                    controls["bLabel"].Visible = true;
                    controls["bTextBox"].Visible = true;
                    controls["cLabel"].Text = "Angle:";
                    controls["cLabel"].Visible = true;
                    controls["cTextBox"].Visible = true;
                    break;

                case "Circle":
                    controls["aLabel"].Text = "Radius:";
                    controls["aLabel"].Visible = true;
                    controls["aTextBox"].Visible = true;
                    break;

                case "Rhombus":
                    controls["aLabel"].Text = "Side:";
                    controls["aLabel"].Visible = true;
                    controls["aTextBox"].Visible = true;
                    controls["bLabel"].Text = "Angle:";
                    controls["bLabel"].Visible = true;
                    controls["bTextBox"].Visible = true;
                    break;

                case "Trapezoid":
                    controls["aLabel"].Text = "Base 1:";
                    controls["aLabel"].Visible = true;
                    controls["aTextBox"].Visible = true;
                    controls["bLabel"].Text = "Base 2:";
                    controls["bLabel"].Visible = true;
                    controls["bTextBox"].Visible = true;
                    controls["cLabel"].Text = "Height:";
                    controls["cLabel"].Visible = true;
                    controls["cTextBox"].Visible = true;
                    break;

                case "Triangle":
                    controls["aLabel"].Text = "Base:";
                    controls["aLabel"].Visible = true;
                    controls["aTextBox"].Visible = true;
                    controls["bLabel"].Text = "Height:";
                    controls["bLabel"].Visible = true;
                    controls["bTextBox"].Visible = true;
                    break;
            }
        }

        public static void ClearTextboxFunc(Dictionary<string, Control> controls)
        {
            controls.Select(c => c.Value)
                .OfType<System.Windows.Forms.TextBox>()
                .ToList()
                .ForEach(tb => tb.Clear());
        }
    }
}
