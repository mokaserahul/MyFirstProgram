using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Student1
    {
        int id;
        string name;
        float per;
        public void Acceptdetails(int id, string name, float per)
        {
            this.id = id;
            this.name = name;
            this.per = per;
            if(this.per<=0)
            {
                Console.WriteLine("Wrong Input");
            }
            else
            {
                this.Show();
                this.Find_grade();
          
            }

        }
        public void Find_grade()
        {
            Console.Write("Grade=");
            if(per>=90 && per<=100)
            {
                Console.Write("A+");
            }
            else if(per>=80 && per<=89)
            {
                Console.Write("A");
            }
            else if(per>=70 && per<=79)
            {
                Console.Write("B+");
            }
            else if(per>=60 && per <=69)
            {
                Console.Write("B");
            }
            else if(per>=50 && per<=59)
            {
                Console.Write("C+");
            }
            else if(per>=40 && per<=49)
            {
                Console.Write("C");
            }
            else if(per>0 && per<40)
            {
                Console.Write("D(Fail)");
            }
            Console.WriteLine("\n********************");
        }
        public void Show()
        {
            Console.WriteLine("Student ID:"+id);
            Console.WriteLine("Student Name:"+name);
            Console.WriteLine("Percentage:"+per+"%");
        }
        static void Main(string[] args)
        {
            Student1 s = new Student1();
            s.Acceptdetails(1001, "Amit", 78);
        }

    }
}
