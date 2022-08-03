using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.IfElseLadder
{
    class CheckPosNegZero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine(num + " is a positive number");
            }
            else if(num<0)
            {
                Console.WriteLine(num + " is a negative number");
            }
            else
            {
                Console.WriteLine("Number is Zero");
            }
        }
    }
}
