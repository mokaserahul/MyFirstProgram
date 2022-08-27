using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.New_Task
{
    class Arithmetic_Progression
    {
        public static int Term(int t2,int t3,int n)
        {
            int d = t3 - t2;
            int t4 = t3;
            for(int i=4;i<=n;i++)
            {
                t4 = t4 + d;
            }
            return t4;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Term(3,7,8));
        }
    }
}
