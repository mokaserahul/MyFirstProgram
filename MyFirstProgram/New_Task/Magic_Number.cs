using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.New_Task
{
    class Magic_Number
    {
        public static void Magic(int t1,int t2,int n)
        {
            int[] series = new int[n];
            series[0] = t1;
            series[1] = t2;
            for (int i=2;i<n;i++)
            {
                int t3 = t1 + t2;
                series[i] = t3;
                t1 = t2;
                t2 = t3;
            }
            int[] even = new int[series.Length];
            int[] odd = new int[series.Length];
            int j = 0, k = 0;
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] % 2 == 0)
                {
                    even[k] = series[i];
                    k++;
                }
                else
                {
                    odd[j] = series[i];
                    j++;
                }
            }
            for(int i=0;i<k;i++)
            {
                Console.Write(even[i]+" ");
            }
            Console.WriteLine();
            for(int i=0;i<j;i++)
            {
                Console.Write(odd[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two Numbers:");
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter N");
            int n = int.Parse(Console.ReadLine());
            Magic(s1,s2,n);
        }
    }
}
