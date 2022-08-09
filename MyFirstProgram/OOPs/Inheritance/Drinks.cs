using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs.Inheritance
{
    class Drinks
    {
        internal string type = "Cofee";

        public void ShowDrink()
        {
            Console.WriteLine("Drink:" + type);
        }
    }
    class Cofee:Drinks
    {
        internal int qty = 4;
        public void Showqty()
        {
            Console.WriteLine("Drink:"+type+" Quantity:"+qty);
        }
    }
    class Cold_cofee:Cofee
    {
        internal int sugar_cubes = 2;
        public void ShowSweetness()
        {
            Console.WriteLine("Drink:"+type+" Quantity:"+qty+" Sugar cubes:"+sugar_cubes);
        }
    }
    class Multi_level
    {
        static void Main(string[] args)
        {
            Cold_cofee c = new Cold_cofee();
            c.ShowDrink();
            c.Showqty();
            c.ShowSweetness();
        }
    }

}
