using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace GraphicsEditorApp_OOP_course_project.ShapeClasses
{
    public class Trapezoid : Shape
    {
        public int Base1 { get; private set; }
        public int Base2 { get; private set; }
        public int Height { get; private set; }
        public Trapezoid(int x, int y, int base1, int base2, int height, bool isFilled, Color color) : base(x, y, isFilled, color)
        {
            Base1 = base1;
            Base2 = base2;
            Height = height;
        }

        public override void Draw(Graphics g)
        {
            Point[] points = new Point[4];
            points[0] = new Point(X, Y);
            points[1] = new Point(X + Base1, Y);
            points[2] = new Point(X + Base2, Y + Height);
            points[3] = new Point(X - Base2 + Base1, Y + Height);

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
            return (Base1 + Base2) * Height / 2;
        }

        public override void Move(int deltaX, int deltaY)
        {
            base.Move(deltaX, deltaY);
        }

        public override bool Contains(Point point)
        {
            Point[] points = new Point[4];
            points[0] = new Point(X, Y);
            points[1] = new Point(X + Base1, Y);
            points[2] = new Point(X + Base2, Y + Height);
            points[3] = new Point(X - Base2 + Base1, Y + Height);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddPolygon(points);
                return path.IsVisible(point);
            }
        }

        public override void EditDimensions(params int[] dimensions)
        {
            if (dimensions.Length != 3)
                throw new ArgumentException("Trapezoid requires exactly 3 dimensions: base1, base2, and height.");
            Base1 = dimensions[0];
            Base2 = dimensions[1];
            Height = dimensions[2];
        }

        public override Shape Clone()
        {
            return new Trapezoid(X, Y, Base1, Base2, Height, IsFilled, ShapeColor);
        }
    }
}
