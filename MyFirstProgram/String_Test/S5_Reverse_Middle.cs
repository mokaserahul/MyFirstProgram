using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Test
{
    class S5_Reverse_Middle
    {
        public static string ReverseMiddle(string s)
        {
            char[] c = s.ToCharArray();
            int j = c.Length - 1;
            for (int i = 0; i < j; i++)
            {
                char temp = c[i];
                c[i] = c[j];
                c[j] = temp;
                j--;
            }
            return string.Join("",c);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            string s = Console.ReadLine();
            int i = 0;
            for (i = 0; i < s.Length && s[i] != ' '; i++)
            {
                Console.Write(s[i]);
            }
            string word = "";
            for(;i<s.Length;i++)
            {
                if(s[i]!=' ')
                {
                    word =word+ s[i];
                }
                else
                {
                    word = ReverseMiddle(word);
                    Console.Write(new StringBuilder(word).ToString()+" ");
                    word = "";
                }
            }
            Console.Write(word+" ");
        }
    }
}