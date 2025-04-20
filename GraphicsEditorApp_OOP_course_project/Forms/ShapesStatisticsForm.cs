using System.Collections.Generic;
using System.Windows.Forms;
using GraphicsEditorCore;
using GraphicsEditorServices;
using GraphicsEditorShapes.ShapeClasses;

namespace GraphicsEditorApp_OOP_course_project.Forms
{
    public partial class ShapesStatisticsForm : Form
    {
        private CanvasService _canvasService;
        private List<Shape> _shapes;


        public ShapesStatisticsForm(CanvasService canvasService)
        {
            InitializeComponent();

            _canvasService = canvasService; 
            _shapes = _canvasService.Shapes;

            
            //total shapes
            int totalShapes = _shapes.Count;
            totalShapesTextBox.Text = totalShapes.ToString();

            // most used shape
            string mostUsedShape = ShapeStatisticsService.GetMostUsedShape(_shapes);
            mostUsedShapeTextBox.Text = mostUsedShape;

            // most used color
            string mostUsedColor = ShapeStatisticsService.GetMostUsedColor(_shapes);
            mostUsedColorTextBox.Text = mostUsedColor;


            // Load all shape statistics
            var statistics = ShapeStatisticsService.GetShapeStatistics(_shapes);

            // Populate the shapesDataGridView
            foreach (dynamic stat in statistics)
            {
                shapesDataGridView.Rows.Add(stat.Type, stat.Usage, stat.AverageArea, stat.MostUsedColor);
            }
        }
    }
}