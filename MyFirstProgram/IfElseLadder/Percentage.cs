using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.IfElseLadder
{
    class Percentage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks for 5 subjects out of 100");
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            int s3 = int.Parse(Console.ReadLine());
            int s4 = int.Parse(Console.ReadLine());
            int s5 = int.Parse(Console.ReadLine());
            int total = s1 + s2 + s3 + s4 + s5;
            double per = total / 5;
            Console.WriteLine("Percentage= " + per);
            if (per>=70)
            {
                Console.WriteLine("Distinction");
            }
            else if(per>=60 && per<70)
            {
                Console.WriteLine("First Class");
            }
            else if(per>=50 && per<60)
            {
                Console.WriteLine("Second Class");
            }
            else if(per>=35 && per<50)
            {
                Console.WriteLine("Pass Class");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
