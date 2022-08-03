using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops_Test2
{
    class Order
    {
        
        int order_id;
        string city;
        string cust_name;
        bool isdelivered;

        public int Order_id
        {
            get { return order_id; }
            set { order_id = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Cust_name
        {
            get { return cust_name; }
            set { cust_name = value; }
        }
        public bool Isdelivered
        {
            get { return isdelivered; }
            set { isdelivered = value; }
        }
        
    }
}
