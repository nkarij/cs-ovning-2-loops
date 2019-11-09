using System;

namespace ov2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            int number = 40;

            for (int i = 40; i > 30; i--)
            {
                int result = number-=1;
                Console.WriteLine(result);
            }
        }
    }
}
