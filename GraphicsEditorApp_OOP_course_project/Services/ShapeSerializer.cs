using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GraphicsEditorApp_OOP_course_project.ShapeClasses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GraphicsEditorApp_OOP_course_project.Services
{
    public static class ShapeSerializer
    {
        public static void SaveToFile(string filePath, List<Shape> shapes)
        {
            try
            {
                // Serialize shapes to JSON including all relevant properties
                var shapeData = shapes.Select(shape => new
                {
                    Type = shape.GetType().FullName,
                    X = shape.GetX(),
                    Y = shape.GetY(),
                    Color = shape.GetColor().Name,
                    IsFilled = shape.GetIsFilled(),
                    Dimensions = GetShapeDimensions(shape),
                    Area = shape.CalculateArea()
                }).ToList();

                var json = JsonConvert.SerializeObject(shapeData, Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error saving shapes to file.", ex);
            }
        }

        private static object GetShapeDimensions(Shape shape)
        {
            return shape switch
            {
                Circle circle => new { Radius = circle.Radius },
                ShapeClasses.Rectangle rectangle => new { Width = rectangle.Width, Height = rectangle.Height },
                Triangle triangle => new { Base = triangle.Base, Height = triangle.Height },
                Square square => new { Side = square.Side },
                Parallelogram parallelogram => new { Width = parallelogram.Width, Height = parallelogram.Height },
                Rhombus rhombus => new { Side = rhombus.Side, Angle = rhombus.Angle },
                Trapezoid trapezoid => new { Base1 = trapezoid.Base1, Base2 = trapezoid.Base2, Height = trapezoid.Height },
                _ => null
            };
        }
    }
}
