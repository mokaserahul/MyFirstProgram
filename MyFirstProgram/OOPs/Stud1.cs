using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Stud1
    {
        int id;
        string name;
        float percentage;
        bool isplaced=true;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public float Percentage
        {
            get { return percentage; }
            set { percentage = value; }
        }
        public bool Isplaced
        {
            get { return isplaced; }
            set { isplaced = value; }
        }
    }
    class StudentInfo
    {
        static void Main(string[] args)
        {
            Stud1 s = new Stud1();
            s.Id = 1001;
            s.Name = "Rajesh";
            s.Percentage = 78.80f;
            s.Isplaced = true;
            int sid = s.Id;
            string sname = s.Name;
            float spercentage = s.Percentage;
            bool sisplaced = s.Isplaced;
            Console.WriteLine("Id:"+sid);
            Console.WriteLine("Name:"+sname);
            Console.WriteLine("Percentage:"+spercentage+"%");
            if(sisplaced==true)
            {
                Console.WriteLine("Placement Status: Placed");
            }
            else
            {
                Console.WriteLine("Placecement Status: Not Placed");
            }
        }
    }
}
