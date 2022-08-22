using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.A1_D_Array_Test
{

    class Pen
    {
        Refill r;
        int caplenth;
        string brand;
        public Refill R
        {
            get{ return r;}
            set { r = value; }
        }
        public int Caplength
        {
            get { return caplenth; }
            set { caplenth = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
    }
    class Refill
    {
        string inkcolor;
        int length;
        Nib n;
        public string Inkcolor
        {
            get { return inkcolor; }
            set { inkcolor = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public Nib N
        {
            get { return n;}
            set { n = value; }
        }
    }
    class Nib
    {
        string materialtype;
        int width;
        public string Materialtype
        {
            get { return materialtype; }
            set { materialtype = value; }
        }
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
    }
    class Que4
    {
        Pen p = new Pen();
        Refill r=new Refill();
        Nib n = new Nib();
        

    }
}
