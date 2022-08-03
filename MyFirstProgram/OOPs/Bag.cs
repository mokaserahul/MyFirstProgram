using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Pen
    {
        int length;
        string pen_name;
        string pen_colour;
        string type;
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public string Pen_name
        {
            get { return pen_name; }
            set { pen_name = value; }
        }
        public string Pen_colour
        {
            get { return pen_colour; }
            set { pen_colour = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
    class Bag
    {
        string brand_name;
        int price;
        string colour;
        Pen p;
        public string Brand_name
        {
            get { return brand_name; }
            set { brand_name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Colour
        {
            get { return colour; }
            set { colour = value; }
        }
        public Pen P
        {
            get { return p; }
            set { p = value; }
        }
    }
    class BagInfo
    {
        static void Main(string[] args)
        {
            Bag a = new Bag();
            a.Brand_name = "Skybags";
            a.Price = 1890;
            a.Colour = "Blue";
            a.P = new Pen();
            a.P.Length = 10;
            a.P.Pen_name = "Cello";
            a.P.Pen_colour = "Black";
            a.P.Type = "Gel Pen";
            Console.WriteLine("Brand:"+a.Brand_name+"\nPrice "+a.Price+"\nColour:"+a.Colour+"\nPen Length:"+a.P.Length+"\nPen Name:"+a.P.Pen_name+"\nPen Colour:"+a.P.Pen_colour+"\nPen Type:"+a.P.Type);
        }        
    }
}
