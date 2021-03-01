using System;

namespace _04Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter int number : ");
            int a = int.Parse(Console.ReadLine());
            string name = Convert.ToString(a, 2); 
            Console.WriteLine(name);

        }
    }
}
