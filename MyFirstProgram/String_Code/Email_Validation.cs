using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String_Code
{
   
    class Email_Validation
    {
        public static bool Isvalid(string s)
        {
            int idx = s.IndexOf('@');
            int dot = s.IndexOf('.');
            if (idx < dot && idx!=-1 && dot!=-1)
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
            Console.WriteLine("Enter Email Address:");
            string str = Console.ReadLine();
            bool status = Isvalid(str);
            if(status==true)
            {
                Console.WriteLine("Valid Email");
            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
        }
    }
}
