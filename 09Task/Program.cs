using System;

namespace _09Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter binary number : ");
            string binary = Console.ReadLine();
            string hex = Convert.ToString(Convert.ToInt32(binary, 2), 16);
            Console.WriteLine(hex);
        }
    }
}
