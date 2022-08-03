using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs.Inheritance
{
    class Tv
    {
        internal string type="Full Smart HD";
        internal int price = 59000;
    }
    class Sony:Tv
    {
        public void Display()
        {
            Console.WriteLine("Type of Tv:"+type+" Price:"+price);
        }
    }
    class Single_level
    {
        static void Main(string[] args)
        {
            Sony s = new Sony();
            s.Display();

        }
    }
}
