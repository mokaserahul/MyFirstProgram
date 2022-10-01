using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.List_Code
{
    class LinkedListD
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddLast(100);
            ll.AddLast(200);
            ll.AddLast(300);
            ll.AddFirst(1000);

            foreach(int data in ll)
            {
                Console.WriteLine(data);
            }
        }
    }
}
