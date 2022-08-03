using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loop3Test
{
    class Question2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base number:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the index number");
            int y = int.Parse(Console.ReadLine());
            int result = 1;
            for(int i=1;i<=y;i++)
            {
                result = result * x;
            }
            Console.WriteLine("Result:"+result);
        }
    }
}
