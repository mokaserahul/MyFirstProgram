using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs.Inheritance
{
    class Gadget
    {
        protected string ram;
        protected string memory;
        protected string brand;
    }
    class Laptop:Gadget
    {
        public void ShowLaptop()
        {
            ram = "8 GB";
            memory = "1 TB";
            brand = "Lenovo";
            Console.WriteLine(ram+" "+memory+" "+brand);
        }
    }
    class Mobile:Gadget
    {
        public void ShowMobile()
        {
            ram = "6 GB";
            memory = "256 GB";
            brand = "Samsung";
            Console.WriteLine(ram + " " + memory + " " + brand);

        }
    }
    class Heirarchical
    {
        static void Main(string[] args)
        {
            Laptop l = new Laptop();
            l.ShowLaptop();
            Mobile m = new Mobile();
            m.ShowMobile();
        }
    }
}
