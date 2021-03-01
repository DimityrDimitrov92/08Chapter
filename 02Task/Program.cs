using System;

namespace _02Task
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string binary = "1111010110011110";

            string i = (Convert.ToInt64(binary, 2).ToString());
            Console.WriteLine(i);

            int a = int.Parse(i);
            string b = Convert.ToString(a, 16);
            Console.WriteLine(b);

        }
    }
}
