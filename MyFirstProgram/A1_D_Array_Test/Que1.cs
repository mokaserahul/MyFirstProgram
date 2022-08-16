using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.A1_D_Array_Test
{
    class Que1
    {
        public static void CountEvenOdd(int[] arr)
        {
            int ecount = 0, ocount = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]%2==0)
                {
                    ecount++;
                }
                else
                {
                    ocount++;
                }
            }
            Console.WriteLine("Even Count:"+ecount+"  Odd Count:"+ocount);
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter Array Elements:");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            CountEvenOdd(arr);
        }
    }
}
