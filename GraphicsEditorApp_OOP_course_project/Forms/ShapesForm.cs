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
    public partial class ShapesForm : Form
    {
        private List<Shape> _shapes;
        private Shape _draggedShape = null;
        private Point _dragStartPoint;
        private Stack<List<Shape>> _undoStack = new Stack<List<Shape>>();
        private Stack<List<Shape>> _redoStack = new Stack<List<Shape>>();

        // Update constructor to attach the actual MouseDoubleClick event
        public ShapesForm(List<Shape> shapes)
        {
            InitializeComponent();
            _shapes = shapes;
            this.Paint += ShapesForm_Paint; // Attach Paint event handler
            this.MouseDoubleClick += ShapesForm_MouseDoubleClick; // Attach MouseDoubleClick event handler
            this.MouseDown += ShapesForm_MouseDown; // Attach MouseDown event handler
            this.MouseMove += ShapesForm_MouseMove; // Attach MouseMove event handler
            this.MouseUp += ShapesForm_MouseUp; // Attach MouseUp event handler
        }

        private void ShapesForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
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

        private void ShapesForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var shape in _shapes)
            {
                shape.Draw(g); // Call the Draw method for each shape
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Redraw all shapes
            foreach (var shape in _shapes)
            {
                shape.Draw(e.Graphics);
            }
        }

        public void RefreshShapes()
        {
            this.Invalidate(); // Trigger a repaint
        }

        private void SaveStateForUndo()
        {
            // Save a deep copy of the current state of _shapes to the undo stack
            _undoStack.Push(_shapes.Select(shape => shape.Clone()).ToList());
            _redoStack.Clear(); // Clear redo stack whenever a new action is performed
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (_undoStack.Count > 0)
            {
                // Save the current state to the redo stack
                _redoStack.Push(_shapes.Select(shape => shape.Clone()).ToList());

                // Restore the last state from the undo stack
                _shapes = _undoStack.Pop();

                RefreshShapes(); // Redraw the shapes
            }
            else
            {
                MessageBox.Show("No actions to undo.", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void redoButton_Click(object sender, EventArgs e)
        {
            if (_redoStack.Count > 0)
            {
                // Save the current state to the undo stack
                _undoStack.Push(_shapes.Select(shape => shape.Clone()).ToList());

                // Restore the last undone state from the redo stack
                _shapes = _redoStack.Pop();

                RefreshShapes(); // Redraw the shapes
            }
            else
            {
                MessageBox.Show("No actions to redo.", "Redo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

// Note: Ensure that the `Shape` class has a `Clone` method to create deep copies of shapes.
