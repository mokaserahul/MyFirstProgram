using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.A1_D_Array_Test
{
    class Que7
    {
        public static void RemoveDuplicate(int[] a)
        {
            foreach(int x in a)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine("\n............................");
            for (int i = 0; i<a.Length;i++)
            {
                int count = 1;
                bool isvisited = false;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (a[i] == a[j])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int k = 0; k < a.Length; k++)
                    {
                        if (a[i] == a[k])
                        {
                            count++;
                        }
                    }
                    if(count>1)
                    {
                        Console.Write(a[i]+" ");
                    }
                }
                
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[5];
            Console.WriteLine("Enter Array Elements: ");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            RemoveDuplicate(a);
        }
    }
}
