using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Test
{
    class S2_Anagram
    {
        public static bool Anagram(string s1,string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            char[] c1 = s1.ToCharArray();
            char[] c2 = s2.ToCharArray();
            Array.Sort(c1);
            Array.Sort(c2);
            string str1 = new string(c1);
            string str2 = new string(c2);
            if(str1==str2)
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
            Console.WriteLine("Enter String1:");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter String2:");
            string s2 = Console.ReadLine();
            bool res = Anagram(s1, s2);
            if(res)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not Anagram");
            }
        }
    }
}
