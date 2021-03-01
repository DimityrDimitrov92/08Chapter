using System;

namespace _08Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write hex number : ");
            string hexstring = Console.ReadLine(); 
            string binary= Convert.ToString(Convert.ToInt32(hexstring, 16), 2);
            Console.WriteLine(binary);



        }
    }
}
