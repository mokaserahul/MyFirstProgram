using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Code
{
    class PasswordValidation
    {
        public static bool Validate(string pass)
        {
            int up = 0,sp = 0,digit=0;
            for (int i = 0; i < pass.Length; i++)
            {
                if (char.IsUpper(pass[i]))
                {
                    up++;
                }
                else if(char.IsSymbol(pass[i])|| pass[i] =='@'|| pass[i] =='!'|| pass[i] =='#'|| pass[i] =='%'|| pass[i] =='&'|| pass[i] =='*')
                {
                    sp++;
                }
                else if (char.IsDigit(pass[i]))
                {
                    digit++;
                }
            }
            if (up >= 1 && sp >= 1 && digit >= 1 && pass.Length>=7)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Password");
            string p = Console.ReadLine();
            bool pass = Validate(p);
            if(pass==true)
            {
                Console.WriteLine("Valid Password");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}
