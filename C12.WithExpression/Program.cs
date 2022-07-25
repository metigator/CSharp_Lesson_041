using System;

namespace C12.WithExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2, 3);

            var p2 = new Point(4, p1.Y);

            var p3 = p1 with { X = 4 };

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.ReadKey();
        }
    } 

    record Point (int X, int Y);
}
