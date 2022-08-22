using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.A1_D_Array_Test
{
    class Que6
    {
        public static void SeperateZero(int[] a)
        {
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine("\n.........................");
            int j = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                {
                    if (a[i] != 0)
                    {
                        a[j] = a[i];
                        
                    }
                    
                }
                
                else
                {
                    a[j] = 0;
                }
                Console.Write(a[i]+" ");
                j++;
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter Array Elements:");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            SeperateZero(a);
            
        }
    }
}
