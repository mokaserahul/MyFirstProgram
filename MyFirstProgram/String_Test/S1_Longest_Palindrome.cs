using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Test
{
    class S1_Longest_Palindrome
    {
        public static string LongestPalindrome(string s)
        {
            int max = 0;
            int m = 0, n = s.Length - 1;
            bool ispalindrome = false;
            while(m<=n)
            {
                if(s[m]==s[n])
                {
                    ispalindrome = true;
                }
                m++;
                n--;
            }
            string temp = "";
            for(int i=0;i<s.Length;i++)
            {
                for(int j=i;j<i-j+1;j++)
                {
                    temp=temp+ s[j-i+1]; 
                    if(ispalindrome && max<(i-j+1))
                    {
                        max = temp.Length;
                    }
                }
            }
            temp = s.Substring(0, max);
            return temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            string str = Console.ReadLine();
            string res = LongestPalindrome(str);
            Console.WriteLine(res);
        }
    }
}
