using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Assignment
{
    class Unique_Element
    {
        public static void Unique(char[] a)
        {
          
           
            for(int i=0;i<a.Length;i++)
            {
                bool isvisited = false;
                int count = 1;
                for (int j = i-1; j >=0;j--)
                {
                    if (a[i] == a[j])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if(isvisited==false)
                {
                    for(int k=i+1;k<a.Length;k++)
                    {
                        if(a[i]==a[k])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine(a[i] + " ");
                    }
                }
                
            }
        }
        static void Main(string[] args)
        {
            char[] a = new char[5];
            Console.WriteLine("Enter Array Elements:");
            for (int i = 0; i<a.Length;i++)
            {
                a[i] = Convert.ToChar(Console.ReadLine());
            }
            foreach(char x in a)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine("\n..........................");
            Unique(a);
        }
    }
}
