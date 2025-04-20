using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GraphicsEditorShapes.ShapeClasses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GraphicsEditorServices
{
    public class ShapeSerializer
    {
        public void SaveToFile(string filePath, List<Shape> shapes)
        {
            try
            {
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
            if (shape is Circle circle)
            {
                return new { circle.Radius };
            }
            else if (shape is GraphicsEditorShapes.ShapeClasses.Rectangle rectangle)
            {
                return new { rectangle.Width, rectangle.Height };
            }
            else if (shape is Triangle triangle)
            {
                return new { triangle.Base, triangle.Height };
            }
            else if (shape is Square square)
            {
                return new { square.Side };
            }
            else if (shape is Parallelogram parallelogram)
            {
                return new { parallelogram.Width, parallelogram.Height, parallelogram.Angle };
            }
            else if (shape is Rhombus rhombus)
            {
                return new {  rhombus.Side, rhombus.Angle };
            }
            else if (shape is Trapezoid trapezoid)
            {
                return new { trapezoid.Base1, trapezoid.Base2, trapezoid.Height };
            }
            else
            {
                return null;
            }
        }

        public List<Shape> LoadFromFile(string filePath)
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
                        var type = item["Type"]?.ToString();
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
                                shapes.Add(new GraphicsEditorShapes.ShapeClasses.Rectangle(x, y, Convert.ToInt32(dimensions["Width"] ?? throw new InvalidOperationException("Missing Width.")),
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

        public void SavePanelToImage(string path, Bitmap bitmap)
        {
            try
            {
                string extension = Path.GetExtension(path).ToLower();
                System.Drawing.Imaging.ImageFormat format;
                switch (extension)
                {
                    case ".jpg":
                    case ".jpeg":
                        format = System.Drawing.Imaging.ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = System.Drawing.Imaging.ImageFormat.Bmp;
                        break;
                    default:
                        format = System.Drawing.Imaging.ImageFormat.Png;
                        break;
                }
                bitmap.Save(path, format);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to save image: {ex.Message}");
            }
        }

        public Bitmap LoadPanelFromImage(string path)
        {
            try
            {
                return new Bitmap(path);
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to load image: {ex.Message}");
            }
        }
    }
}
