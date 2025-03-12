using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicsEditorApp_OOP_course_project.ShapeClasses
{
    public class Circle : Shape
    {
        public int Radius { get; private set; }
        public Circle(int x, int y, int radius, bool isFilled) : base(x, y, isFilled)
        {
            Radius = radius;
        }
        public override void Draw(Graphics g)
        {
            if (IsFilled)
            {
                SolidBrush brush = new SolidBrush(ShapeColor);
                g.FillEllipse(brush, X, Y, Radius, Radius);
            }
            else
            {
                Pen pen = new Pen(ShapeColor);
                g.DrawEllipse(pen, X, Y, Radius, Radius);
            }
        }
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override void Move(int deltaX, int deltaY)
        {
            base.Move(deltaX, deltaY);
        }
    }
}
