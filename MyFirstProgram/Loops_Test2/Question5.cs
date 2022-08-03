using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops_Test2
{
    class Question5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int temp = n;
            while(n>0)
            {
                int r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            if(temp%sum==0)
            {
                Console.WriteLine("It is a Harshad Number");
            }
            else
            {
                Console.WriteLine("Not a Harshad Number");
            }
        }
    }
}
