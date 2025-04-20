using System;
using System.Collections.Generic;
using System.Linq;
using GraphicsEditorShapes.ShapeClasses;

namespace GraphicsEditorServices
{
    public class ShapeStatisticsService
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

        public static List<ShapeStatistic> GetShapeStatistics(List<Shape> shapes, string orderBy = "usage")
        {
            var statistics = shapes.GroupBy(s => s.GetType().Name)
                                   .Select(g => new ShapeStatistic
                                   {
                                       Type = g.Key,
                                       Usage = g.Count(),
                                       AverageArea = g.Average(s => s.CalculateArea()),
                                       MostUsedColor = g.GroupBy(s => s.GetColor().Name)
                                                        .OrderByDescending(cg => cg.Count())
                                                        .FirstOrDefault()?.Key ?? "None"
                                   });
            foreach (var stat in statistics)
            {
                Console.WriteLine($"Type: {stat.Type}, AverageArea: {stat.AverageArea}");
            }
            orderBy = orderBy.ToLower();
            if (orderBy == "usage")
            {
                return statistics.OrderByDescending(s => s.Usage).ToList();
            }
            else if (orderBy == "averagearea")
            {
                return statistics.OrderByDescending(s => s.AverageArea).ToList();
            }
            else
            {
                return statistics.ToList();
            }
        }
    }

    public class ShapeStatistic
    {
        public string Type { get; set; }
        public int Usage { get; set; }
        public double AverageArea { get; set; }
        public string MostUsedColor { get; set; }
    }
}
