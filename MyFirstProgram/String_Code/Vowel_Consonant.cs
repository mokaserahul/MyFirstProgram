using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String
{
    class Vowel_Consonant
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string s = Console.ReadLine();
            s = s.ToLower();
            int v = 0, c = 0;
            for(int i=0;i<s.Length;i++)
            {
                if(s[i]=='a'|| s[i] == 'e'|| s[i] == 'i'|| s[i] == 'o'|| s[i] == 'u')
                {
                    v++;
                }
                else
                {
                    c++;
                }
            }
            Console.WriteLine("Vowels:"+v+"  Consonants:"+c);
            for (int i = s.Length-1; i>=0; i--)
            {
                Console.Write(s[i]);
            }
        }
    }
}
