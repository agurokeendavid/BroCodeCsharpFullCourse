using System;

namespace StringMethods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string fullName = "Bro Code";
            string phoneNumber = "123-456-7890";

            // fullName = fullName.ToUpper();
            // fullName = fullName.ToLower();
            // phoneNumber = phoneNumber.Replace("-", "");
            // Console.WriteLine(phoneNumber);
            // Console.WriteLine(fullName);

            // String userName = fullName.Insert(0, "Mr. ");
            // Console.WriteLine(userName);

            // Console.WriteLine(fullName.Length);

            String firstName = fullName.Substring(0, 3);
            String lastName = fullName.Substring(4, 4);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
        }
    }
}