using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.List_Code
{
    class Trainer:IComparable<Trainer>
    {
        int tid;
        string tname;

        public int Tid { get => tid; set => tid = value; }
        public string Tname { get => tname; set => tname = value; }
        public int CompareTo(Trainer t)
        {
            return this.tname.CompareTo(t.tname);
        }

        public Trainer(int tid,string tname)
        {
            this.Tid = tid;
            this.Tname = tname;
        }
        public Trainer()
        {

        }
        public override string ToString()
        {
            return $"Trainer ID:{tid}  Name:{tname}";
        }
    }
    class Trainer_Details
    {
        static void Main(string[] args)
        {
            List<Trainer> lst = new List<Trainer>();

            lst.Add(new Trainer(101, "Amit"));
            lst.Add(new Trainer(102, "Raj"));
            lst.Add(new Trainer(103, "Karan"));
            lst.Add(new Trainer(104, "Jai"));
            lst.Sort();
            foreach(Trainer t in lst)
            {
                Console.WriteLine(t);
            }
        }
    }

}
