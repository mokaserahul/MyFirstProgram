using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Code
{
    class SplitArray
    {
        public static void Split(int[] arr)
        {
            foreach(int x in arr)
            {
                Console.Write(x+" ");
            }
            int[] even = new int[arr.Length];
            int[] odd= new int[arr.Length];
            int j = 0, k = 0;
            for(int i=0;i<arr.Length;i++)
            {
                if(arr[i]%2==0)
                {
                    even[j] = arr[i];
                    j++;
                }
                else
                {
                    odd[k] = arr[i];
                    k++;
                }

            }
            Console.WriteLine("\n.................................");
            foreach (int x in even)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n.................................");

            foreach (int x in arr)
            {
                Console.Write(odd + " ");
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 45, 23, 12, 4, 9, 0, 34 };
            SplitArray.Split(arr);
        }
    }
}
