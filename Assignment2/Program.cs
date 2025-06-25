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
            #region Q7
            int number;
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 12; i++)
            { 
                Console.Write(number*i +" ");
            }
            #endregion 
            #region Q8
            int number;
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            #endregion
            #region Q9
            int num1;
            int num2;
            int result=1;
            Console.WriteLine("Enter 3 numbers: ");
            string[] input = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            num1 = int.Parse(input[0]);
            num2 = int.Parse(input[1]);
            for (int i = 1; i <= num2; i++)
            {
                result *= num1;
                    }
            Console.WriteLine(result);
            #endregion
            
            #region Q10
            Console.WriteLine("Enter marks:");
            String[] input = Console.ReadLine().Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            int[] marks = Array.ConvertAll(input,int.Parse);
            int total = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                total += marks[i];  
            }
            double avg = total / marks.Length;
            double percent = (total *100)/500 ;
            Console.WriteLine($"Total marks = {total}");
            Console.WriteLine($"Average Marks = {avg}");
            Console.WriteLine($"Percentage = {percent}");

        }
        #endregion
            #region Q11
            Console.WriteLine("Month Number: ");
            int month = int.Parse(Console.ReadLine());
            int Days=1;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Days = 31;
                    break;
                case 2:
                    Days = 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Days = 30;
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    break;
            }
            Console.WriteLine($"Days in Month: {Days}");
            #endregion
            #region Q12
            Console.WriteLine("Enter Number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (i == j)
                        Console.Write("1");
                    else
                        Console.Write("0");
                }
                Console.WriteLine(); 
            
            }
            #endregion
            #region Q13
            Console.WriteLine("Enter number of elemrnts");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int[] numbers = new int[n];
            Console.WriteLine("Enter elemnts");
            for (int i = 0; i < numbers.Length; i++)
            { 
            numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }
            Console.WriteLine($"Sum of elements = {sum}");
            #endregion
            #region Q14
            int[] arr = new int[100];
            int[] freq = new int[100];
            int count;
            Console.WriteLine("Enter number of elemrnts");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter elemnts");
            for (int i = 0; i < n; i++)
            { 
            arr[i] = int.Parse(Console.ReadLine());
                freq[i] = -1;
            }
            for (int i = 0; i < n; i++)
            {
                count = 1;
                for (int j = i+1; j < n; j++) {
                    if (arr[i] == arr[j] && freq[j] != 0)
                    { 
                    count++;
                        freq[j] = 0;
                    }
                }
                if (freq[i]!= 0)
                    freq[i] = count;
            }
            for (int i = 0; i < n; i++)
            {
                if (freq[i] != 0)
                    Console.WriteLine($"{arr[i]} occurs {freq[i]} time ");
            };
            #endregion
            #region Q15
            Console.WriteLine("Enter number of elemrnts");
            int n = int.Parse(Console.ReadLine());
            int [] arr = new int[n];
            Console.WriteLine("Enter elements");
            for (int i = 0; i < arr.Length; i++) { 
            arr[i] = int.Parse(Console.ReadLine());
            }
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max)
                    max = arr[i];

                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine($"Max element is {max}");
            Console.WriteLine($"min element is {min}");
            #endregion
        }
    }
}