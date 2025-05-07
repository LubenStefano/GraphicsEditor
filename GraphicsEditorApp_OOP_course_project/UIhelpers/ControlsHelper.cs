using System.Collections.Generic;
using System.Windows.Forms;

namespace GraphicsEditorForms.UIhelpers
{
    public class ControlsHelper
    {
        public static void ConfigureShapeUI(Dictionary<string, Control> c, string shapeType)
        {
            foreach (var control in c.Values)
            {
                control.Visible = false;
                if (control is TextBox tb) tb.Clear();
            }

            Show(c, "xValueLabel", "xValueTextBox", "yValueLabel", "yValueTextBox",
                 "shapeColorComboBox", "shapeColorLabel", "isFilledCheckBox", "isFilledLabel",
                 "createButton", "progressBar1", "editButton", "deleteButton", "coordinatesTextBox",
                 "colorLabel", "filledColorCheckBox", "colorTextBox", "areaTextBox", "shapeTypeTextBox", "shapePanel");

            switch (shapeType)
            {
                case "Square":
                case "Rhombus":
                    SetLabel(c["aLabel"], "Side:");
                    Show(c, "aLabel", "aTextBox");
                    break;

                case "Rectangle":
                    SetLabel(c["aLabel"], "Width:");
                    SetLabel(c["bLabel"], "Height:");
                    Show(c, "aLabel", "aTextBox", "bLabel", "bTextBox");
                    break;

                case "Parallelogram":
                    SetLabel(c["aLabel"], "Width:");
                    SetLabel(c["bLabel"], "Height:");
                    SetLabel(c["cLabel"], "Angle:");
                    Show(c, "aLabel", "aTextBox", "bLabel", "bTextBox", "cLabel", "cTextBox");
                    break;

                case "Circle":
                    SetLabel(c["aLabel"], "Radius:");
                    Show(c, "aLabel", "aTextBox");
                    break;

                case "Trapezoid":
                    SetLabel(c["aLabel"], "Base 1:");
                    SetLabel(c["bLabel"], "Base 2:");
                    SetLabel(c["cLabel"], "Height:");
                    Show(c, "aLabel", "aTextBox", "bLabel", "bTextBox", "cLabel", "cTextBox");
                    break;

                case "Triangle":
                    SetLabel(c["aLabel"], "Base:");
                    SetLabel(c["bLabel"], "Height:");
                    Show(c, "aLabel", "aTextBox", "bLabel", "bTextBox");
                    break;
            }
        }

        private static void SetLabel(Control label, string text)
        {
            if (label is Label lbl) lbl.Text = text;
        }

        private static void Show(Dictionary<string, Control> controls, params string[] keys)
        {
            foreach (string key in keys)
                if (controls.ContainsKey(key)) controls[key].Visible = true;
        }

        public static void ClearTextboxFunc(Dictionary<string, Control> controls)
        {
            foreach (var control in controls.Values)
            {
                if (control is TextBox tb) tb.Clear();
                else if (control is CheckBox cb) cb.Checked = false;
            }
        }
    }
}
