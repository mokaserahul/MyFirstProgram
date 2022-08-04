using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.New_Assignment
{
    class Check_Pallindrome
    {
        static bool ispallindrome(int n)
        {
            int temp = n;
            int rev = 0;
            while(n>0)
            {
                int r = n % 10;
                rev = rev * 10 + r;
                n = n / 10;
            }
            if(rev==temp)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            int c = 0;
            while (n >= 0)
            {
                c++;
                if (ispallindrome(n) == true)
                {
                    Console.WriteLine("Pallindrome");
                }
                else
                {
                    Console.WriteLine("Not Pallindrome");
                }

                Console.WriteLine("Enter a Number:");
                n = int.Parse(Console.ReadLine());
                if(c>4)
                {
                    break;
                }
            }

        }
    }
}
