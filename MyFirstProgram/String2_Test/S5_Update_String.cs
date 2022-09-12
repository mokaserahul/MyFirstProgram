using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String2_Test
{
    class S5_Update_String
    {
        public static string Update(string s)
        {
            s.ToCharArray();
            string res = "";
            for(int i=0;i<s.Length;i++)
            {
                if(char.IsDigit(s[i]))
                {
                    res = res + (char)(s[i]+1);
                }
                else if(char.IsLetter(s[i]))
                {
                    int d = (int)s[i] + 2;
                    if (char.IsUpper(s[i]) && d >= 90 || char.IsLower(s[i]) && d>=122)
                    {
                        d = d - 26;
                    }
                    res = res + (char)d;
                }
                else if(s[i]==' ')
                {
                    res = res + '_';
                }
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Update("Rahul15 37Zz"));
        }
    }
}
