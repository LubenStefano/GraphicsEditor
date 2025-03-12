using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphicsEditorApp_OOP_course_project.ShapeClasses
{
    public class Square : Shape
    {
        public int Side { get; private set; }
        public Square(int x, int y, int side, bool isFilled) : base(x, y, isFilled)
        {
            Side = side;
        }
        public override void Draw(Graphics g)
        {
            if (IsFilled)
            {
                SolidBrush brush = new SolidBrush(ShapeColor);
                g.FillRectangle(brush, X, Y, Side, Side);
            }
            else
            {
                Pen pen = new Pen(ShapeColor);
                g.DrawRectangle(pen, X, Y, Side, Side);
            }
        }
        public override double CalculateArea()
        {
            return Side * Side;
        }
    }
}
