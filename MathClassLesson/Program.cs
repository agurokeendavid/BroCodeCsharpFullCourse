using System;

namespace MathClassLesson
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double x = 3.99;
            double y = 5;

            // double a = Math.Pow(x, 3);
            // double b = Math.Sqrt(x);
            // double c = Math.Abs(x); // remove negative
            // double d = Math.Round(x); // round value
            // double e = Math.Ceiling(x); // rounded up
            // double f = Math.Floor(x); // rounded down
            // double g = Math.Max(x, y); // get the max value
            double h = Math.Min(x, y); // get the min value
            Console.WriteLine(h);
        }
    }
}