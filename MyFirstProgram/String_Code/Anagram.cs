using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Code
{
    class Anagram
    {
        public static bool Check_Anagram(string s1,string s2)
        {
            s1 = s1.ToLower();
            s2 = s2.ToLower();
            bool isanagram = false;
            char[] a1 = s1.ToCharArray();
            char[] a2 = s2.ToCharArray();
            Array.Sort(a1);
            Array.Sort(a2);
            if (s1.Length == s2.Length)
            {
                if (string.Join("", a1) == string.Join("", a2))
                {
                    isanagram = true;
                }
            }
            return isanagram;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String 1");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter String 2");
            string s2 = Console.ReadLine();
            bool res=Check_Anagram(s1, s2);
            if(res==true)
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
