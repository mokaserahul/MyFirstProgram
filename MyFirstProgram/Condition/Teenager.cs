using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Condition
{
    class Teenager
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the age of the peron:");
            int age = int.Parse(Console.ReadLine());
            if(age>=13 && age<=19)
            {
                Console.WriteLine("The person is a Teenager");
            }
            else
            {
                Console.WriteLine("The person is not a Teenager");
            }
        }
    }
}
