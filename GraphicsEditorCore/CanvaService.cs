using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using GraphicsEditorShapes.ShapeClasses;
using GraphicsEditorServices;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GraphicsEditorCore
{
    public class CanvasService
    {
        private Bitmap _drawingBitmap;
        private List<Shape> _shapes;
        private Point _lastPoint;
        private bool _isDrawing;
        private Shape _selectedShape;
        private Point _dragStartPoint;
        private Bitmap _renderBitmap; // Separate bitmap for rendering
        private bool _needsFullRedraw = true;

        private readonly ToolModeManager _toolManager;
        private readonly UndoRedo _undoRedoService;
        private readonly ShapeSerializer _fileService;

        private readonly Form _parentControl; // Added to store the parent control reference

        public CanvasService(int width, int height, ToolModeManager toolManager,
                           UndoRedo undoRedoService, ShapeSerializer fileService,Form parentControl)
        {
            _drawingBitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(_drawingBitmap))
            {
                g.Clear(Color.White);
            }

            _shapes = new List<Shape>();
            _toolManager = toolManager;
            _undoRedoService = undoRedoService;
            _fileService = fileService;
            _parentControl = parentControl; // Store the parent control reference
            _renderBitmap = new Bitmap(width, height);
        }

        public Bitmap DrawingBitmap => _drawingBitmap;
        public List<Shape> Shapes => _shapes;
        public Shape SelectedShape => _selectedShape;

        public void HandleMouseDown(Point location, MouseButtons button)
        {
            if (button != MouseButtons.Left) return;

            SaveState(); // Save state before any changes

            switch (_toolManager.CurrentMode)
            {
                case ToolModeManager.ToolMode.Pen:
                case ToolModeManager.ToolMode.Brush:
                case ToolModeManager.ToolMode.Eraser:
                    _isDrawing = true;
                    _lastPoint = location;
                    break;

                case ToolModeManager.ToolMode.Select:
                    _selectedShape = _shapes.LastOrDefault(s => s.Contains(location));
                    if (_selectedShape != null)
                    {
                        _dragStartPoint = location;
                    }
                    break;

                case ToolModeManager.ToolMode.Fill:
                    ApplyFill(location);
                    break;
            }
        }

        public void HandleMouseMove(Point location, MouseButtons button)
        {
            if (button != MouseButtons.Left) return;

            bool requiresRedraw = false;

            switch (_toolManager.CurrentMode)
            {
                case ToolModeManager.ToolMode.Pen when _isDrawing:
                    using (Graphics g = Graphics.FromImage(_drawingBitmap))
                    {
                        g.SmoothingMode = SmoothingMode.HighQuality;
                        g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        g.DrawLine(new Pen(_toolManager.CurrentColor, _toolManager.PenWidth),
                                   _lastPoint, location);
                    }
                    _lastPoint = location;
                    requiresRedraw = true;
                    break;

                case ToolModeManager.ToolMode.Brush when _isDrawing:
                    DrawSmoothBrushStroke(_lastPoint, location);
                    _lastPoint = location;
                    requiresRedraw = true;
                    break;

                case ToolModeManager.ToolMode.Eraser when _isDrawing:
                    DrawSmoothEraserStroke(_lastPoint, location);
                    _lastPoint = location;
                    requiresRedraw = true;
                    break;

                case ToolModeManager.ToolMode.Select when _selectedShape != null:
                    int deltaX = location.X - _dragStartPoint.X;
                    int deltaY = location.Y - _dragStartPoint.Y;
                    _selectedShape.Move(deltaX, deltaY);
                    _dragStartPoint = location;
                    requiresRedraw = true;
                    break;

                case ToolModeManager.ToolMode.Fill:
                    ApplyFill(location);
                    requiresRedraw = true;
                    break;
            }

            if (requiresRedraw)
            {
                _needsFullRedraw = true;
                _parentControl.Invalidate();
            }
        }

        public void HandleMouseUp()
        {
            _isDrawing = false;
            _selectedShape = null;
        }

        public void Render(Graphics g)
        {
            if (_needsFullRedraw)
            {
                using (var renderGraphics = Graphics.FromImage(_renderBitmap))
                {
                    renderGraphics.Clear(Color.White);
                    renderGraphics.DrawImage(_drawingBitmap, Point.Empty);

                    foreach (var shape in _shapes)
                    {
                        shape.Draw(renderGraphics);
                    }
                }
                _needsFullRedraw = false;
            }

            g.DrawImage(_renderBitmap, Point.Empty);
        }

        public void AddShape(Shape shape)
        {
            _shapes.Add(shape);
            SaveState(); // Save state after adding a shape
        }

        public void RemoveShape(Shape shape)
        {
            _shapes.Remove(shape);
            SaveState(); // Save state after removing a shape
        }

        public void ClearCanvas()
        {
            _shapes.Clear();
            using (Graphics g = Graphics.FromImage(_drawingBitmap))
            {
                g.Clear(Color.White);
            }
            SaveState(); // Save state after clearing the canvas
        }

        public void Undo()
        {
            var state = _undoRedoService.Undo(_drawingBitmap, _shapes);
            if (state != null)
            {
                _drawingBitmap = state.Bitmap;
                _shapes = state.Shapes;
                _needsFullRedraw = true; // Mark for redraw
            }
        }

        public void Redo()
        {
            var state = _undoRedoService.Redo(_drawingBitmap, _shapes);
            if (state != null)
            {
                _drawingBitmap = state.Bitmap;
                _shapes = state.Shapes;
                _needsFullRedraw = true; // Mark for redraw
            }
        }

        public void SaveShapesToJson(string path)
        {
            _fileService.SaveToFile(path, _shapes);
        }

        public void LoadShapesFromJson(string path)
        {
            _shapes = _fileService.LoadFromFile(path);
            SaveState(); // Save state after loading shapes
        }

        public void SaveToImage(string path)
        {
            using (var combinedImage = new Bitmap(_drawingBitmap.Width, _drawingBitmap.Height))
            using (var g = Graphics.FromImage(combinedImage))
            {
                g.DrawImage(_drawingBitmap, Point.Empty);
                foreach (var shape in _shapes)
                {
                    shape.Draw(g);
                }
                _fileService.SavePanelToImage(path, combinedImage);
            }
        }

        public void LoadImage(string path)
        {
            _drawingBitmap = _fileService.LoadPanelFromImage(path);
            SaveState();
        }

        private void ApplyFill(Point location)
        {
            if (_selectedShape != null && _selectedShape.Contains(location))
            {
                _selectedShape.EditFill(true);
                _selectedShape.EditColor(_toolManager.CurrentColor);
            }
            else
            {
                Color targetColor = _drawingBitmap.GetPixel(location.X, location.Y);
                if (targetColor.ToArgb() != _toolManager.CurrentColor.ToArgb())
                {
                    FloodFill(_drawingBitmap, location, targetColor, _toolManager.CurrentColor);
                }
            }

            _needsFullRedraw = true; // Mark for redraw
            InvalidateCanvas(); // Invalidate the canvas to trigger a redraw
            _parentControl.Invalidate(); // Immediately invalidate the canvas to apply changes
        }

        private void FloodFill(Bitmap bitmap, Point pt, Color targetColor, Color replacementColor)
        {
            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(pt);

            while (pixels.Count > 0)
            {
                Point current = pixels.Pop();
                if (current.X < 0 || current.Y < 0 ||
                    current.X >= bitmap.Width || current.Y >= bitmap.Height)
                    continue;

                if (bitmap.GetPixel(current.X, current.Y).ToArgb() != targetColor.ToArgb())
                    continue;

                bitmap.SetPixel(current.X, current.Y, replacementColor);

                pixels.Push(new Point(current.X + 1, current.Y));
                pixels.Push(new Point(current.X - 1, current.Y));
                pixels.Push(new Point(current.X, current.Y + 1));
                pixels.Push(new Point(current.X, current.Y - 1));
            }
        }

        private void SaveState()
        {
            // Save the current state of the canvas to the UndoRedo service
            _undoRedoService.SaveState(_drawingBitmap, _shapes);
        }

        public void InvalidateCanvas()
        {
            _needsFullRedraw = true;
            _parentControl.Invalidate();
        }

        private void DrawSmoothBrushStroke(Point start, Point end)
        {
            using (Graphics g = Graphics.FromImage(_drawingBitmap))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // Interpolate points between start and end to create a smooth stroke
                int dx = end.X - start.X;
                int dy = end.Y - start.Y;
                int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

                for (int i = 0; i <= steps; i++)
                {
                    float t = (float)i / steps;
                    int x = (int)(start.X + t * dx);
                    int y = (int)(start.Y + t * dy);

                    g.FillEllipse(new SolidBrush(_toolManager.CurrentColor),
                                  x - _toolManager.BrushSize / 2,
                                  y - _toolManager.BrushSize / 2,
                                  _toolManager.BrushSize,
                                  _toolManager.BrushSize);
                }
            }
        }

        private void DrawSmoothEraserStroke(Point start, Point end)
        {
            using (Graphics g = Graphics.FromImage(_drawingBitmap))
            {
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;

                // Interpolate points between start and end to create a smooth erasing effect
                int dx = end.X - start.X;
                int dy = end.Y - start.Y;
                int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

                for (int i = 0; i <= steps; i++)
                {
                    float t = (float)i / steps;
                    int x = (int)(start.X + t * dx);
                    int y = (int)(start.Y + t * dy);

                    g.FillEllipse(new SolidBrush(Color.White),
                                  x - _toolManager.EraserSize / 2,
                                  y - _toolManager.EraserSize / 2,
                                  _toolManager.EraserSize,
                                  _toolManager.EraserSize);
                }
            }
        }

        public Shape GetShapeAt(Point location)
        {
            return _shapes.LastOrDefault(s => s.Contains(location));
        }
    }
}