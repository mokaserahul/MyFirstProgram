using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Car
    {
        public int model_no;
        public string name;
        public long price;
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.model_no = 1001;
            car1.name = "Baleno";
            car1.price = 700000;
            Console.WriteLine("Model no.:"+car1.model_no +"\nCar Name:"+car1.name+"\nPrice:"+car1.price);

            Car car2 = new Car();
            car2.model_no = 1002;
            car2.name = "Creta";
            car2.price = 1000000;
            Console.WriteLine("Model no.:" + car2.model_no + "\nCar Name:" + car2.name + "\nPrice:" + car2.price);

        }
    }
}
