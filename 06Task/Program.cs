using System;

namespace _06Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter int number : ");
            int a = int.Parse(Console.ReadLine());
            string b = Convert.ToString(a,16);
            Console.WriteLine(b);
        }
    }
}
