using System;

namespace Problema04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            try
            {
                Console.WriteLine("{0} - {1} - {2}", a, b);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException: Index (zero based) must be greater than or equal to zero and less than the size of the argument list.");
            }
            ;
        }
    }
}
