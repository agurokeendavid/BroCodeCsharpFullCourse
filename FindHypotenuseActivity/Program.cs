using System;

namespace FindHypotenuseActivity
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter side A:");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter side B:");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            Console.WriteLine($"The hypotenuse of {a} and {b} is {c}");
        }
    }
}