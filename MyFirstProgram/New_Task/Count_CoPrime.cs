using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.New_Task
{
    class Count_CoPrime
    {
        public static int GetCount(int n)
        {
            int count = 0;
            for (int i = 1; i < n; i++)
            {
                int fact = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0 && n % j == 0)
                    {
                        fact++;
                    }
                }
                if (fact == 1)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            int n = int.Parse(Console.ReadLine());
            int res = GetCount(n);
            Console.WriteLine(res);
        }
    }
}
