using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.A1_D_Array_Test
{
    class Que13
    {
        static void Main(string[] args)
        {
            int buzz = 0, fizz = 0, buzzfizz = 0;
            for (int i = 1; i <= 50; i++)
            {
                if(i%3==0 && i%5==0)
                {
                    Console.WriteLine("buzzfizz");
                    buzzfizz++;
                }
                else if(i%3==0)
                {
                    Console.WriteLine("buzz");
                    buzz++;
                }
                else if(i%5==0)
                {
                    Console.WriteLine("fizz");
                    fizz++;
                }
            }
            Console.WriteLine("buzz:"+buzz);
            Console.WriteLine("fizz:"+fizz);
            Console.WriteLine("buzzfizz:"+buzzfizz);
        }
    }
}
