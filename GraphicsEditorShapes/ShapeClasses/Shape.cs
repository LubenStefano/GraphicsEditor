using System.Drawing;

namespace GraphicsEditorShapes.ShapeClasses
{
    public abstract class Shape
    {
        protected int X { get; private set; }
        protected int Y { get; private set; }
        protected Color ShapeColor { get; private set; } = Color.Black;
        protected bool IsFilled { get; private set; }


        public Shape(int x, int y, bool isFilled, Color color)
        {
            X = x;
            Y = y;
            IsFilled = isFilled;
            ShapeColor = color;
        }

        public abstract void Draw(Graphics g);
        public abstract double CalculateArea();
        public virtual void EditPosition(int x, int y) => (X, Y) = (x, y);
        public virtual void EditColor(Color color) => ShapeColor = color;
        public virtual void EditFill(bool isFilled) => IsFilled = isFilled;
        public virtual void Move(int deltaX, int deltaY) => (X, Y) = (X + deltaX, Y + deltaY);
        public abstract bool Contains(Point point);
        public abstract void EditDimensions(params int[] dimensions);
        public abstract Shape Clone();

        public void editPosition(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void editColor(Color color)
        {
            ShapeColor = color;
        }

        public void editFill(bool isFilled)
        {
            IsFilled = isFilled;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

        public Color GetColor()
        {
            return ShapeColor;
        }

        public bool GetIsFilled()
        {
            return IsFilled;
        }
        
    }
}
