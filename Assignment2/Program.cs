using System;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int number;
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number % 3 == 0 && number % 4 == 0)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");

            #endregion
        }
    }
}
