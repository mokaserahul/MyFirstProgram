using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Shopping
    {
        public string purchase_item;
        public int quantity;
        public int price;
        public int bill;

        public void Acceptdetails(string item,int squantity,int sprice)
        {
            purchase_item = item;
            quantity = squantity;
            price = sprice;
        }
        public void Getbill()
        {
            
            if(quantity<0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                bill = quantity * price;
            }
        }
        public void show()
        {
            Console.WriteLine("\nItem Name:"+purchase_item);
            Console.WriteLine("Quantity:"+quantity);
            Console.WriteLine("Price:"+price);
            Console.WriteLine("Total bill:"+bill);
            Console.WriteLine("************Thankyou***********");
        }
        static void Main(string[] args)
        {
            Shopping s1 = new Shopping();
            s1.Acceptdetails("Cookies Pack(100 gm)", 20, 35);
            s1.Getbill();
            s1.show();
        }
    }
}
