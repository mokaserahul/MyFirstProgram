using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.List_Code
{
    class Mysort:IComparer<StringBuilder>
    {
        public int Compare(StringBuilder sb1,StringBuilder sb2)
        {
            string s1 = sb1.ToString();
            string s2 = sb2.ToString();
            return s1.CompareTo(s2);
        }
    }
    class A
    {
        static void Main(string[] args)
        {
            List<StringBuilder> lst = new List<StringBuilder>();
            lst.Add(new StringBuilder("Rahul"));
            lst.Add(new StringBuilder("Avinash"));
            lst.Add(new StringBuilder("Viraj"));
            lst.Add(new StringBuilder("Vishal"));
            lst.Sort(new Mysort());
            foreach(StringBuilder ob in lst)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
