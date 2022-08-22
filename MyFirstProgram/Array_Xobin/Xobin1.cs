using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Xobin
{
    class Xobin1
    {
        public static void CheckHappy(int n)
        {
            bool ishappy = true;
            while (n > 0)
            {
                int r = n % 10;
                if (r % 2 == 0)
                {
                    ishappy = false ;
                }
                n = n / 10;
            }
            if(ishappy==true)
            {
                Console.WriteLine("Happy");
            }
            else
            {
                Console.WriteLine("Not Happy");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            CheckHappy(n);
        }
    }
}
