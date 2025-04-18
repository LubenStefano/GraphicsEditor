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
                    Type = shape.GetType().FullName.Split('.').Last(),
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
                Parallelogram parallelogram => new { Width = parallelogram.Width, Height = parallelogram.Height, Angle = parallelogram.Angle },
                Rhombus rhombus => new { Side = rhombus.Side, Angle = rhombus.Angle },
                Trapezoid trapezoid => new { Base1 = trapezoid.Base1, Base2 = trapezoid.Base2, Height = trapezoid.Height },
                _ => null
            };
        }

        public static List<Shape> LoadFromFile(string filePath)
        {
            try
            {
                var json = File.ReadAllText(filePath);
                var shapeData = JArray.Parse(json);
                var shapes = new List<Shape>();

                foreach (var item in shapeData)
                {
                    try
                    {
                        string type = item["Type"]?.ToString();
                        int x = item["X"]?.Value<int>() ?? throw new InvalidOperationException("Missing X coordinate.");
                        int y = item["Y"]?.Value<int>() ?? throw new InvalidOperationException("Missing Y coordinate.");
                        Color color = Color.FromName(item["Color"]?.ToString() ?? "Black");
                        bool isFilled = item["IsFilled"]?.Value<bool>() ?? false;
                        var dimensions = item["Dimensions"]?.ToObject<Dictionary<string, object>>() ?? new Dictionary<string, object>();

                        switch (type)
                        {
                            case "Circle":
                                shapes.Add(new Circle(x, y, Convert.ToInt32(dimensions["Radius"] ?? throw new InvalidOperationException("Missing Radius.")), isFilled, color));
                                break;
                            case "Rectangle":
                                shapes.Add(new ShapeClasses.Rectangle(x, y, Convert.ToInt32(dimensions["Width"] ?? throw new InvalidOperationException("Missing Width.")),
                                                                      Convert.ToInt32(dimensions["Height"] ?? throw new InvalidOperationException("Missing Height.")), isFilled, color));
                                break;
                            case "Triangle":
                                shapes.Add(new Triangle(x, y, Convert.ToInt32(dimensions["Base"] ?? throw new InvalidOperationException("Missing Base.")),
                                                         Convert.ToInt32(dimensions["Height"] ?? throw new InvalidOperationException("Missing Height.")), isFilled, color));
                                break;
                            case "Square":
                                shapes.Add(new Square(x, y, Convert.ToInt32(dimensions["Side"] ?? throw new InvalidOperationException("Missing Side.")), isFilled, color));
                                break;
                            case "Parallelogram":
                                shapes.Add(new Parallelogram(x, y, Convert.ToInt32(dimensions["Width"] ?? throw new InvalidOperationException("Missing Width.")),
                                                             Convert.ToInt32(dimensions["Height"] ?? throw new InvalidOperationException("Missing Height.")),
                                                             Convert.ToDouble(dimensions["Angle"] ?? throw new InvalidOperationException("Missing Angle.")), isFilled, color));
                                break;
                            case "Rhombus":
                                shapes.Add(new Rhombus(x, y, Convert.ToInt32(dimensions["Side"] ?? throw new InvalidOperationException("Missing Side.")),
                                                       Convert.ToInt32(dimensions["Angle"] ?? throw new InvalidOperationException("Missing Angle.")), isFilled, color));
                                break;
                            case "Trapezoid":
                                shapes.Add(new Trapezoid(x, y, Convert.ToInt32(dimensions["Base1"] ?? throw new InvalidOperationException("Missing Base1.")),
                                                          Convert.ToInt32(dimensions["Base2"] ?? throw new InvalidOperationException("Missing Base2.")),
                                                          Convert.ToInt32(dimensions["Height"] ?? throw new InvalidOperationException("Missing Height.")), isFilled, color));
                                break;
                            default:
                                throw new InvalidOperationException($"Unknown shape type: {type}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading shape: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                return shapes;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Error loading shapes from file.", ex);
            }
        }
    }
}
