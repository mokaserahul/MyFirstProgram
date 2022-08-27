using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.New_Task
{
    class Largest_Subarray
    {
        public static int SubArray(int[] arr)
        {
            int max = 0;
            for (int i = 0; i < arr.Length;i++)
            {
                int zero = 0, one = 0;
                for(int j=0;j<arr.Length;j++)
                {
                    if(arr[j]==1)
                    {
                        one++;
                    }
                    else
                    {
                        zero++;
                    }
                    if(zero==one)
                    {
                        if(max<(j-1+1))
                        {
                            max = j - i + 1;
                        }
                    }
                }
            }
            return max;
        }
        static void Main(string[] args)
        {
            int max = SubArray(new int[] { 1,0,1,1, 1, 0, 0, 0, 1, 1, 1, 1 });
            Console.WriteLine(max);
        }
    }
}
