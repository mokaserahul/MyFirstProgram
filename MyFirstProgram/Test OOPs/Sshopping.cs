using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Test_OOPs
{
    class CreditCard
    {
        public CreditCard(int a)
        {

        }

    }
    class DebitCard
    {
        int amt;
    }
    class Sshopping
    {
        public CreditCard c;
        public DebitCard d;
        public void doTransaction(CreditCard n)
        {
            Console.WriteLine("You got 15% discount on bill on credit card transaction");
        }
        public void doTransaction(DebitCard n)
        {
            
            Console.WriteLine("No discount on bill on debit card transaction");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount:");
            int amt = int.Parse(Console.ReadLine());
            Sshopping s = new Sshopping();
           // int a = new CreditCard(amt);
            //s.doTransaction(CreditCard a);
            //int b = new DebitCard(amt);
            //s.doTransaction(DebitCard b);

        }
    }
}
