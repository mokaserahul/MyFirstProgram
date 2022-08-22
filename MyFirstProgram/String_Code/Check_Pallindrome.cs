using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String
{
    class Check_Pallindrome
    {
        public static string Reverse_Str(string str)
        {
            string j="" ;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                j = j+str[i];

            }

            return j;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();
            string rev = Reverse_Str(s);
            Console.WriteLine("Reverse is:"+rev);
            if(rev==s)
            {
                Console.WriteLine("String is Palindrome");
            }
            else
            {
                Console.WriteLine("String is not Palindrome");
            }
        }
    }
}
