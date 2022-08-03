using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Vehicle
    {
        public int model_no;
        public string type;
        public int no_of_wheels;
        public int average;

        public void Acceptdetails(int mod_no,string vtype,int wheels)
        {
            model_no = mod_no;
            type = vtype;
            no_of_wheels = wheels;
        }

        public void Getaverage()
        {
            if(no_of_wheels==2)
            {
                average = 45;
            }
            else if(no_of_wheels==3)
            {
                average = 24;
            }
            else if(no_of_wheels==4)
            {
                average = 20;
            }
            else if(no_of_wheels==8)
            {
                average = 11;
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public void Show()
        {
            Getaverage();
            Console.WriteLine("Model No:"+model_no+"\nType of Vehicle:"+type+"\nNo of Wheels:"+no_of_wheels+"\nAverage:"+average);
        }
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.Acceptdetails(100987, "Car", 4);
            v.Show();
        }
    }
}
