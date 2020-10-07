using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 11);
            }
            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
    }   }
}
