using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Basic_Test1
{
    class Simple_Calculator
    {
        static void Main(string[] args)
        {
            char ch;
            do
            {
                double res;
                Console.WriteLine("Enter Two numbers:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your choice from the Menu:");
                Console.WriteLine("1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        res = a + b;
                        Console.WriteLine("Addition is:" + res);
                        break;
                    case 2:
                        res = a - b;
                        Console.WriteLine("Substraction is:" + res);
                        break;
                    case 3:
                        res = a * b;
                        Console.WriteLine("Multiplication is:" + res);
                        break;
                    case 4:
                        res = a / b;
                        Console.WriteLine("Division is:" + res);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
                Console.WriteLine("Do you want to continue?....(Y/N).......");
                ch = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y' || ch == 'Y');
        }
    }
}
