using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Condition
{
    class Vowel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Character");
            char ch = Convert.ToChar(Console.ReadLine());
            if(ch=='a'||ch=='A'||ch=='e'||ch=='E'||ch=='i'||ch=='I'||ch=='o'||ch=='O'||ch=='u'||ch=='U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonent");
            }

        }
    }
}
