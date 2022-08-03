using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Basic_Test1
{
    class Even_Odd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            string res = n % 2 == 0 ? "Even" : "Odd";
            Console.WriteLine(res);
        }
    }
}
