using System.Drawing;
using System.Windows.Forms;

namespace GraphicsEditorCore
{
    public class ToolModeManager
    {
        public enum ToolMode { Pen, Brush,Eraser, Select, Fill, None }

        public ToolMode CurrentMode { get; private set; } = ToolMode.None;
        public Color CurrentColor { get; private set; } = Color.Black;
        public int PenWidth { get; private set; } = 2;

        public int BrushSize { get; private set; } = 5;
        public int EraserSize { get; private set; } = 10;

        public void SetMode(ToolMode mode)
        {
            CurrentMode = mode;
        }

        public void SetColor(Color color)
        {
            CurrentColor = color;
        }


        public Cursor GetCurrentCursor()
        {
            switch (CurrentMode)
            {
                case ToolMode.Pen:
                case ToolMode.Brush:
                case ToolMode.Eraser:
                    return Cursors.Cross;
                case ToolMode.Fill:
                    return Cursors.Hand;
                default:
                    return Cursors.Default;
            }
        }

        public bool IsDrawingTool => CurrentMode == ToolMode.Pen || CurrentMode == ToolMode.Eraser || CurrentMode == ToolMode.Brush;
    }
}