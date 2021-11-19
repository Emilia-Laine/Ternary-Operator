using System;

namespace Ternary_Operator
{
    class TernaryOperator
    {
        static void Main(string[] args)
        {
            SetupConsole();
            TernaryTests();
        }

        private static void SetupConsole()
        {
            Console.Title = "Ternary Operator";
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void TernaryTests()
        {
            int a = 8, b = 3;

            string verb = (a != 1) ? "are" : "is";
            Console.WriteLine("There " + verb + " " + a);

            string parity = (a % 2 == 0) ? "even" : "odd";
            Console.WriteLine("A is " + parity);

            parity = (b % 2 != 0) ? "odd" : "even";
            Console.WriteLine("B is " + parity);

            int max = (a > b) ? a : b;
            Console.WriteLine(max + " is higher!");

            Console.ReadKey();
        }
    }
}
