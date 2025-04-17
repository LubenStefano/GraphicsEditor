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
    public partial class CreateForm : Form
    {
        private MainForm _mainForm;

        public CreateForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm; // Store the reference to the MainForm instance
        }

        public List<Shape> UpdatedShapes { get; private set; }

        public CreateForm(List<Shape> shapes)
        {
            InitializeComponent();
            UpdatedShapes = shapes; // Initialize with the current shapes list
        }

        private void shapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset visibility of all labels and textboxes
            xValueLabel.Visible = false;
            xValueTextBox.Visible = false;
            yValueLabel.Visible = false;
            yValueTextBox.Visible = false;
            shapeColorComboBox.Visible = false;
            shapeColorLabel.Visible = false;
            isFilledCheckBox.Visible = false;
            isFilledLabel.Visible = false;
            aLabel.Visible = false;
            aTextBox.Visible = false;
            bLabel.Visible = false;
            bTextBox.Visible = false;
            cLabel.Visible = false;
            cTextBox.Visible = false;

            // Clear all text boxes
            clearTextboxFunc();

            // Set visibility for common controls
            xValueLabel.Visible = true;
            xValueTextBox.Visible = true;
            yValueLabel.Visible = true;
            yValueTextBox.Visible = true;
            shapeColorComboBox.Visible = true;
            shapeColorLabel.Visible = true;
            isFilledCheckBox.Visible = true;
            isFilledLabel.Visible = true;

            createButton.Visible = true;
            progressBar1.Visible = true;

            // Handle specific shape controls
            switch (shapeComboBox.SelectedItem.ToString())
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
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Initialize variables with default values
                int a = 0, b = 0, c = 0;

                // Validate numeric inputs
                if (!int.TryParse(xValueTextBox.Text, out int x) || x < 0 ||
                    !int.TryParse(yValueTextBox.Text, out int y) || y < 0 ||
                    (aTextBox.Visible && (!int.TryParse(aTextBox.Text, out a) || a <= 0)) ||
                    (bTextBox.Visible && (!int.TryParse(bTextBox.Text, out b) || b <= 0)) ||
                    (cTextBox.Visible && (!int.TryParse(cTextBox.Text, out c) || c <= 0)))
                {
                    MessageBox.Show("Please ensure all input values are valid numbers. 'x' and 'y' must be >= 0, and other values must be > 0.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create the shape based on the selected type
                Shape newShape = null;
                switch (shapeComboBox.SelectedItem.ToString())
                {
                    case "Square":
                        newShape = new Square(x, y, a, isFilledCheckBox.Checked, Color.FromName(shapeColorComboBox.SelectedItem.ToString()));
                        break;
                    case "Rectangle":
                        newShape = new ShapeClasses.Rectangle(x, y, a, b, isFilledCheckBox.Checked, Color.FromName(shapeColorComboBox.SelectedItem.ToString()));
                        break;
                    case "Circle":
                        newShape = new Circle(x, y, a, isFilledCheckBox.Checked, Color.FromName(shapeColorComboBox.SelectedItem.ToString()));
                        break;
                    case "Parallelogram":
                        newShape = new Parallelogram(x, y, a, b, c, isFilledCheckBox.Checked, Color.FromName(shapeColorComboBox.SelectedItem.ToString()));
                        break;
                    case "Rhombus":
                        newShape = new Rhombus(x, y, a, b, isFilledCheckBox.Checked, Color.FromName(shapeColorComboBox.SelectedItem.ToString()));
                        break;
                    case "Trapezoid":
                        newShape = new Trapezoid(x, y, a, b, c, isFilledCheckBox.Checked, Color.FromName(shapeColorComboBox.SelectedItem.ToString()));
                        break;
                    case "Triangle":
                        newShape = new Triangle(x, y, a, b, isFilledCheckBox.Checked, Color.FromName(shapeColorComboBox.SelectedItem.ToString()));
                        break;
                }

                if (newShape != null)
                {
                    _mainForm.AddShape(newShape); // Add the new shape to the MainForm
                    _mainForm.RefreshShapes(); // Refresh the MainForm to display the new shape
                }

                this.Close(); // Close the CreateForm
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while creating the shape: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Add a HashSet to track processed fields
        // Update the HashSet to store Control objects instead of TextBox objects
        private HashSet<Control> processedFields = new HashSet<Control>();

        // Add a method to count the total number of visible input fields
        private int GetTotalVisibleInputFields()
        {
            int count = 0;

            // Check visibility of all relevant input fields
            if (xValueTextBox.Visible) count++;
            if (yValueTextBox.Visible) count++;
            if (aTextBox.Visible) count++;
            if (bTextBox.Visible) count++;
            if (cTextBox.Visible) count++;
            if (shapeColorComboBox.Visible) count++;

            return count;
        }

        private void ValidateAndIncrementProgressBar(Control control, string fieldName, int minValue = 0)
        {
            // Check if the control is a TextBox and validate its value
            if (control is TextBox textBox)
            {
                if (!int.TryParse(textBox.Text, out int value) || value < minValue)
                {
                    MessageBox.Show($"Please enter a valid number for {fieldName}. It must be >= {minValue}.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox.Focus();
                    return;
                }
            }

            // Check if the control has already been processed
            if (!processedFields.Contains(control))
            {
                int totalFields = GetTotalVisibleInputFields();
                if (totalFields > 0)
                {
                    int increment = progressBar1.Maximum / totalFields;
                    progressBar1.Value = Math.Min(progressBar1.Value + increment, progressBar1.Maximum);
                }
                processedFields.Add(control); // Mark the control as processed
            }
        }

        private void shapeColorComboBox_Leave(object sender, EventArgs e)
        {
            // Check if a valid color is selected
            if (shapeColorComboBox.SelectedIndex >= 0)
            {
                ValidateAndIncrementProgressBar(shapeColorComboBox, "Shape Color");
            }
            else
            {
                MessageBox.Show("Please select a valid color for the shape.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                shapeColorComboBox.Focus(); // Return focus to the combo box for correction
            }
        }

        private void clearTextboxFunc()
        {
            xValueTextBox.Text = string.Empty;
            yValueTextBox.Text = string.Empty;
            aTextBox.Text = string.Empty;
            bTextBox.Text = string.Empty;
            cTextBox.Text = string.Empty;
            shapeColorComboBox.SelectedIndex = -1; 
            isFilledCheckBox.Checked = false; 
            progressBar1.Value = 0; 
            processedFields.Clear(); // Clear the processed fields
        }

        // Update the event handlers to use the new ValidateAndIncrementProgressBar method
        private void xValueTextBox_Leave(object sender, EventArgs e)
        {
            ValidateAndIncrementProgressBar(xValueTextBox, "X value", 0);
        }

        private void yValueTextBox_Leave(object sender, EventArgs e)
        {
            ValidateAndIncrementProgressBar(yValueTextBox, "Y value", 0);
        }

        private void aTextBox_Leave(object sender, EventArgs e)
        {
            ValidateAndIncrementProgressBar(aTextBox, "A value", 1);
        }

        private void bTextBox_Leave(object sender, EventArgs e)
        {
            ValidateAndIncrementProgressBar(bTextBox, "B value", 1);
        }

        private void cTextBox_Leave(object sender, EventArgs e)
        {
            ValidateAndIncrementProgressBar(cTextBox, "C value", 1);
        }
    }
}
