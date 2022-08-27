using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.New_Task
{
    class Coprime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int fact = 0;
            for (int i = 1; i <= n1; i++)
            {
                if (n1 % i == 0 && n2 % i == 0)
                {
                    fact = i;
                }
            }
            if (fact == 1)
            {
                Console.WriteLine("Co-Prime");
            }
            else
            {
                Console.WriteLine("Not Co-Prime");
            }
        }
    }
}
