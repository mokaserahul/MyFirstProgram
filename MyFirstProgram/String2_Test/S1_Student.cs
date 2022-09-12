using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String2_Test
{
    class S1_Student
    {
        int id;
        string name;
        string[] hobbies;
        S1_Student(int sid,string sname,string[] shobbies)
        {
            this.id = sid;
            this.name = sname;
            this.hobbies = shobbies;
        }
        public void Show()
        {
            Console.WriteLine(id+" "+name+" "+hobbies);
        }
        static void Main(string[] args)
        {
            string[] hobbies1 = { "Reading", "Gardening" };
            S1_Student s = new S1_Student(101, "Rahul",hobbies1);
            s.Show();
            S1_Student s1 = new S1_Student(102, "Vishal", hobbies1);
            s1.Show();
        }
    }
}
