using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Test_OOPs
{
    //*Defination*
    //Inheritance: Acquiring properties of existing class into new class is called inheritance.
    //There are various types of inheritanace:Single inheritance, Multi-level inheritance, Multiple inheritance, Heirarchical inheritance.


    class Footwear
    {
        internal string brand = "Sparx";
        public void ShowFootwear()
        {
            Console.WriteLine("Brand:"+brand);
        }
    }
    class Shoes:Footwear
    {
        internal int size = 9;
        public void Showsize()
        {
            Console.WriteLine(brand+" "+size);
        }
    }
    class SportShoes:Shoes
    {
        internal int price = 1800;
        public void ShowPrice()
        {
            Console.WriteLine(brand+" "+size+" "+price);
        }
    }
    class FootwearInfo
    {
        static void Main(string[] args)
        {
            SportShoes s = new SportShoes();
            s.ShowFootwear();
            s.Showsize();
            s.ShowPrice();
        }
    }
}
