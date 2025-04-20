using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GraphicsEditorApp_OOP_course_project.UIhelpers;
using GraphicsEditorShapes.ShapeClasses;
using GraphicsEditorShapes.ShapeCreation;
using GraphicsEditorCore;

namespace GraphicsEditorApp_OOP_course_project
{
    public partial class CreateForm : Form
    {
        private CanvasService _canvasService;
        private readonly MessageHandlerHelper _messageHandlerHelper;

        // Move the initialization of the controls dictionary to the constructor
        private Dictionary<string, Control> controls;

        public CreateForm(CanvasService canvasService)
        {
            InitializeComponent();
            _canvasService = canvasService; // Store the reference to the MainForm instance
            _messageHandlerHelper = new MessageHandlerHelper();

            // Initialize the controls dictionary here
            controls = new Dictionary<string, Control>
                {
                    { "xValueLabel", xValueLabel },
                    { "xValueTextBox", xValueTextBox },
                    { "yValueLabel", yValueLabel },
                    { "yValueTextBox", yValueTextBox },
                    { "shapeColorComboBox", shapeColorComboBox },
                    { "shapeColorLabel", shapeColorLabel },
                    { "isFilledCheckBox", isFilledCheckBox },
                    { "isFilledLabel", isFilledLabel },
                    { "aLabel", aLabel },
                    { "aTextBox", aTextBox },
                    { "bLabel", bLabel },
                    { "bTextBox", bTextBox },
                    { "cLabel", cLabel },
                    { "cTextBox", cTextBox },
                    { "createButton", createButton },
                };
        }

        public List<Shape> UpdatedShapes { get; private set; }

        public CreateForm(List<Shape> shapes)
        {
            InitializeComponent();
            UpdatedShapes = shapes; // Initialize with the current shapes list

            // Initialize the controls dictionary here
            controls = new Dictionary<string, Control>
                {
                    { "xValueLabel", xValueLabel },
                    { "xValueTextBox", xValueTextBox },
                    { "yValueLabel", yValueLabel },
                    { "yValueTextBox", yValueTextBox },
                    { "shapeColorComboBox", shapeColorComboBox },
                    { "shapeColorLabel", shapeColorLabel },
                    { "isFilledCheckBox", isFilledCheckBox },
                    { "isFilledLabel", isFilledLabel },
                    { "aLabel", aLabel },
                    { "aTextBox", aTextBox },
                    { "bLabel", bLabel },
                    { "bTextBox", bTextBox },
                    { "cLabel", cLabel },
                    { "cTextBox", cTextBox },
                    { "createButton", createButton },
                };
        }

        private void shapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedShape = shapeComboBox.SelectedItem.ToString();
            ControlsHelper.ConfigureShapeUI(controls, selectedShape);
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate and collect shape data
                Dictionary<string, string> shapeData = new Dictionary<string, string>();

                if (shapeComboBox?.SelectedItem == null)
                {
                    _messageHandlerHelper.ShowError("Validation Error", "Shape type must be selected.");
                    return;
                }
                shapeData["type"] = shapeComboBox.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(xValueTextBox?.Text))
                {
                    _messageHandlerHelper.ShowError("Validation Error", "X value cannot be empty.");
                    return;
                }
                shapeData["x"] = xValueTextBox.Text;

                if (string.IsNullOrWhiteSpace(yValueTextBox?.Text))
                {
                    _messageHandlerHelper.ShowError("Validation Error", "Y value cannot be empty.");
                    return;
                }
                shapeData["y"] = yValueTextBox.Text;

                if (shapeColorComboBox?.SelectedItem == null)
                {
                    _messageHandlerHelper.ShowError("Validation Error", "Color must be selected.");
                    return;
                }
                shapeData["color"] = shapeColorComboBox.SelectedItem.ToString();

                shapeData["isFilled"] = isFilledCheckBox?.Checked.ToString() ?? "false";

                // Optional fields
                shapeData["a"] = aTextBox?.Text ?? string.Empty;
                shapeData["b"] = bTextBox?.Text ?? string.Empty;
                shapeData["c"] = cTextBox?.Text ?? string.Empty;

                // Create an instance of CreateShape to call the Create method
                CreateShape createShape = new CreateShape();
                Shape newShape = createShape.Create(shapeData);

                if (newShape != null)
                {
                    _canvasService.AddShape(newShape); // Add the new shape to the MainForm

                    // Create a Graphics object from the canvas bitmap and pass it to Render
                    using (Graphics g = Graphics.FromImage(_canvasService.DrawingBitmap))
                    {
                        _canvasService.InvalidateCanvas(); // Refresh the MainForm to display the new shape
                    }
                }
                ControlsHelper.ClearTextboxFunc(controls); // Clear all text boxes after creating the shape
                this.Close(); // Close the CreateForm
            }
            catch (Exception ex)
            {
                _messageHandlerHelper.ShowError("Error", ex.Message);
            }
        }
    }
}
