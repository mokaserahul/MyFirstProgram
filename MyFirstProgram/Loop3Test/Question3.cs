using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loop3Test
{
    class Question3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int n = int.Parse(Console.ReadLine());
            int square = n * n;
            int temp = square;
            int sum = 0, count = 0, p1, p2,v1=0,v2=0;
            while(square>0)
            {
                count++;
                square = square / 10;
            }
            square = temp;
            if(count%2==0)
            {
                p1 = count / 2;
            }
            else
            {
                p1 = (count / 2) + 1;
            }
            p2 = count - p1;
            for(int i=1;i<=p1;i++)
            {
                while(square>0)
                {
                    int r = square % 10;
                    v1 = v1 + r;
                    square = square / 10;
                }
            }
            square = temp;
            for(int i=1;i<=p2;i++)
            {

            }
        }
    }
}
