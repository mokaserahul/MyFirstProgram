using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Basic_Test1
{
    class Alpha_Digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a character:");
            char ch = Convert.ToChar(Console.ReadLine());
            if((ch>='a'&& ch<='z')||(ch>='A'&& ch<='Z'))
            {
                Console.WriteLine("Alphabet");
            }
            else if(ch>='0'&& ch<='9')
            {
                Console.WriteLine("Digit");
            }
            else
            {
                Console.WriteLine("Special Character");
            }
        }
    }
}
