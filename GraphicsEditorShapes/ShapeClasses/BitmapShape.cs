using System.Drawing;

namespace GraphicsEditorShapes.ShapeClasses
{
    public class BitmapShape : Shape
    {
        public Bitmap Bitmap { get; private set; }

        public BitmapShape(Bitmap bitmap, int x, int y, Color shapeColor, bool isFilled)
            : base(x, y, isFilled, shapeColor) 
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
