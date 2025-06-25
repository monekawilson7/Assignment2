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
            #region Q2
            int number;
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number >= 0)
                Console.WriteLine("positive");
            else
                Console.WriteLine("negative");
            #endregion
            #region Q3
            int num1;
            int num2;
            int num3;
            int max;
            int min;
            Console.WriteLine("Enter 3 numbers: ");
            string[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries); 
            num1 = int.Parse(input[0]);
            num2 = int.Parse(input[1]);
            num3 = int.Parse(input[2]);
            if (num1 >= num2 && num1 >= num3)
            {
                max = num1;
                if(num2>=num3)
                    min = num3;
                else 
                    min = num2; 
            }
            else if (num2>=num1 && num2>=num3)
            {
                max = num2;
                if (num1 >= num3)
                    min = num3;
                else
                    min = num1;
            }
            else
            {
                max = num3;
                if (num1 >= num2)
                    min = num2;
                else
                    min = num1;
            }
            Console.WriteLine($"max element = {max}");
            Console.WriteLine($"min element = {min}");
            #endregion
        }
    }
}
