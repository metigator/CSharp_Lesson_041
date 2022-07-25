using System;

namespace C11.StructRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(2, 3);
            // p1.X = 10; // position readonly struct record are immutable
            Console.WriteLine(p1);

            Console.ReadKey();
        }
    } 

    public readonly record struct Point (int X, int Y);

    public record struct PointV2
    {
        public int X;
        public int Y;

    }
}
