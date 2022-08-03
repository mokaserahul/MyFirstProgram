using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loop3Test
{
    class Question6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
               
                for(int j=1;j<=i;j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}
