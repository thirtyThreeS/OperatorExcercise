﻿// See https://aka.ms/new-console-template for more information

namespace Operator_Excercise
{

    class Program
    {

        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"17/4 is remainder {remainder}"); ;
            }
        }

    }
}
