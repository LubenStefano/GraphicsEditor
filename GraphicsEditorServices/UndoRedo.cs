using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using GraphicsEditorShapes.ShapeClasses;

namespace GraphicsEditorServices
{
    public class UndoRedo
    {
        private readonly Stack<CanvasState> _undoStack = new Stack<CanvasState>();
        private readonly Stack<CanvasState> _redoStack = new Stack<CanvasState>();

        public void SaveState(Bitmap bitmap, List<Shape> shapes)
        {
            _undoStack.Push(new CanvasState
            {
                Bitmap = new Bitmap(bitmap),
                Shapes = shapes.Select(s => s.Clone()).ToList()
            });
            _redoStack.Clear();
        }

        public CanvasState Undo(Bitmap currentBitmap, List<Shape> currentShapes)
        {
            if (!CanUndo) return null;

            _redoStack.Push(new CanvasState
            {
                Bitmap = new Bitmap(currentBitmap),
                Shapes = currentShapes.Select(s => s.Clone()).ToList()
            });

            return _undoStack.Pop();
        }

        public CanvasState Redo(Bitmap currentBitmap, List<Shape> currentShapes)
        {
            if (!CanRedo) return null;

            _undoStack.Push(new CanvasState
            {
                Bitmap = new Bitmap(currentBitmap),
                Shapes = currentShapes.Select(s => s.Clone()).ToList()
            });

            return _redoStack.Pop();
        }

        public bool CanUndo => _undoStack.Count > 0;
        public bool CanRedo => _redoStack.Count > 0;
    }

    public class CanvasState
    {
        public Bitmap Bitmap { get; set; }
        public List<Shape> Shapes { get; set; }
    }
}
