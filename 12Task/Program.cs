using System;

namespace _12Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 0;
            float f = 0.000001f;
            float f1 = 0.000001f;
            for (int i = 0; i < 50000000; i++)
            {
                f += f1;

                Console.WriteLine(f);
            }
        }
    }
}
