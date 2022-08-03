using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Bank
    {
        int account_no;
        string name;
        float balance;

        public void Assign_details(int account_no,string name,float balance)
        {
            this.account_no = account_no;
            this.name = name;
            this.balance = balance;
            Show_details();
        }
        public void Show_details()
        {
            Console.WriteLine("Account Number:"+account_no);
            Console.WriteLine("Customer Name:"+name);
            Console.WriteLine("Account Balance:"+balance);
        }
        public void Withdraw(int w)
        {
            if (w>balance)
            {
                
                Console.WriteLine("The amount is incorrect");
            }
            else
            {
                balance = balance - w;
                Console.WriteLine("After Withdrawal Balance:"+balance);
            }
        }
        public void Deposit(int d)
        {
            Console.WriteLine("Deposited:" + d);
            balance = balance + d;
            Console.WriteLine("After Deposit Balance:"+balance);
        }
        static void Main(string[] args)
        {
            Bank b = new Bank();
            int wi, de;
            b.Assign_details(1001,"Raj Khanna",20000);
            Console.WriteLine("Enter the withdrawal Amount:");
            wi = int.Parse(Console.ReadLine());
            b.Withdraw(wi);
            Console.WriteLine("Enter the Amount to be deposited:");
            de = int.Parse(Console.ReadLine());
            b.Deposit(de);
            Console.WriteLine("*****************Thankyou****************");
        }
    }
}
