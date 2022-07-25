using System;
using System.Collections.Generic;

namespace C04.OverrideEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            var p1 = new Point(2, 3);
            var p2 = new Point(2, 3);

            Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");

            var points = new Dictionary<Point, string>();

            Console.WriteLine($"p1.GetHashCode(): {p1.GetHashCode()}");
            Console.WriteLine($"p2.GetHashCode(): {p2.GetHashCode()}");
            points.Add(p1, "2D Point X: 2, Y: 3");
            points.Add(p2, "2D Point X: 2, Y: 3");

            Console.ReadKey();
        }
    }

    class Point: IEquatable<Point>
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            Point p = obj as Point;

           return this.Equals(p); 
        }

        public bool Equals(Point point)
        {
            if (point is null)
                return false;

            return point.X == X && point.Y == Y;
        }

        public override int GetHashCode()
        {
            //int hash = 13;
            //hash = hash * 7 + X.GetHashCode();
            //hash = hash * 7 + Y.GetHashCode();
            //return hash;

            return HashCode.Combine(X, Y);
        }
    }
}
