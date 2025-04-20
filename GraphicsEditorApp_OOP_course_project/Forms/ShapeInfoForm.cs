using GraphicsEditorCore;
using GraphicsEditorShapes.ShapeClasses;
using GraphicsEditorForms.UIhelpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditorForms
{
    public partial class ShapeInfoForm : Form
    {
        private Shape _selectedShape;
        private CanvasService _canvasService;
        private Dictionary<string, Control> controls;

        public ShapeInfoForm(Shape shape, MainForm shapesForm, CanvasService canvasService)
        {
            InitializeComponent();
            _selectedShape = shape;
            _canvasService = canvasService;

            // Initialize the controls dictionary
            controls = new Dictionary<string, Control>
                {
                    { "coordinatesTextBox", coordinatesTextBox },
                    { "colorLabel", shapeColorLabel },
                    { "filledColorCheckBox", isFilledCheckBox },
                    { "colorTextBox", shapeColorTextBox },
                    { "areaTextBox", areaTextBox },
                    { "shapeTypeTextBox", shapeTypeTextBox },
                    { "aLabel", aLabel },
                    { "aTextBox", aTextBox },
                    { "bLabel", bLabel },
                    { "bTextBox", bTextBox },
                    { "cLabel", cLabel },
                    { "cTextBox", cTextBox },
                    { "editButton", editButton },
                    { "deleteButton", deleteButton },
                    { "shapePanel", shapePanel }
                };

            // Configure the UI dynamically based on the selected shape
            ControlsHelper.ConfigureShapeUI(controls, _selectedShape.GetType().Name);

            // Replace this line:
            PopulateFieldsHelper.PopulateInfoControls(
                coordinatesTextBox,
                shapeColorLabel,
                isFilledCheckBox,
                shapeColorTextBox,
                areaTextBox,
                shapeTypeTextBox,
                _selectedShape
            );

            PopulateFieldsHelper.PopulateShapeSpecificControls(_selectedShape, controls);

            // Attach the Paint event of the shapePanel to the shapePanel_Paint method
            shapePanel.Paint += shapePanel_Paint;
        }

        private void shapePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int originalX = _selectedShape.GetX();
            int originalY = _selectedShape.GetY();

            // Центрирай чрез помощен клас
            ShapeCenteringHelper.CenterShapeInPanel(_selectedShape, shapePanel);

            // Рисувай
            _selectedShape.Draw(g);

            // Възстанови оригиналните координати
            _selectedShape.EditPosition(originalX, originalY);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            using (EditForm editForm = new EditForm(_selectedShape, _canvasService))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // With this corrected line:
                   
                    RefreshShapePanel();
                }
            }
        }

        public void RefreshShapePanel()
        {
            shapePanel.Invalidate(); // Trigger a repaint of the shapePanel
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedShape != null)
            {
                // Remove the selected shape from the CanvasService
                _canvasService.RemoveShape(_selectedShape);

                // Refresh the MainForm to reflect the changes
                _canvasService.InvalidateCanvas();

                // Close the ShapeInfoForm
                this.Close();
            }
        }
    }
}
