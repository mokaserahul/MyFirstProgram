using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.A1_D_Array_Test
{
    class Que3
    {
        public static void MinOccurence(char[] a)
        {
            int[] count = new int[5];
            int min = 1;
            char res = ' ';
            for (int i = 0; i < a.Length; i++)
            {
                bool isvisited = false;
                for (int j = i-1; j >=0; j--)
                {
                    if (a[i] == a[j])
                    {
                        isvisited = true;
                        break;
                    }
                    
                }
              
                if(isvisited==false)
                {
                    for(int k=i+1;k<a.Length;i++)
                    {
                        if (a[i] == a[k])
                        {
                            count[a[i]]++;
                        }
                    }
                    if(min>count[a[i]])
                    {
                        min = count[a[i]];
                        res = a[i];
                    }
                }
            }
            Console.WriteLine("Min Char:"+res);
        }
        static void Main(string[] args)
        {
            char[] a = new char[5];
            Console.WriteLine("Enter Array Elements:");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToChar(Console.ReadLine());
            }
            MinOccurence(a);
        }
    }
}
