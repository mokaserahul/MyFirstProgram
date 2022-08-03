using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class Armstrong_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int cube = 1;
            int temp = num;
            while(num>0)
            {
                int r = num % 10;
                cube = r * r * r;
                sum = sum + cube;
                num = num / 10;
            }
            if(sum==temp)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not an Armstrong Number");
            }
        }
    }
}
