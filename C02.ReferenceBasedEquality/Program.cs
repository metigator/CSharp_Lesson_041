using System;

namespace C02.ReferenceBasedEquality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2, 3);
            var p2 = new Point(2, 3);

            Console.WriteLine($"p1: ({p1.X}, {p1.Y})"); // p1: (2, 3)
            Console.WriteLine($"p2: ({p2.X}, {p2.Y})");

            Console.WriteLine($"p1.Equals(p2) = {p1.Equals(p2)}");
            Console.WriteLine($"Object.ReferenceEquals(p1, p2) =" +
                $"{Object.ReferenceEquals(p1, p2)}");

            p1 = p2;

            Console.WriteLine($"p1.Equals(p2) = {p1.Equals(p2)}");
            Console.WriteLine($"Object.ReferenceEquals(p1, p2) =" +
                $"{Object.ReferenceEquals(p1, p2)}");


            Console.ReadKey();
        }
    }

    class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
