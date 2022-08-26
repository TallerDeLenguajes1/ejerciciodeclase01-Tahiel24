﻿using System;

namespace Problema02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            byte result;

            num1 = 30;
            num2 = 60;

            try
            {
                result = Convert.ToByte(num1 * num2);
                Console.WriteLine("{0} x {1} = {2}", num1, num2, result);
                Console.ReadLine();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Value was either too large or too small for an unsigned byte.");
            }

        }
    }
}
