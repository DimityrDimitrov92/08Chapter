using System;

namespace _03Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0x2A3E , 0xFA , 0xFFFF, 0x5A0E9 };
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = numbers[i];
                string name = Convert.ToString(numbers[i], 10);
                string name1 = Convert.ToString(numbers[i], 2);
                Console.WriteLine($"{name} ===== {name1}");
            }
            
        }
    }
}
