using System.Drawing;

namespace GraphicsEditorApp_OOP_course_project.ShapeClasses
{
    public class BitmapShape : Shape
    {
        public Bitmap Bitmap { get; private set; }

        // Fix for CS1729, CS1031, and CS1001: Add required parameters to the constructor
        public BitmapShape(Bitmap bitmap, int x, int y, Color shapeColor, bool isFilled)
            : base(x, y, isFilled, shapeColor) // Call the base class constructor
        {
            Bitmap = new Bitmap(bitmap);
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(Bitmap, Point.Empty);
        }

        public override double CalculateArea()
        {
            return 0; // Not applicable for a bitmap
        }

        public override bool Contains(Point point)
        {
            return false; // Not applicable for a bitmap
        }

        public override void EditDimensions(params int[] dimensions)
        {
            // Not applicable for a bitmap
        }

        public override Shape Clone()
        {
            return new BitmapShape(new Bitmap(Bitmap), X, Y, ShapeColor, IsFilled);
        }
    }
}
