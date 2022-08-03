using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Basic_Test1
{
    class Report_Card
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the marks for 5 subjects out of 100");
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            int s3 = int.Parse(Console.ReadLine());
            int s4 = int.Parse(Console.ReadLine());
            int s5 = int.Parse(Console.ReadLine());
            int total = s1 + s2 + s3 + s4 + s5;
            float avg = total / 5;
            double per = (total*100)/500;
            Console.WriteLine("Total="+ total);
            Console.WriteLine("Average="+ avg);
            Console.WriteLine("Percentage="+ per +"%");
        }
    }
}
