using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Test_Loop
{
    class Test3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int cube = n * n * n;
            Console.WriteLine("Cube:"+cube);
            int a = 0;
            while(n>0)
            {
                if(n%10==cube%10)
                {
                    a = 1;
                    n = n / 10;
                    cube = cube / 10;
                }
                else 
                {
                    a = 0;
                }
            }
            if (a == 1) 
            {
                Console.WriteLine("Trimorphic Number");
            }
            else 
            {
                Console.WriteLine("Not a Trimorphic number");
            }
           
        }
    }
}
