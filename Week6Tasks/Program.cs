using System;
using System.Globalization;

namespace Week6Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            Random rnd = new Random();
          

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(0, 11);
            }

            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
            int min = numbers[0];
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if(min > numbers[i])
                {
                    min = numbers[i];
                }
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
                
            }
            Console.WriteLine($"max:{max}");
                Console.WriteLine($"min:{min}");
        }
    }
}
