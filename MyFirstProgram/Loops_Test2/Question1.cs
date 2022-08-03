using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops_Test2
{
    class Question1
    {
        static void Main(string[] args)
        {
            for(int i=1;i<=100;i++)
            {
                if(i%5==0||i%10==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}
