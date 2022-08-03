using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Calculator
    {
        double result;
        public void Calculate(int num1, int num2)
        {
            this.result = num1 + num2;
            Console.WriteLine("Addition:" + result);
        }
        public void Calculate(int a,float b)
        {
            this.result = a - b;
            Console.WriteLine("Sub:"+result);
        }
        public void Calculate(float a,int b)
        {
            this.result = a * b;
            Console.WriteLine("Multiplication:"+result);
        }
        public void Calculate(float a,float b)
        {
            this.result = a / b;
            Console.WriteLine("Division:"+result);
        }
        static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.Calculate(23, 12);
            c.Calculate(54, 67.0f);
            c.Calculate(56.0f, 33);
            c.Calculate(107.0f,15.0f);
        }
    }
}
