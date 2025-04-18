using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicsEditorApp_OOP_course_project.ShapeClasses;
using GraphicsEditorApp_OOP_course_project.Services;

namespace GraphicsEditorApp_OOP_course_project.Forms
{
    public partial class ShapesStatisticsForm : Form
    {
        private List<Shape> _shapes;

        public ShapesStatisticsForm(List<Shape> shapes)
        {
            InitializeComponent();

            //total shapes
            int totalShapes = shapes.Count;
            totalShapesTextBox.Text = totalShapes.ToString();

            // most used shape
            string mostUsedShape = ShapeStatisticsService.GetMostUsedShape(shapes);
            mostUsedShapeTextBox.Text = mostUsedShape;

            // most used color
            string mostUsedColor = ShapeStatisticsService.GetMostUsedColor(shapes);
            mostUsedColorTextBox.Text = mostUsedColor;



            _shapes = shapes;

            // Load all shape statistics
            var statistics = ShapeStatisticsService.GetShapeStatistics(shapes);

            // Populate the shapesDataGridView
            foreach (var stat in statistics)
            {
                shapesDataGridView.Rows.Add(stat.Type, stat.Usage, stat.AverageArea, stat.MostUsedColor);
            }
        }

        private void orderbyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected order criteria
            string selectedOrder = orderbyComboBox.SelectedItem.ToString();

            // Fetch sorted statistics based on the selected order
            var sortedStatistics = ShapeStatisticsService.GetShapeStatistics(_shapes, selectedOrder);

            // Clear existing rows in the DataGridView
            shapesDataGridView.Rows.Clear();

            // Populate the DataGridView with the sorted data
            foreach (var stat in sortedStatistics)
            {
                shapesDataGridView.Rows.Add(stat.Type, stat.Usage, stat.AverageArea, stat.MostUsedColor);
            }
        }
    }
}
