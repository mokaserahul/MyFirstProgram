using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Code
{
    class Occurence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the character to check it's occurence:");
            char s = Convert.ToChar(Console.ReadLine());
            int count = 0;
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]==s)
                {
                    count++;
                }
            }
            Console.WriteLine("Occurence of "+s+" is:"+count);
        }
    }
}
