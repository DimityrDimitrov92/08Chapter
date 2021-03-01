using System;

namespace _11Task
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write($"Enter int number : ");
            int num = int.Parse(Console.ReadLine());
            Console.Write($"Enter 1 to convert in hex or enter 2 to convert in binary :" );
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






        }
    }
}
