using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsEditorShapes.ShapeClasses
{ 
    public class Rhombus : Shape
    {
        public int Side { get; private set; }
        public Rhombus(int x, int y, int side, bool isFilled, Color color) : base(x, y, isFilled, color)
        {
            Side = side;
        }
        
        public override void Draw(Graphics g)
        {
            Point[] points = new Point[4];
            points[0] = new Point(X, Y + Side / 2);
            points[1] = new Point(X + Side / 2, Y);
            points[2] = new Point(X + Side, Y + Side / 2);
            points[3] = new Point(X + Side / 2, Y + Side);

            if (IsFilled)
            {
                SolidBrush brush = new SolidBrush(ShapeColor);
                g.FillPolygon(brush, points);
            }
            else
            {
                Pen pen = new Pen(ShapeColor);
                g.DrawPolygon(pen, points);
            }
        }

        public override double CalculateArea()
        {
            double height = Side / 2.0;
            return Side * height;
        }

        public override void Move(int deltaX, int deltaY)
        {
            base.Move(deltaX, deltaY);
        }

        public override bool Contains(Point point)
        {
            Point[] points = new Point[4];
            points[0] = new Point(X, Y + Side / 2);
            points[1] = new Point(X + Side / 2, Y);
            points[2] = new Point(X + Side, Y + Side / 2);
            points[3] = new Point(X + Side / 2, Y + Side);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(points);
                return path.IsVisible(point);
            }
        }

        public override void EditDimensions(params int[] dimensions)
        {
            if (dimensions.Length != 1)
                throw new ArgumentException("Rhombus requires exactly 1 dimension: side!");
            Side = dimensions[0];
        }

        public override Shape Clone()
        {
            return new Rhombus(X, Y, Side, IsFilled, ShapeColor);
        }
    }
}
