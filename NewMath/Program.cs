using System;

namespace NewMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number that you want to find min-max value: ");
            int number_one = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the second number that you want to find min-max value: ");
            int number_two = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Between this two numbers, min value is: " + FindTheMinValue(number_one, number_two));
            Console.WriteLine("Between this two numbers, max value is: " + FindTheMaxValue(number_one, number_two));
            Console.Write("Enter the number that you want to calculate its factoriel: ");
            int number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(number + "! is "+ Factoriel(number));
            Console.Write("How many elements do you want to create an array with? ");
            int element = Convert.ToInt16(Console.ReadLine());
            int[] numbers = new int[element];
            for (int i = 0; i < element; i++)
            {
                Console.Write("Enter the "+ (i+1) + ". elements for the array: ");
                numbers[i] = Convert.ToInt16(Console.ReadLine());
            }
            Sort(numbers);
            Console.Write("Sorted array: ");
            foreach (var items in numbers)
            {
                Console.Write(items + " ");
            }
            Console.Read();
        }
        private static int FindTheMinValue(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        private static int FindTheMaxValue(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        private static int Factoriel(int num)
        {
            int multiplication = 1;
            if (num<=1)
            {
                return 1;
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    multiplication *= i;
                }
                return multiplication;
                //second way
                //return (num*Factoriel(num-1));
            }
        }
        private static void Sort(int [] nums)
        {
            Array.Sort(nums);
        }
    }
}
