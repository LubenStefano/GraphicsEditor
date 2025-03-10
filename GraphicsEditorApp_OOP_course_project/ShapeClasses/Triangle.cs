using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditorApp_OOP_course_project.ShapeClasses
{
    public class Triangle : Shape
    {
        public int Base { get; private set; }
        public int Height { get; private set; }
        public Triangle(int x, int y, int @base, int height, bool isFilled) : base(x, y, isFilled)
        {
            Base = @base;
            Height = height;
        }
        public override void Draw(Graphics g)
        {
            Point[] points = new Point[3];
            points[0] = new Point(X, Y);
            points[1] = new Point(X + Base, Y);
            points[2] = new Point(X + Base / 2, Y + Height);

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
            return Base * Height / 2;
        }

        public override void EditSize(int @base, int height)
        {
            Base = @base;
            Height = height;
        }

        public override void Move(int deltaX, int deltaY)
        {
            base.Move(deltaX, deltaY);
        }
    }
}
