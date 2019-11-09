using System;

namespace ov3
{
    class Program
    {
        static void Main(string[] args)
        {

            // string var indeholder "what now".
            // int counter, counting number of times to print, starts at 1.
            // print string.
            // read input
            // if-else.
            // if user input is not Q:
            // add counter with counter.
            // loop counter and output string foreach loop.
            // else if user input is Q:
            // return/break
            int counter = 1;

            while (counter > 0)
            {
                string text = "What now?";
                var input = "";
                int length = counter;

                for (int i = 0; i < length; i++)
                {
                    System.Console.WriteLine(text);
                }

                input = Console.ReadLine();

                if(input != "q"){
                    counter+=counter;
                } else {
                    Console.WriteLine("Goodbye");
                    return;
                }
            }

        }
    }
}
