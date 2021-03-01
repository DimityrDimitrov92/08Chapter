using System;

namespace _05Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter binary number : ");
            string binary = Console.ReadLine();
            string a = Convert.ToInt64(binary, 2).ToString();
            int b = int.Parse(a);
            Console.WriteLine(b);
        }
    }
}
