using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Code
{
    class Frequency
    {
        public static void GetFrequency(string s)
        {
            s = s.ToLower();
            for(int i= 0 ;i < s.Length;i++)
            {
                bool isvisited = false;
                int count = 1;
                for(int j=i-1;j>=0;j--)
                {
                    if(s[i]==s[j])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int j=i+1;j<s.Length;j++)
                    {
                        if(s[i]==s[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(s[i]+":"+count);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            string str = Console.ReadLine();
            GetFrequency(str);
        }
    }
}
