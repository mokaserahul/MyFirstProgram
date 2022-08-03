using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Ternary_Operator
{
    class Check_Pos_Neg_Zero
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            string result = num > 0 ?"Positive Number" :num<0? "Negative Number":"Zero";
            Console.WriteLine(result);
        }
    }
}
