using System;
using System.Linq;

namespace Point3DCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D[] points = new Point3D[]
            {
                new Point3D { X = 0, Y = 0, Z = 0 },
                new Point3D { X = 1, Y = 1, Z = 1 },
                new Point3D { X = 2, Y = 2, Z = 2 },
                new Point3D { X = 3, Y = 3, Z = 3 }
            };

            double maxDistance = double.MinValue;
            Point3D firstPoint = null;
            Point3D secondPoint = null;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = points[i].DistanceTo(points[j]);
                    if (distance > maxDistance)
                    {
                        maxDistance = distance;
                        firstPoint = points[i];
                        secondPoint = points[j];
                    }
                }
            }

            Console.WriteLine($"Maximum distance: {maxDistance}");
            Console.WriteLine($"Points: ({firstPoint.X}, {firstPoint.Y}, {firstPoint.Z}) and ({secondPoint.X}, {secondPoint.Y}, {secondPoint.Z})");
        }
    }

    public class Point3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public double DistanceTo(Point3D other)
        {
            double dx = X - other.X;
            double dy = Y - other.Y;
            double dz = Z - other.Z;
            return Math.Sqrt(dx * dx + dy * dy + dz * dz);
        }
    }
}