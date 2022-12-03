using System;

namespace RandomNumberLesson
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            // int num = random.Next(1, 7); // random 1 to 6
            // int num = random.Next(1, 7) + 100; // random 101 to 106
            // double num = random.NextDouble(); // random 0 to 1

            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
        }
    }
}