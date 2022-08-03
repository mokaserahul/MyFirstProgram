using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class Ddemo
    {
        int price;
        int qty;
        float pro;
        float res;
        float Cal(int p,int q,float po)
        {
            price = p;
            qty = q;
            pro = po;
            res = price + (p * (pro / 100f));
            return res;
        }
        static void Main(string[] args)
        {
            float res;
            Ddemo d = new Ddemo();
            Console.WriteLine("Enter Price:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Quantity:");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Profit:");
            float po = float.Parse(Console.ReadLine());
            res = d.Cal(p, q, po);
            if (res % 1 == 0)
            { 
                Console.WriteLine(res+".0");
            }
            else
            {
                Console.WriteLine(res);
            }
        }

    }
}
