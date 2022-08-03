using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Carr1
    {
        public int model_no;
        public string car_name;
        public int price;

        static void Main(string[] args)
        {
            Carr1 t = new Carr1();
            t.model_no=10099;
            t.car_name = "Duster";
            t.price = 1000000;
            Console.WriteLine("Model no.:"+t.model_no+" Car Name:"+t.car_name+" Car Price:"+t.price);
            Carr1 u = new Carr1();
            u.model_no = 18790;
            u.car_name = "Audi";
            u.price = 2500000;
            Console.WriteLine("Model no.:" + u.model_no + " Car Name:" + u.car_name + " Car Price:" + u.price);
            Carr1 v = new Carr1();
            v.model_no = 23498;
            v.car_name= "Swift";
            v.price = 1000000;
            Console.WriteLine("Model no.:" + v.model_no + " Car Name:" + v.car_name + " Car Price:" + v.price);
        }
    }
}
