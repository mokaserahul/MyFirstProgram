using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Code
{
    class Remove_Duplicate
    {
        public static string Remove(string s)
        {
            s = s.ToLower();
            string s1="";
            int k = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int j;
                for(j=0;j<i;j++)
                {
                    if(s[i]==s[j])
                    {
                        break;
                    }
                }
                if(j==i)
                {
                    s1=s1+s[i];
                    k++;
                }
            }
            return s1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A String:");
            string s = Console.ReadLine();
            string res = Remove(s);
            Console.WriteLine(res);
        }
    }
}
