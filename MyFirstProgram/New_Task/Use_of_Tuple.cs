using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.New_Task
{
    class Use_of_Tuple
    {
        static Tuple<int,int> Calculate(int a, int b)
        {
            int sum = a + b;
            int prod = a * b;
            return Tuple.Create(sum, prod);
        }
        static(int,int) Cal(int a,int b)
        {
            int sub = a - b;
            int div = a / b;
            return (sub, div);
        }
        static void Main(string[] args)
        {
            Tuple<int, int> t = Calculate(12, 13);
            Console.WriteLine(t.Item1);
            Console.WriteLine(t.Item2);
            var (sub, div) = Cal(10, 4);
            Console.WriteLine(sub);
            Console.WriteLine(div);
        }
    }
}
