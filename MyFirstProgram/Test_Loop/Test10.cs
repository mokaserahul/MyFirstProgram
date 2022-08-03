using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Test_Loop
{
    class Test10
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, sum = 0;
            Console.Write(a+" "+b+" ");
            for(int i=2;i<20;i++)
            {
                sum = a + b;
                Console.Write(sum+" ");
                a = b;
                b = sum;
            }
        }
    }
}
