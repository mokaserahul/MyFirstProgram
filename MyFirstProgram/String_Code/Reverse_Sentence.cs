using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Code
{
    
    class Reverse_Sentence
    {
        public static string Reverse(string s)
        {
            string rev = "";
            for(int i=s.Length-1;i>=0;i--)
            {
                rev = rev + s[i];
            }
            return rev;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            string str = Console.ReadLine();
            string[] s = str.Split(" ");
            for (int i = 0; i < s.Length; i++)
            {
                string rev = Reverse(s[i]);
                Console.Write(rev + " ");
            }
        }
    }
}
