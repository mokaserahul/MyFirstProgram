using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.July27
{
    class Car_Prop
    {
        int model_no;
        string name;
        double price;
        int speed;

        public int Model_no
        {
            get
            {
                return model_no;
            }
            set
            {
                model_no = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
    }
    class Car_Access
    {
        static void Main(string[] args)
        {
            Car_Prop c = new Car_Prop();
            c.Model_no = 100997;
            c.Name = "BMW";
            c.Price = 3500000;
            c.Speed = 210;
            Console.WriteLine("Model no:" + c.Model_no + "\nName:" + c.Name + "\nPrice:" + c.Price + "\nSpeed:" + c.Speed + "KMPH");
        }
    }
}