using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loop3Test
{
    class Question3
    {
            public static bool isKaprekar(int n)
        {
            int sq = n * n;
            int temp = n,count=0;
            while(n>0)
            {
                count++;
                n = n / 10;
            }
            n = temp;
            Console.WriteLine("count:"+count);
            int power = 1;
            for(int i=1;i<=count;i++)
            {
                power = power * 10;
            }
            int q = sq / power;
            int r = sq % power;
            int sum = q + r;
            Console.WriteLine("Sum:"+sum);
            if(sum==n)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            if(isKaprekar(n))
            {
                Console.WriteLine("Kaprekar Number");
            }

            else
            {
                Console.WriteLine("Not Kaprekar Number");
            }
        }
    }
}
