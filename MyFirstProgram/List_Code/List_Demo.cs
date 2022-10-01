using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.List_Code
{
    class List_Demo
    {
        static void Main(string[] args)
        {
            List<string> lst = new List<string>();
            lst.Add("Rahul");
            lst.Add("Viraj");
            lst.Add("Om");
            lst.Add("Priya");
            lst.Add("Amey");
            lst.RemoveAt(1);
            for(int i=0;i<lst.Count;i++)
            {
                Console.Write(lst[i]+" ");
            }
            Console.WriteLine();
            for(int i=lst.Count-1;i>=0;i--)
            {
                Console.Write(lst[i]+" ");
            }
        }
    }
}
