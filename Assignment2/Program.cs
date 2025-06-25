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
            #region Q4
            int number;
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
            #endregion
            #region Q5
            char character;
            Console.WriteLine("Enter a character: ");
            character=Console.ReadKey().KeyChar;
            Console.WriteLine();
            switch (character)
            { 
             case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("Vowel");
                    break;
                    default:
                    Console.WriteLine("Consonant");
                    break ;
            }
            #endregion
            #region Q6
            int number;
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i < number)
                    Console.Write(i + ", ");
                else
                    Console.Write(i);
            }
            #endregion
        }
    }
}
