using System.Collections.Generic;
using System.Windows.Forms;
using GraphicsEditorCore;
using GraphicsEditorServices;
using GraphicsEditorShapes.ShapeClasses;

namespace GraphicsEditorForms
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
            
            int totalShapes = _shapes.Count;
            totalShapesTextBox.Text = totalShapes.ToString();

            string mostUsedShape = ShapeStatisticsService.GetMostUsedShape(_shapes);
            mostUsedShapeTextBox.Text = mostUsedShape;

            string mostUsedColor = ShapeStatisticsService.GetMostUsedColor(_shapes);
            mostUsedColorTextBox.Text = mostUsedColor;

            var statistics = ShapeStatisticsService.GetShapeStatistics(_shapes);

            foreach (dynamic stat in statistics)
            {
                shapesDataGridView.Rows.Add(stat.Type, stat.Usage, stat.AverageArea, stat.MostUsedColor);
            }
        }
    }
}