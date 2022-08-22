using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Code
{
    class Toggle
    {
        public static string GetToggle(string s)
        {
            string t = "";
            for(int i=0;i<s.Length;i++)
            {
                if(char.IsUpper(s[i]))
                {
                    t = t + char.ToLower(s[i]);
                }
                else if(char.IsLower(s[i]))
                {
                    t = t + char.ToUpper(s[i]);
                }
            }
            return t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            string s = GetToggle(str);
            Console.WriteLine(s);
        }
    }
}
