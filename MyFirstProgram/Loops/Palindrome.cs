using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class Palindrome
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int a = n;
            int rev = 0;
            while(n>0)
            {
                int rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;

            }
            if(rev==a)
            {
                Console.WriteLine("Palindrome");

            }
            else
            {
                Console.WriteLine("Not a Palindrome");
            }

        }
    }
}
