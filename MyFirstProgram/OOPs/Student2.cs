using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Student2
    {
        public int roll_no=27;
        internal string name="Rahul";
        private string address="Pune";
        protected float marks=78.50f;
        public void Show_Roll_no(int roll_no)
        {
            this.roll_no = roll_no;
            Console.WriteLine("Roll no.:" +roll_no);
        }
        internal void Show_name(string name)
        {
            this.name = name;
            Console.WriteLine("Name:" +name);
        }

        private void Show_address(string address)
        {
            this.address = address;
            Console.WriteLine("Address:" +address);
        }
        protected void Show_marks(float marks)
        {
            this.marks = marks;
            Console.WriteLine("Marks:" +marks);
        }
            
        static void Main(string[] args)
        {
            Student2 d = new Student2();
            d.Show_Roll_no(27);
            d.Show_name("Rahul");
            d.Show_address("Pune");
            d.Show_marks(78.50f);
        }
    }
}
