using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GraphicsEditorApp_OOP_course_project.ShapeClasses;


namespace GraphicsEditorApp_OOP_course_project
{
    public partial class MainForm : Form
    {
        private List<Shape> _shapes;
        private Shape _draggedShape = null;
        private Point _dragStartPoint;
        private Stack<List<Shape>> _undoStack = new Stack<List<Shape>>();
        private Stack<List<Shape>> _redoStack = new Stack<List<Shape>>();

        private bool _isDrawing = false;
        private Bitmap _drawingBitmap;
        private Point _lastPoint;
        private Color _currentColor = Color.Black; // Default color
        private bool _isPenMode = true; // Default to pen mode
        private bool _isSelectMode = true; // Default to "select" mode
        private bool _isEraserMode = false; // Add a flag for eraser mode

        // Update constructor to attach the actual MouseDoubleClick event
        public MainForm(List<Shape> shapes)
        {
            InitializeComponent();
            _shapes = shapes ?? new List<Shape>(); // Initialize _shapes as an empty list if null
            panel1.Paint += Panel1_Paint; // Attach Paint event handler to panel1
            panel1.MouseDoubleClick += ShapesForm_MouseDoubleClick; // Attach MouseDoubleClick event handler to panel1
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (_drawingBitmap == null)
            {
                _drawingBitmap = new Bitmap(panel1.Width, panel1.Height);
            }
            panel1.Invalidate(); // Trigger an initial repaint
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            _isSelectMode = true; // Enable "select" mode
            panel1.Cursor = Cursors.Default; // Set the cursor to default
        }

        private void penButton_Click(object sender, EventArgs e)
        {
            _isSelectMode = false; // Disable "select" mode
            _isPenMode = true; // Enable pen mode
            panel1.Cursor = Cursors.Cross; // Change cursor to cross for pen
        }

        private void brushButton_Click(object sender, EventArgs e)
        {
            _isSelectMode = false; // Disable "select" mode
            _isPenMode = false; // Enable brush mode
            panel1.Cursor = Cursors.Cross; // Change cursor to cross for brush
        }

        private void eraserButton_Click(object sender, EventArgs e)
        {
            _isSelectMode = false; // Disable "select" mode
            _isEraserMode = true; // Enable eraser mode
            panel1.Cursor = Cursors.Cross; // Change cursor to cross for eraser
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    _currentColor = colorDialog.Color;
                    colorPictureBox.BackColor = _currentColor; // Update the color preview
                }
            }
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_isEraserMode)
            {
                // Eraser logic
                if (e.Button == MouseButtons.Left)
                {
                    _isDrawing = true;
                    _lastPoint = e.Location;
                    SaveStateForUndo(); // Save the current state for undo
                }
            }
            else
            {
                if (_isSelectMode)
                {
                    // Shape movement logic
                    if (_shapes == null) return;

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
                else
                {
                    // Drawing logic
                    if (e.Button == MouseButtons.Left)
                    {
                        _isDrawing = true;
                        _lastPoint = e.Location;
                        SaveStateForUndo(); // Save the current state for undo
                    }
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            mousePositionInfo.Text = $"X: {e.X}, Y: {e.Y}";

            if (_isEraserMode)
            {
                // Eraser logic
                if (_isDrawing && e.Button == MouseButtons.Left)
                {
                    using (Graphics g = Graphics.FromImage(_drawingBitmap))
                    {
                        Pen eraser = new Pen(Color.White, 10); // Eraser with white color and thickness
                        g.DrawLine(eraser, _lastPoint, e.Location);
                    }
                    _lastPoint = e.Location;
                    panel1.Invalidate(); // Trigger a repaint
                }
            }
            else
            {
                if (_isSelectMode)
                {
                    // Shape movement logic
                    if (_draggedShape != null && e.Button == MouseButtons.Left)
                    {
                        int deltaX = e.Location.X - _dragStartPoint.X;
                        int deltaY = e.Location.Y - _dragStartPoint.Y;

                        _draggedShape.Move(deltaX, deltaY);
                        _dragStartPoint = e.Location;

                        RefreshShapes(); // Redraw the shapes
                    }
                }
                else
                {
                    // Drawing logic
                    if (_isDrawing && e.Button == MouseButtons.Left)
                    {
                        using (Graphics g = Graphics.FromImage(_drawingBitmap))
                        {
                            Pen pen = _isPenMode ? new Pen(_currentColor, 1) : new Pen(_currentColor, 5);
                            g.DrawLine(pen, _lastPoint, e.Location);
                        }
                        _lastPoint = e.Location;
                        panel1.Invalidate(); // Trigger a repaint
                    }
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (_isEraserMode)
            {
                if (_isDrawing)
                {
                    _isDrawing = false; // Finalize erasing
                }
            }
            else
            {
                if (_isSelectMode)
                {
                    // Shape movement logic
                    if (_draggedShape != null)
                    {
                        _draggedShape = null; // Stop dragging
                    }
                }
                else
                {
                    // Drawing logic
                    if (_isDrawing)
                    {
                        _isDrawing = false; // Finalize drawing
                    }
                }
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (_shapes != null)
            {
                foreach (var shape in _shapes)
                {
                    shape.Draw(e.Graphics); // Draw shapes
                }
            }

            // Ensure _drawingBitmap is not null before drawing
            if (_drawingBitmap == null)
            {
                _drawingBitmap = new Bitmap(panel1.Width, panel1.Height);
            }

            e.Graphics.DrawImage(_drawingBitmap, Point.Empty); // Draw the bitmap
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

            // Ensure _drawingBitmap is not null
            if (_drawingBitmap == null)
            {
                _drawingBitmap = new Bitmap(panel1.Width, panel1.Height);
            }

            // Save the drawing bitmap state
            using (MemoryStream ms = new MemoryStream())
            {
                _drawingBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                Bitmap savedBitmap = new Bitmap(ms);

                // Fix: Provide required parameters for BitmapShape constructor
                _undoStack.Push(new List<Shape> { new BitmapShape(savedBitmap, 0, 0, _currentColor, false) });
            }
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

            // Restore the drawing bitmap state
            if (_undoStack.Count > 0 && _undoStack.Peek().FirstOrDefault() is BitmapShape bitmapShape)
            {
                _drawingBitmap = bitmapShape.Bitmap;
            }

            RefreshShapes(); // Redraw the shapes and bitmap
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

            // Restore the drawing bitmap state
            if (_redoStack.Count > 0 && _redoStack.Peek().FirstOrDefault() is BitmapShape bitmapShape)
            {
                _drawingBitmap = bitmapShape.Bitmap;
            }

            RefreshShapes(); // Redraw the shapes and bitmap
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
