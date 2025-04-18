using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using GraphicsEditorApp_OOP_course_project.ShapeClasses;

namespace GraphicsEditorApp_OOP_course_project.Services
{
    internal class ShapeStatisticsService
    {
        public static string GetMostUsedShape(List<Shape> shapes)
        {
            return shapes.GroupBy(s => s.GetType().Name)
                         .OrderByDescending(g => g.Count())
                         .FirstOrDefault()?.Key ?? "None";
        }

        public static string GetMostUsedColor(List<Shape> shapes)
        {
            return shapes.GroupBy(s => s.GetColor().Name)
                         .OrderByDescending(g => g.Count())
                         .FirstOrDefault()?.Key ?? "None";
        }

        public static Dictionary<string, int> GetShapeUsageStatistics(List<Shape> shapes)
        {
            return shapes.GroupBy(s => s.GetType().Name)
                         .ToDictionary(g => g.Key, g => g.Count());
        }

        public static double GetAverageShapeArea(List<Shape> shapes)
        {
            return shapes.Average(s => s.CalculateArea());
        }

        public static Dictionary<string, double> GetAverageAreaByShapeType(List<Shape> shapes)
        {
            return shapes.GroupBy(s => s.GetType().Name)
                         .ToDictionary(g => g.Key, g => g.Average(s => s.CalculateArea()));
        }

        public static List<dynamic> GetShapeStatistics(List<Shape> shapes, string orderBy = "usage")
        {
            var statistics = shapes.GroupBy(s => s.GetType().Name)
                                   .Select(g => new
                                   {
                                       Type = g.Key,
                                       Usage = g.Count(),
                                       AverageArea = g.Average(s => s.CalculateArea()),
                                       MostUsedColor = g.GroupBy(s => s.GetColor().Name)
                                                        .OrderByDescending(cg => cg.Count())
                                                        .FirstOrDefault()?.Key ?? "None"
                                   });

            return orderBy.ToLower() switch
            {
                "usage" => statistics.OrderByDescending(s => s.Usage).ToList<dynamic>(),
                "color" => statistics.OrderBy(s => s.MostUsedColor).ToList<dynamic>(),
                "averagearea" => statistics.OrderByDescending(s => s.AverageArea).ToList<dynamic>(),
                _ => statistics.ToList<dynamic>()
            };
        }
    }
}
