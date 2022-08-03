using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Car_Properties
    {
        int model_no;
        string car_name;
        string colour;
        float price;
        int speed;
        public int Model_no
        {
            get { return model_no; }
            set { model_no = value; }
        }
        public string Car_name
        {
            get { return car_name; }
            set { car_name = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }
    }

    class CarInfo
    {
        static void Main(string[] args)
        {
            Car_Properties c = new Car_Properties();
            c.Model_no = 11001;
            c.Car_name = "Baleno";
            c.Colour = "White";
            c.Price = 1000000.0f;
            c.Speed = 120;
            int cmodel_no = c.Model_no;
            string ccar_name = c.Car_name;
            string ccolour = c.Colour;
            float cprice = c.Price;
            int cspeed = c.Speed;
            Console.WriteLine("Model no:"+cmodel_no);
            Console.WriteLine("Car Name:"+ccar_name);
            Console.WriteLine("Car Colour:"+ccolour);
            Console.WriteLine("Car Price:"+cprice);
            Console.WriteLine("Car Speed:"+cspeed+" KMPH");
        }
    }
}
