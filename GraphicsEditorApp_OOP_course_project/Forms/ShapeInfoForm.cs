using GraphicsEditorApp_OOP_course_project.ShapeClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsEditorApp_OOP_course_project
{
    public partial class ShapeInfoForm: Form
    {
        private Shape _selectedShape;
        private MainForm _shapesForm;
        public ShapeInfoForm(Shape shape, MainForm shapesForm)
        {
            InitializeComponent();
            _selectedShape = shape;
            _shapesForm = shapesForm;

            // Attach the Paint event of the shapePanel to the shapePanel_Paint method
            shapePanel.Paint += shapePanel_Paint;


            switch (_selectedShape.GetType().Name)
            {
                case "Square":
                    aLabel.Text = "Side:";
                    aLabel.Visible = true;
                    aTextBox.Visible = true;
                    break;

                case "Rectangle":
                    aLabel.Text = "Width:";
                    aLabel.Visible = true;
                    aTextBox.Visible = true;
                    bLabel.Text = "Height:";
                    bLabel.Visible = true;
                    bTextBox.Visible = true;
                    break;

                case "Parallelogram":
                    aLabel.Text = "Width:";
                    aLabel.Visible = true;
                    aTextBox.Visible = true;
                    bLabel.Text = "Height:";
                    bLabel.Visible = true;
                    bTextBox.Visible = true;
                    cLabel.Text = "Angle:";
                    cLabel.Visible = true;
                    cTextBox.Visible = true;
                    break;

                case "Circle":
                    aLabel.Text = "Radius:";
                    aLabel.Visible = true;
                    aTextBox.Visible = true;
                    break;

                case "Rhombus":
                    aLabel.Text = "Side:";
                    aLabel.Visible = true;
                    aTextBox.Visible = true;
                    bLabel.Text = "Angle:";
                    bLabel.Visible = true;
                    bTextBox.Visible = true;
                    break;

                case "Trapezoid":
                    aLabel.Text = "Base 1:";
                    aLabel.Visible = true;
                    aTextBox.Visible = true;
                    bLabel.Text = "Base 2:";
                    bLabel.Visible = true;
                    bTextBox.Visible = true;
                    cLabel.Text = "Height:";
                    cLabel.Visible = true;
                    cTextBox.Visible = true;
                    break;

                case "Triangle":
                    aLabel.Text = "Base:";
                    aLabel.Visible = true;
                    aTextBox.Visible = true;
                    bLabel.Text = "Height:";
                    bLabel.Visible = true;
                    bTextBox.Visible = true;
                    break;
            }

            PopulateFields();
        }

        public void PopulateFields()
        {
            coordinatesTextBox.Text = $"X: {_selectedShape.GetX()}, Y: {_selectedShape.GetY()}";
            colorLabel.Text = _selectedShape.GetColor().Name;
            filledColorCheckBox.Checked = _selectedShape.GetIsFilled();
            colorTextBox.Text = _selectedShape.GetColor().Name;
            areaTextBox.Text = _selectedShape.CalculateArea().ToString();  
            shapeTypeTextBox.Text = _selectedShape.GetType().Name;

            if (_selectedShape is Square square)
            {
                aTextBox.Text = square.Side.ToString();
            }
            else if (_selectedShape is ShapeClasses.Rectangle rectangle)
            {
                aTextBox.Text = rectangle.Width.ToString();
                bTextBox.Text = rectangle.Height.ToString();
            }
            else if (_selectedShape is Circle circle)
            {
                aTextBox.Text = circle.Radius.ToString();
            }
            else if (_selectedShape is Parallelogram parallelogram)
            {
                aTextBox.Text = parallelogram.Width.ToString();
                bTextBox.Text = parallelogram.Height.ToString();
                cTextBox.Text = parallelogram.Angle.ToString();
            }
            else if (_selectedShape is Rhombus rhombus)
            {
                aTextBox.Text = rhombus.Side.ToString();
                bTextBox.Text = rhombus.Angle.ToString();
            }
            else if (_selectedShape is Trapezoid trapezoid)
            {
                aTextBox.Text = trapezoid.Base1.ToString();
                bTextBox.Text = trapezoid.Base2.ToString();
                cTextBox.Text = trapezoid.Height.ToString();
            }
            else if (_selectedShape is Triangle triangle)
            {
                aTextBox.Text = triangle.Base.ToString();
                bTextBox.Text = triangle.Height.ToString();
            }
        }

        private void shapePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Save the original position of the shape
            int originalX = _selectedShape.GetX();
            int originalY = _selectedShape.GetY();

            // Calculate the center of the panel
            int panelCenterX = shapePanel.Width / 2;
            int panelCenterY = shapePanel.Height / 2;

            // Adjust the shape's position to center it in the panel
            if (_selectedShape is Square square)
            {
                _selectedShape.EditPosition(panelCenterX - square.Side / 2, panelCenterY - square.Side / 2);
            }
            else if (_selectedShape is Circle circle)
            {
                _selectedShape.EditPosition(panelCenterX - circle.Radius / 2, panelCenterY - circle.Radius / 2);
            }
            else if (_selectedShape is ShapeClasses.Rectangle rectangle)
            {
                _selectedShape.EditPosition(panelCenterX - rectangle.Width / 2, panelCenterY - rectangle.Height / 2);
            }
            else if (_selectedShape is Triangle triangle)
            {
                _selectedShape.EditPosition(panelCenterX - triangle.Base / 2, panelCenterY - triangle.Height / 2);
            }
            else if (_selectedShape is Parallelogram parallelogram)
            {
                _selectedShape.EditPosition(panelCenterX - parallelogram.Width / 2, panelCenterY - parallelogram.Height / 2);
            }
            else if (_selectedShape is Rhombus rhombus)
            {
                _selectedShape.EditPosition(panelCenterX - rhombus.Side / 2, panelCenterY - rhombus.Side / 2);
            }
            else if (_selectedShape is Trapezoid trapezoid)
            {
                _selectedShape.EditPosition(panelCenterX - trapezoid.Base1 / 2, panelCenterY - trapezoid.Height / 2);
            }

            // Draw the shape
            _selectedShape.Draw(g);

            // Restore the original position of the shape
            _selectedShape.EditPosition(originalX, originalY);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(_selectedShape, _shapesForm, this);
            editForm.ShowDialog();

        }

        public void RefreshShapePanel()
        {
            shapePanel.Invalidate(); // Trigger a repaint of the shapePanel
        }
    }
}
