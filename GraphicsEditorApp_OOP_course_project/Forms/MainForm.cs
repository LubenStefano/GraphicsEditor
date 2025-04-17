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
    public partial class MainForm : Form
    {
        private List<Shape> _shapes;
        private Shape _draggedShape = null;
        private Point _dragStartPoint;
        private Stack<List<Shape>> _undoStack = new Stack<List<Shape>>();
        private Stack<List<Shape>> _redoStack = new Stack<List<Shape>>();

        // Update constructor to attach the actual MouseDoubleClick event
        public MainForm(List<Shape> shapes)
        {
            InitializeComponent();
            _shapes = shapes ?? new List<Shape>(); // Initialize _shapes as an empty list if null
            panel1.Paint += Panel1_Paint; // Attach Paint event handler to panel1
            panel1.MouseDoubleClick += ShapesForm_MouseDoubleClick; // Attach MouseDoubleClick event handler to panel1
            panel1.MouseDown += ShapesForm_MouseDown; // Attach MouseDown event handler to panel1
            panel1.MouseMove += ShapesForm_MouseMove; // Attach MouseMove event handler to panel1
            panel1.MouseUp += ShapesForm_MouseUp; // Attach MouseUp event handler to panel1
        }

        private void ShapesForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_shapes == null) return; // Check if _shapes is null

            foreach (var shape in _shapes)
            {
                if (shape.Contains(e.Location))
                {
                    ShapeInfoForm infoForm = new ShapeInfoForm(shape, this);
                    infoForm.ShowDialog();
                    break;
                }
            }
        }

        private void ShapesForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (_shapes == null) return; // Check if _shapes is null

            foreach (var shape in _shapes)
            {
                if (shape.Contains(e.Location))
                {
                    _draggedShape = shape;
                    _dragStartPoint = e.Location;
                    SaveStateForUndo(); // Save state for undo before starting to drag
                    break;
                }
            }
        }

        private void ShapesForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_draggedShape != null && e.Button == MouseButtons.Left)
            {
                int deltaX = e.Location.X - _dragStartPoint.X;
                int deltaY = e.Location.Y - _dragStartPoint.Y;

                _draggedShape.Move(deltaX, deltaY);
                _dragStartPoint = e.Location;

                RefreshShapes(); // Redraw the shapes
            }
        }

        private void ShapesForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (_draggedShape != null)
            {
                _draggedShape = null; // Stop dragging
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (_shapes == null) return; // Check if _shapes is null

            Graphics g = e.Graphics;

            foreach (var shape in _shapes)
            {
                shape.Draw(g); // Call the Draw method for each shape
            }
        }

        // ...existing code...

        public void RefreshShapes()
        {
            panel1.Invalidate(); // Trigger a repaint for panel1
        }

        private void SaveStateForUndo()
        {
            if (_shapes == null) return; // Check if _shapes is null

            // Save a deep copy of the current state of _shapes to the undo stack
            _undoStack.Push(_shapes.Select(shape => shape.Clone()).ToList());
            _redoStack.Clear(); // Clear redo stack whenever a new action is performed
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (_shapes == null || _undoStack.Count == 0) // Check if _shapes is null or undo stack is empty
            {
                MessageBox.Show("No actions to undo.", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Save the current state to the redo stack
            _redoStack.Push(_shapes.Select(shape => shape.Clone()).ToList());

            // Restore the last state from the undo stack
            _shapes = _undoStack.Pop();

            RefreshShapes(); // Redraw the shapes
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            if (_shapes == null || _redoStack.Count == 0) // Check if _shapes is null or redo stack is empty
            {
                MessageBox.Show("No actions to redo.", "Redo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Save the current state to the undo stack
            _undoStack.Push(_shapes.Select(shape => shape.Clone()).ToList());

            // Restore the last undone state from the redo stack
            _shapes = _redoStack.Pop();

            RefreshShapes(); // Redraw the shapes
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            mousePositionInfo.Text = $"X: {e.X}, Y: {e.Y}";
        }

        private void createShapeButton_Click(object sender, EventArgs e)
        {
            // Open the CreateForm and pass the current MainForm instance
            using (var createForm = new CreateForm(this))
            {
                createForm.ShowDialog(); // Show the CreateForm as a dialog
                RefreshShapes(); // Refresh the MainForm after the CreateForm is closed
            }
        }


        public void AddShape(Shape shape)
        {
            if (_shapes == null)
            {
                _shapes = new List<Shape>(); // Initialize _shapes if null
            }
            _shapes.Add(shape); // Add the new shape to the list
            RefreshShapes(); // Refresh the UI to display the new shape
        }

        // ...existing code...
    }
}
