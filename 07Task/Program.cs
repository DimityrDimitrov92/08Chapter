using System;

namespace _07Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter hex number  : ");
            string name = Console.ReadLine();
            int a = Convert.ToInt32(name, 16);
            Console.WriteLine(a);



        }
    }
}
