using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Calculate_Loan
    {
        int amount;
        int duration;
        double loan;
        void Loan(float x)
        {
            loan = amount *duration* (x / 100);
            Console.WriteLine("Loan:"+loan);
        }
        void Loan(float x,float y)
        {
            if(duration>=0 && duration<=6)
            {
                loan = amount * duration * (x / 100);
            }
            else if(duration>6)
            {
                loan = amount * duration * (y / 100);
            }
            Console.WriteLine("Loan="+loan);
        }
        static void Main(string[] args)
        {
            Calculate_Loan l = new Calculate_Loan();
            Console.WriteLine("Enter the Amount:");
            l.amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the duration");
            l.duration = int.Parse(Console.ReadLine());
            l.Loan(6.0f);
            l.Loan(7.0f, 8.1f);
        }
    }
}
