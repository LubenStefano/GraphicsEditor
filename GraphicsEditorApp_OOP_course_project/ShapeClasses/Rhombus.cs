using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicsEditorApp_OOP_course_project.ShapeClasses
{
    public class Rhombus : Shape
    {
        public int Side { get; private set; }
        public int Angle { get; private set; }
        public Rhombus(int x, int y, int side, int angle, bool isFilled) : base(x, y, isFilled)
        {
            Side = side;
            Angle = angle;
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
            return Side * Side * Math.Sin(Angle * Math.PI / 180);
        }

        public override void EditSize(int side, int angle)
        {
            Side = side;
            Angle = angle;
        }

        public override void Move(int deltaX, int deltaY)
        {
            base.Move(deltaX, deltaY);
        }
    }
}
