using System;

namespace _11Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write($"Enter int number : ");
            int num = int.Parse(Console.ReadLine());
            Console.Write($"Enter 1 to convert in hex or enter 2 to convert in binary :");
            int choose = int.Parse(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    string hexString = Convert.ToString(Convert.ToInt32(num), 16);
                    Console.WriteLine(hexString);
                    break;
                case 2:
                    string binString = Convert.ToString(Convert.ToInt32(num), 2);
                    Console.WriteLine(binString);
                    break;

            }
            //int s, d;

            //Console.Write("Enter N: ");
            //string n = Console.ReadLine();

            //do
            //{
            //    Console.Write("Enter S (S == 2, 8, 10 or 16): ");
            //    s = Int32.Parse(Console.ReadLine());
            //} while (s != 2 && s != 8 && s != 10 && s != 16);

            //do
            //{
            //    Console.Write("Enter D (D == 2, 8, 10 or 16): ");
            //    d = Int32.Parse(Console.ReadLine());
            //} while (d != 2 && d != 8 && d != 10 && d != 16);

            //n = Convert.ToString(Convert.ToInt32(n, s), d);

            //Console.WriteLine("Result is {0}.", n);






        }
    }
}
