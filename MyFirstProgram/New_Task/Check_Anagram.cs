using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.New_Task
{
    class Check_Anagram
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
            Console.WriteLine("Enter String 1:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter String 2:");
            string str2 = Console.ReadLine();
            bool result = Anagram(str1, str2);
            if(result)
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
