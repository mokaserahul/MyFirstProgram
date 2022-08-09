using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Test_OOPs
{
    class Q5
    {

        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("Enter Your choice from the Menu:\n1.India\n2.China\n3.Bangladesh\n4.Italy\n5.United States");
            do
            {
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Hockey");
                        break;
                    case 2:
                        Console.WriteLine("Table Tennis");
                        break;
                    case 3:
                        Console.WriteLine("Kabaddi");
                        break;
                    case 4:
                        Console.WriteLine("Football");
                        break;
                    case 5:
                        Console.WriteLine("Baseball");
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
                Console.WriteLine("Do you want to continue(Y/N)");
                c = char.Parse(Console.ReadLine());
                continue;
            } while (c == 'y' || c == 'Y');
        }
    }
}
