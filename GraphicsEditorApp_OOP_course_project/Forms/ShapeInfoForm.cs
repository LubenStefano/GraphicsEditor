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

            ControlsHelper.ConfigureShapeUI(controls, _selectedShape.GetType().Name);

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

            shapePanel.Paint += shapePanel_Paint;
        }

        private void shapePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int originalX = _selectedShape.GetX();
            int originalY = _selectedShape.GetY();

            ShapeCenteringHelper.CenterShapeInPanel(_selectedShape, shapePanel);

            _selectedShape.Draw(g);

            _selectedShape.EditPosition(originalX, originalY);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            using (EditForm editForm = new EditForm(_selectedShape, _canvasService))
            {
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                   
                    RefreshShapePanel();
                }
            }
        }

        public void RefreshShapePanel()
        {
            shapePanel.Invalidate(); 
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedShape != null)
            {
                _canvasService.RemoveShape(_selectedShape);

                _canvasService.InvalidateCanvas();

                this.Close();
            }
        }
    }
}
