using System;

namespace ArithmeticOperatorsLesson
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double friends = 10;
            // friends = friends + 1;
            // friends += + 2;
            // friends++;

            // friends = friends - 1;
            // friends -= 1;
            // friends--;

            // friends = friends * 2;
            // friends *= 2;

            // friends = friends / 2;
            // friends /= 2;

            double remainder = friends % 2;

            Console.WriteLine(remainder);
        }
    }
}