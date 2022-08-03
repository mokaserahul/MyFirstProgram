using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Electricity_bill
    {
        int cust_id;
        string cust_name;
        int reading;
        int prev_reading;
        int consumption;
        float price;
        double bill;
        Electricity_bill(int cust_id,string cust_name,int reading,int prev_reading,float price)
        {
            this.cust_id = cust_id;                                      //First Use
            this.cust_name = cust_name;
            this.reading = reading;
            this.prev_reading = prev_reading;
            this.price = price;
        }
        Electricity_bill():this(10908,"Karan Kumar",10989,10567,9.5f)    //Third Use
        {
            consumption = reading - prev_reading;
            bill = consumption * price;                               
            this.Show();                                                //Second Use
        }
        void Show()
        {
            Console.WriteLine("Customer ID:"+cust_id+"\nCustomer Name:"+cust_name+"\nCurrent Reading:"+reading+"\nPrevious Reading:"+prev_reading+"\nTotal Consumption:"+consumption+"\nPrice:"+price+"\nTotal Bill:"+bill);
        }
        static void Main(string[] args)
        {
            Electricity_bill e = new Electricity_bill();
        }
    }
}
