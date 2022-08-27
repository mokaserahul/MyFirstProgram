using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Code
{
    class Encryption
    {
        public static string Encrypt(string s,int n)
        {
            string s1 = "";
            for(int i=0;i<s.Length;i++)
            {
                int a = s[i] + n;
                if (char.IsLetter(s[i]))
                {
                    if ((char.IsUpper(s[i]) && a > 90 )|| (char.IsLower(s[i]) && a>122))
                    {
                        a = a - 26;  
                    }
                    s1 = s1 + (char)a;
                }
            }
            return s1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the value to move the string:");
            int n = int.Parse(Console.ReadLine());
            string s=Encrypt(str,n);
            Console.WriteLine(s);
        }
    }
}
