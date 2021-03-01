using System;

namespace _01Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 151, 35, 43, 251, 1023, 1024 };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i];
                string binary = Convert.ToString(numbers[i], 2);
                Console.WriteLine($"{numbers[i]} = {binary}");



            }
        }

    }
}
