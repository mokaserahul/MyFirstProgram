using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Xobin
{
    class Xobin2
    {
        public static void CheckNum(int a)
        {
            int min = 0;
            bool inc = false, dec = false;
            int temp = a;
            while(a>0)
            {
                int r = a % 10;
                if(r<min)
                {
                    inc = true;
                    min = r;
                }
                else if(r>min)
                {
                    dec = true;
                    min = r;
                }
                a = a/ 10;
            }
            if(inc==false && dec==false)
            {
                Console.WriteLine("Bouncy");
            }
            else if(inc==true)
            {
                Console.WriteLine("Increasing");
            }
            else 
            {
                Console.WriteLine("Decreasing");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            CheckNum(n);
        }
    }
}
