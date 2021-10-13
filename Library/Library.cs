using PrintInformation;
using System;

namespace Library
{
    public class Library
    {
        public static void PrintFizzAndBuzz(PrintInformation<object> printInformation)
        {
            for (int i = 1; i <= printInformation.EndNumber; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(printInformation.WordFor3);
                }

                if (i % 5 == 0)
                {
                    Console.WriteLine(printInformation.WordFor5);
                }

                if (i % 3 == 0 || i % 5 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Finish");
        }
    }
}
