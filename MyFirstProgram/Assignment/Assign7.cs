using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Assignment
{
    class Assign7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of your younger siblings:");
            int yn = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of your older siblings:");
            int on = int.Parse(Console.ReadLine());
            if(yn==0 && on==0)
            {
                Console.WriteLine("Only Child");
            }
            else if(yn>0 && on==0)
            {
                Console.WriteLine("Oldest Child");
            }
            else if(yn==0 && on>0)
            {
                Console.WriteLine("Youngest Child");
            }
            else
            {
                Console.WriteLine("Middle Child");
            }
        }
    }
}
