using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class ThisUse
    {
        int x = 25;
        int id;
        string name;
        public ThisUse():this(1001,"Amit")//Third use of this keyword
        {
            Console.WriteLine("Hello!");
        }
        public void input(int x)
        {
            this.x = x;                   //First use of this keyword
            this.show();                  //Second use of this keyword
        }
        public void show()
        {
            Console.WriteLine("X="+x);
            Console.WriteLine("ID:"+id+"    Name:"+name);
        }
        public ThisUse(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        static void Main(string[] args)
        {
            ThisUse t = new ThisUse();
            t.input(259);
           
        }
    }
}
