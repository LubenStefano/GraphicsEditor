using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GraphicsEditorCore;
using GraphicsEditorShapes.ShapeClasses;
using GraphicsEditorForms.UIhelpers;

namespace GraphicsEditorForms
{
    public partial class EditForm : Form
    {
        private Shape _selectedShape;
        private CanvasService _canvasService;
        private Dictionary<string, Control> controls;
        private readonly MessageHandlerHelper _messageHandlerHelper;

        public EditForm(Shape selectedShape, CanvasService canvasService)
        {
            InitializeComponent();
            _selectedShape = selectedShape;
            _canvasService = canvasService;
            _messageHandlerHelper = new MessageHandlerHelper();

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
                   { "editButton", editButton },
               };

            ControlsHelper.ConfigureShapeUI(controls, _selectedShape.GetType().Name);

            PopulateFieldsHelper.PopulateBasicControls(
                xValueTextBox,
                yValueTextBox,
                shapeColorComboBox,
                isFilledCheckBox,
                _selectedShape
                );

            PopulateFieldsHelper.PopulateShapeSpecificControls(_selectedShape, controls);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<string, string> shapeData = new Dictionary<string, string>
                   {
                       { "x", xValueTextBox.Text },
                       { "y", yValueTextBox.Text },
                       { "color", shapeColorComboBox.SelectedItem.ToString() },
                       { "isFilled", isFilledCheckBox.Checked.ToString() },
                       { "a", aTextBox.Text },
                       { "b", bTextBox.Text },
                       { "c", cTextBox.Text }
                   };
                if(int.Parse(shapeData["x"]) < 0 || int.Parse(shapeData["y"]) < 0)
                {
                    _messageHandlerHelper.ShowError("Error", "Coordinates must be non-negative.");
                    return;
                } 

                _selectedShape.EditPosition(int.Parse(shapeData["x"]), int.Parse(shapeData["y"]));
                _selectedShape.EditColor(Color.FromName(shapeData["color"]));
                _selectedShape.EditFill(bool.Parse(shapeData["isFilled"]));

                if (_selectedShape is Square || _selectedShape is Circle || _selectedShape is Rhombus)
                {
                    int a = int.Parse(shapeData["a"]);
                    ValidateDimension(a);
                    _selectedShape.EditDimensions(a);
                }
                else if (_selectedShape is GraphicsEditorShapes.ShapeClasses.Rectangle || _selectedShape is Triangle)
                {
                    int a = int.Parse(shapeData["a"]);
                    int b = int.Parse(shapeData["b"]);
                    ValidateDimension(a, b);
                    _selectedShape.EditDimensions(a, b);
                }
                else if (_selectedShape is Parallelogram || _selectedShape is Trapezoid)
                {
                    int a = int.Parse(shapeData["a"]);
                    int b = int.Parse(shapeData["b"]);
                    int c = int.Parse(shapeData["c"]);
                    ValidateDimension(a, b, c);
                    _selectedShape.EditDimensions(a, b, c);
                }
            }
            catch (FormatException)
            {
                _messageHandlerHelper.ShowError("Invalid input format", "Invalid input format. Please enter valid numbers.");
            }
        }

        private void ValidateDimension(params int[] dimensions)
        {
            try
            {
                foreach (var dimension in dimensions)
                {
                    if (dimension <= 0)
                    {
                        _messageHandlerHelper.ShowError("Error", "Dimensions must be non-negative.");
                        return;
                    }
                }

                // Refresh the canvas
                _canvasService.InvalidateCanvas();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                _messageHandlerHelper.ShowError("Invalid input format", "Invalid input format. Please enter valid numbers.");
            }
        }
    }
}
