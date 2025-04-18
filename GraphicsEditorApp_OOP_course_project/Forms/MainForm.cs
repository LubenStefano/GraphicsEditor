using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GraphicsEditorApp_OOP_course_project.Forms;
using GraphicsEditorApp_OOP_course_project.Services;
using GraphicsEditorApp_OOP_course_project.ShapeClasses;

namespace GraphicsEditorApp_OOP_course_project
{
    public partial class MainForm : Form
    {
        public List<Shape> _shapes;
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
        private bool _isFillMode = false; // Add a flag to track the fill mode state

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

            // Enable double buffering to reduce flickering
            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, panel1, new object[] { true });
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
            StopDrawing(); // Stop any ongoing drawing or erasing
            _isSelectMode = true; // Enable "select" mode
            _isPenMode = false; // Disable pen mode
            _isEraserMode = false; // Disable eraser mode
            panel1.Cursor = Cursors.Default; // Set the cursor to default
        }

        private void penButton_Click(object sender, EventArgs e)
        {
            StopDrawing(); // Stop any ongoing drawing or erasing
            _isSelectMode = false; // Disable "select" mode
            _isPenMode = true; // Enable pen mode
            _isEraserMode = false; // Disable eraser mode
            panel1.Cursor = Cursors.Cross; // Change cursor to cross for pen
        }

        private void brushButton_Click(object sender, EventArgs e)
        {
            StopDrawing(); // Stop any ongoing drawing or erasing
            _isSelectMode = false; // Disable "select" mode
            _isPenMode = false; // Enable brush mode
            _isEraserMode = false; // Disable eraser mode
            panel1.Cursor = Cursors.Cross; // Change cursor to cross for brush
        }

        private void eraserButton_Click(object sender, EventArgs e)
        {
            StopDrawing(); // Stop any ongoing drawing or erasing
            _isSelectMode = false; // Disable "select" mode
            _isPenMode = false; // Disable pen mode
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
            if (_isFillMode)
            {
                // Handle filling a specific bitmap or shape
                if (_shapes != null)
                {
                    foreach (var shape in _shapes)
                    {
                        if (shape.Contains(e.Location)) // Check if the mouse is over a shape
                        {
                            SaveStateForUndo(); // Save the current state for undo
                            shape.EditFill(true); // Enable fill for the shape
                            shape.EditColor(_currentColor); // Set the fill color to the current color
                            RefreshShapes(); // Refresh the UI to reflect the changes
                            _isFillMode = false; // Exit fill mode after filling
                            panel1.Cursor = Cursors.Default; // Reset cursor to default
                            return;
                        }
                    }
                }

                // If no shape is clicked, apply flood-fill to the bitmap
                if (_drawingBitmap != null)
                {
                    SaveStateForUndo(); // Save the current state for undo
                    Color targetColor = _drawingBitmap.GetPixel(e.X, e.Y); // Get the color of the clicked pixel
                    FloodFill(_drawingBitmap, e.Location, targetColor, _currentColor); // Apply flood-fill
                    RefreshShapes(); // Refresh the UI to reflect the changes
                    _isFillMode = false; // Exit fill mode after filling
                    panel1.Cursor = Cursors.Default; // Reset cursor to default
                }
            }
            else
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
                        g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy; // Enable transparency
                        Brush eraserBrush = new SolidBrush(Color.Transparent);
                        g.FillEllipse(eraserBrush, e.X - 5, e.Y - 5, 10, 10); // Erase with a circular brush
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
            // Ensure _drawingBitmap is not null before drawing
            if (_drawingBitmap == null)
            {
                _drawingBitmap = new Bitmap(panel1.Width, panel1.Height);
            }

            e.Graphics.DrawImage(_drawingBitmap, Point.Empty); // Draw the bitmap first

            if (_shapes != null)
            {
                foreach (var shape in _shapes)
                {
                    shape.Draw(e.Graphics); // Draw shapes on top of the bitmap
                }
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
            _undoStack.Push(new List<Shape>(_shapes.Select(shape => shape.Clone()).ToList()));

            // Save the drawing bitmap state
            using (MemoryStream ms = new MemoryStream())
            {
                _drawingBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                Bitmap savedBitmap = new Bitmap(ms);
                _undoStack.Push(new List<Shape> { new BitmapShape(savedBitmap, 0, 0, _currentColor, false) });
            }

            _redoStack.Clear(); // Clear redo stack whenever a new action is performed
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_undoStack.Count == 0) // Check if undo stack is empty
                {
                    MessageBox.Show("No actions to undo.", "Undo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Save the current state to the redo stack
                SaveStateForRedo();

                // Restore the last state from the undo stack
                var lastState = _undoStack.Pop();
                if (lastState.FirstOrDefault() is BitmapShape bitmapShape)
                {
                    _drawingBitmap = bitmapShape.Bitmap;
                }
                else
                {
                    _shapes = lastState;
                }

                RefreshShapes(); // Redraw the shapes and bitmap
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"An error occurred while performing undo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void SaveStateForRedo()
        {
            if (_shapes == null) return; // Check if _shapes is null

            // Save a deep copy of the current state of _shapes to the redo stack
            _redoStack.Push(new List<Shape>(_shapes.Select(shape => shape.Clone()).ToList()));

            // Save the drawing bitmap state
            using (MemoryStream ms = new MemoryStream())
            {
                _drawingBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                Bitmap savedBitmap = new Bitmap(ms);
                _redoStack.Push(new List<Shape> { new BitmapShape(savedBitmap, 0, 0, _currentColor, false) });
            }
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

        public void StopDrawing()
        {
            _isDrawing = false; // Stop drawing
            _isEraserMode = false; // Stop erasing
            _isSelectMode = false; // Stop selecting
            panel1.Cursor = Cursors.Default; // Reset cursor to default
        }

        // Update the fillButton_Click method to toggle fill mode
        private void fillButton_Click(object sender, EventArgs e)
        {
            _isFillMode = !_isFillMode; // Toggle fill mode
            panel1.Cursor = _isFillMode ? Cursors.Cross : Cursors.Default; // Change cursor to indicate fill mode
        }

        // Add a flood-fill algorithm for filling closed areas in the bitmap
        private void FloodFill(Bitmap bitmap, Point pt, Color targetColor, Color replacementColor)
        {
            if (targetColor.ToArgb() == replacementColor.ToArgb()) return; // Avoid infinite loop if colors are the same

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(pt);

            while (pixels.Count > 0)
            {
                Point current = pixels.Pop();
                if (current.X < 0 || current.Y < 0 || current.X >= bitmap.Width || current.Y >= bitmap.Height)
                    continue; // Skip out-of-bounds points

                if (bitmap.GetPixel(current.X, current.Y).ToArgb() != targetColor.ToArgb())
                    continue; // Skip points that don't match the target color

                bitmap.SetPixel(current.X, current.Y, replacementColor); // Set the pixel to the replacement color

                // Add neighboring pixels to the stack
                pixels.Push(new Point(current.X + 1, current.Y));
                pixels.Push(new Point(current.X - 1, current.Y));
                pixels.Push(new Point(current.X, current.Y + 1));
                pixels.Push(new Point(current.X, current.Y - 1));
            }
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolsToolStripMenuItem.Checked)
            {
                toolsToolStripMenuItem.Checked = false;
                toolsPanel.Visible = false;
            }
            else
            {
                toolsToolStripMenuItem.Checked = true;
                toolsPanel.Visible = true;
            }

        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (statusBarToolStripMenuItem.Checked)
            {
                statusBarToolStripMenuItem.Checked = false;
                infoStatusStrip.Visible = false;
            }
            else
            {
                statusBarToolStripMenuItem.Checked = true;
                infoStatusStrip.Visible = true;
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show a confirmation dialog
            var result = MessageBox.Show(
                "Are you sure you want to open a new canvas? You will lose the current data.",
                "New Canvas",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                // Clear the shapes list
                _shapes = new List<Shape>();

                // Reset the drawing bitmap
                _drawingBitmap = new Bitmap(panel1.Width, panel1.Height);

                // Trigger a UI refresh to reflect the cleared state
                RefreshShapes();
            }
            // If "No" is selected, do nothing and retain the current canvas
        }

        private void openStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShapesStatisticsForm statisticsForm = new ShapesStatisticsForm(_shapes);
            statisticsForm.ShowDialog();
        }

        private void saveAsJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                saveFileDialog.DefaultExt = "json";
                saveFileDialog.AddExtension = true;
                saveFileDialog.Title = "Save Shapes";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ShapeSerializer.SaveToFile(saveFileDialog.FileName, _shapes);
                        MessageBox.Show("Shapes saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //_drawingBitmap.Save(saveFileDialog.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png); should add all shapes to the bitmap and background color
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to save shapes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PNG Files (*.png)|*.png|JPEG Files (*.jpg)|*.jpg|Bitmap Files (*.bmp)|*.bmp";
                saveFileDialog.DefaultExt = "png";
                saveFileDialog.AddExtension = true;
                saveFileDialog.Title = "Save Panel as Image";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Create a new bitmap with the size of the panel
                        Bitmap panelBitmap = new Bitmap(panel1.Width, panel1.Height);

                        // Draw the current bitmap and shapes onto the new bitmap
                        using (Graphics g = Graphics.FromImage(panelBitmap))
                        {
                            // Draw the existing bitmap
                            g.DrawImage(_drawingBitmap, Point.Empty);

                            // Draw all shapes
                            if (_shapes != null)
                            {
                                foreach (var shape in _shapes)
                                {
                                    shape.Draw(g);
                                }
                            }
                        }

                        // Save the bitmap to the specified file
                        panelBitmap.Save(saveFileDialog.FileName);
                        MessageBox.Show("Image saved successfully.", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to save image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void openJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON Files (*.json)|*.json|All Files (*.*)|*.*";
                openFileDialog.DefaultExt = "json";
                openFileDialog.Title = "Open Shapes from JSON";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load shapes from the selected file
                        List<Shape> loadedShapes = ShapeSerializer.LoadFromFile(openFileDialog.FileName);

                        // Update the _shapes list with the loaded shapes
                        _shapes = loadedShapes;

                        // Refresh the UI to display the loaded shapes
                        RefreshShapes();

                        MessageBox.Show("Shapes loaded successfully.", "Open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to load shapes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.bmp)|*.png;*.jpg;*.bmp|All Files (*.*)|*.*";
                openFileDialog.Title = "Open Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Load the selected image into the _drawingBitmap
                        Bitmap loadedImage = new Bitmap(openFileDialog.FileName);

                        // Resize the bitmap to fit the panel if necessary
                        _drawingBitmap = new Bitmap(loadedImage, panel1.Width, panel1.Height);

                        // Refresh the panel to display the loaded image
                        RefreshShapes();

                        MessageBox.Show("Image loaded successfully.", "Open Image", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Failed to load image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
