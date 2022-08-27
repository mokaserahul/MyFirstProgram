using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Code
{
    class Replace_Vowel
    {
        public static string Subsequent(string s)
        {
            string s1 = "";
            s = s.ToLower();
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]=='a'|| s[i] == 'e'|| s[i] == 'i'|| s[i] == 'o'|| s[i] == 'u')
                {
                    s1 = s1 + (char)(s[i]+1);
                }
                else
                {
                    s1 = s1 + s[i];
                }
            }
            return s1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            string str = Console.ReadLine();
            string s=Subsequent(str);
            Console.WriteLine(s);
        }
    }
}
