using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MyFirstProgram.List_Code
{
    class LinkedlistDemo
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(89);
            ll.AddLast(45);
            ll.AddLast(42);
            ll.AddLast(34);
            ll.AddLast(90);
            ll.AddLast(32);
            LinkedListNode<int> node = ll.Find(34);
            if(node!=null)
            {
                ll.AddBefore(node, 199);
            }
            ll.Remove(42);
            foreach(int data in ll)
            {
                Console.WriteLine(data);
            }



            for(int i=0;i<ll.Count;i++)
            {
                Console.WriteLine(ll.ElementAt(i));
            }
        }
    }
}
