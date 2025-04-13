using GraphicsEditorApp_OOP_course_project.ShapeClasses;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditorApp_OOP_course_project
{
    public partial class EditForm : Form
    {
        private Shape _selectedShape;
        private ShapesForm _shapesForm;
        private ShapeInfoForm _shapeInfoForm;

        public EditForm(Shape selectedShape, ShapesForm shapesForm, ShapeInfoForm shapeInfoForm)
        {
            InitializeComponent();
            _selectedShape = selectedShape;
            _shapesForm = shapesForm;
            _shapeInfoForm = shapeInfoForm;


            XvalueLabel.Visible = true;
            XvalueTextBox.Visible = true;
            YvalueLabel.Visible = true;
            YvalueTextBox.Visible = true;
            ShapeColorComboBox.Visible = true;
            ShapeColorLabel.Visible = true;
            IsFilledCheckBox.Visible = true;
            IsFilledLabel.Visible = true;

            EditButton.Visible = true;

            switch (_selectedShape.GetType().Name)
            {
                case "Square":
                    aLabel.Text = "Side:";
                    aLabel.Visible = true;
                    TextBoxA.Visible = true;
                    break;

                case "Rectangle":
                    aLabel.Text = "Width:";
                    aLabel.Visible = true;
                    TextBoxA.Visible = true;
                    bLabel.Text = "Height:";
                    bLabel.Visible = true;
                    TextBoxB.Visible = true;
                    break;

                case "Parallelogram":
                    aLabel.Text = "Width:";
                    aLabel.Visible = true;
                    TextBoxA.Visible = true;
                    bLabel.Text = "Height:";
                    bLabel.Visible = true;
                    TextBoxB.Visible = true;
                    cLabel.Text = "Angle:";
                    cLabel.Visible = true;
                    TextBoxC.Visible = true;
                    break;

                case "Circle":
                    aLabel.Text = "Radius:";
                    aLabel.Visible = true;
                    TextBoxA.Visible = true;
                    break;

                case "Rhombus":
                    aLabel.Text = "Side:";
                    aLabel.Visible = true;
                    TextBoxA.Visible = true;
                    bLabel.Text = "Angle:";
                    bLabel.Visible = true;
                    TextBoxB.Visible = true;
                    break;

                case "Trapezoid":
                    aLabel.Text = "Base 1:";
                    aLabel.Visible = true;
                    TextBoxA.Visible = true;
                    bLabel.Text = "Base 2:";
                    bLabel.Visible = true;
                    TextBoxB.Visible = true;
                    cLabel.Text = "Height:";
                    cLabel.Visible = true;
                    TextBoxC.Visible = true;
                    break;

                case "Triangle":
                    aLabel.Text = "Base:";
                    aLabel.Visible = true;
                    TextBoxA.Visible = true;
                    bLabel.Text = "Height:";
                    bLabel.Visible = true;
                    TextBoxB.Visible = true;
                    break;
            }

            PopulateFields();
        }

        private void PopulateFields()
        {
            XvalueTextBox.Text = _selectedShape.GetX().ToString();
            YvalueTextBox.Text = _selectedShape.GetY().ToString();
            ShapeColorComboBox.SelectedItem = _selectedShape.GetColor();
            IsFilledCheckBox.Checked = _selectedShape.GetIsFilled();

            if (_selectedShape is Square square)
            {
                TextBoxA.Text = square.Side.ToString();
            }
            else if (_selectedShape is ShapeClasses.Rectangle rectangle)
            {
                TextBoxA.Text = rectangle.Width.ToString();
                TextBoxB.Text = rectangle.Height.ToString();
            }
            else if (_selectedShape is Circle circle)
            {
                TextBoxA.Text = circle.Radius.ToString();
            }
            else if (_selectedShape is Parallelogram parallelogram)
            {
                TextBoxA.Text = parallelogram.Width.ToString();
                TextBoxB.Text = parallelogram.Height.ToString();
                TextBoxC.Text = parallelogram.Angle.ToString();
            }
            else if (_selectedShape is Rhombus rhombus)
            {
                TextBoxA.Text = rhombus.Side.ToString();
                TextBoxB.Text = rhombus.Angle.ToString();
            }
            else if (_selectedShape is Trapezoid trapezoid)
            {
                TextBoxA.Text = trapezoid.Base1.ToString();
                TextBoxB.Text = trapezoid.Base2.ToString();
                TextBoxC.Text = trapezoid.Height.ToString();
            }
            else if (_selectedShape is Triangle triangle)
            {
                TextBoxA.Text = triangle.Base.ToString();
                TextBoxB.Text = triangle.Height.ToString();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize variables with default values
                int a = 0, b = 0, c = 0;

                // Validate numeric inputs
                if (!int.TryParse(XvalueTextBox.Text, out int x) || x < 0 ||
                    !int.TryParse(YvalueTextBox.Text, out int y) || y < 0 ||
                    (TextBoxA.Visible && (!int.TryParse(TextBoxA.Text, out a) || a <= 0)) ||
                    (TextBoxB.Visible && (!int.TryParse(TextBoxB.Text, out b) || b <= 0)) ||
                    (TextBoxC.Visible && (!int.TryParse(TextBoxC.Text, out c) || c <= 0)))
                {
                    MessageBox.Show("Please ensure all input values are valid numbers. 'x' and 'y' must be >= 0, and other values must be > 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _selectedShape.EditPosition(x, y);
                _selectedShape.EditColor(Color.FromName(ShapeColorComboBox.SelectedItem.ToString()));
                _selectedShape.EditFill(IsFilledCheckBox.Checked);

                if (_selectedShape is Square)
                {
                    _selectedShape.EditDimensions(a);
                }
                else if (_selectedShape is ShapeClasses.Rectangle)
                {
                    _selectedShape.EditDimensions(a, b);
                }
                else if (_selectedShape is Circle)
                {
                    _selectedShape.EditDimensions(a);
                }
                else if (_selectedShape is Parallelogram)
                {
                    _selectedShape.EditDimensions(a, b, c);
                }
                else if (_selectedShape is Rhombus)
                {
                    _selectedShape.EditDimensions(a, b);
                }
                else if (_selectedShape is Trapezoid)
                {
                    _selectedShape.EditDimensions(a, b, c);
                }
                else if (_selectedShape is Triangle)
                {
                    _selectedShape.EditDimensions(a, b);
                }

                // Ensure ShapesForm is refreshed
                if (_shapesForm != null)
                {
                    _shapesForm.Invalidate(); // Trigger a repaint of ShapesForm
                }
                if (_shapeInfoForm != null)
                {
                    _shapeInfoForm.Refresh(); // Refresh the ShapeInfoForm
                    _shapeInfoForm.PopulateFields();
                }

                this.DialogResult = DialogResult.OK; // Indicate successful edit
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while editing the shape: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
