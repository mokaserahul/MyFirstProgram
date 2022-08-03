using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Student
    {
        public int id;
        public string name;
        public int sub1,sub2,sub3;
        public float per;
        public void Acceptdetails(int sid,string sname,int ssub1,int ssub2,int ssub3)
        {
            id = sid;
            name = sname;
            sub1 = ssub1;
            sub2 = ssub2;
            sub3 = ssub3;
        }
        public void calculate_percentage()
        {
            int total = sub1 + sub2 + sub3;
            per = (total*100) / 300;
        }
        public void Display()
        {
            Console.WriteLine("Student Id:"+id+"\nStudent Name:"+name+"\nPhysics:"+sub1+"\nChemistry:"+sub2+"\nMaths:"+sub3+"\nPercentage:"+per+"%");
        }
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Acceptdetails(1, "Karan", 91, 87, 73);
            s1.calculate_percentage();
            s1.Display();
        }
    }
}
