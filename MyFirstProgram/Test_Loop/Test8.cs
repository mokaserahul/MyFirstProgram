using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Test_Loop
{
    class Test8
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            Console.Write(2);
            for(int i=2;i<=n;i++)
            {
                result = (i * i) + (i * i * i);
                Console.Write(" "+result);
            }
        }
    }
}
