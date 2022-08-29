using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Test
{
    class S6_Remove_Char
    {
        public static string Remove(string s1,string s2)
        {
            int[] count = new int[256];
            for(int i = 0; i < s2.Length; i++)
            {
                count[s2[i]]++;
            }
            int j = 0, k = 0;
            char[] arr = s1.ToCharArray();
            while(j!=arr.Length)
            {
                char temp = arr[j];
                if(count[temp]==0)
                {
                    arr[k] = arr[j];
                    k++;
                }
                j++;
            }
            s1 = new string(arr);
            return s1.Substring(0, k);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String1");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter String2");
            string s2 = Console.ReadLine();
            string res = Remove(s1, s2);
            Console.WriteLine(res);
        }
    }
}
