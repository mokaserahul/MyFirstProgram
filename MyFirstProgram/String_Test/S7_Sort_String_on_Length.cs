using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Test
{
    class S7_Sort_String_on_Length
    {
        public static string Sort_String(string str) 
        {
            string[] s = str.Split(' ');
            string res = "";
            for (int i = 0; i < s.Length; i++)
            {
                string temp = s[i];
                int j = i - 1;
                while (j >= 0 && temp.Length < s[j].Length)
                {
                    s[j + 1] = s[j];
                    j--;
                }
                s[j + 1] = temp;
            }
            for(int i=s.Length-1;i>=0;i--)
            {
                res = res + s[i]+" ";
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A String:");
            string s = Console.ReadLine();
            string res = Sort_String(s);
            Console.WriteLine(res);
        }
    }
}
