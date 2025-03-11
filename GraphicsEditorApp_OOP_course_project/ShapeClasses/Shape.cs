using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsEditorApp_OOP_course_project.ShapeClasses
{
    public abstract class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public Color ShapeColor { get; set; } = Color.Black;
        public bool IsFilled { get; set; }

        public Shape(int x, int y, bool isFilled)
        {
            X = x;
            Y = y;
            IsFilled = isFilled;
        }

        public abstract void Draw(Graphics g);
        public abstract double CalculateArea();

        public virtual void EditPosition(int x, int y)
        {
            X = x;
            Y = y;
        }

        public virtual void EditColor(Color color)
        {
            ShapeColor = color;
        }

        public virtual void EditFill(bool isFilled)
        {
            IsFilled = isFilled;
        }

        //TODO: should be edited: abstract and convinient for all shapes(width and height)
        public virtual void EditSize(int width, int height){}

        public virtual void Move(int deltaX, int deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }
    }
}
