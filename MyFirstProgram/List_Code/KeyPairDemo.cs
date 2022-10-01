using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.List_Code
{
    class KeyPairDemo
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d1 = new Dictionary<string, int>();
            d1.Add("Rahul", 91);
            d1.Add("Viraj", 91);
            d1.Add("Suraj", 92);
            d1.Add("Avinash", 93);
            d1.Add("Vishal", 94);
            d1["Rahul"] = 93;
            d1.Remove("Rahul");
            Console.WriteLine(d1.ContainsKey("Arun"));
            Console.WriteLine(d1.ContainsValue(91));
            foreach(KeyValuePair<string,int>kv in d1)
            {
                Console.WriteLine(kv.Key+"  "+kv.Value);
            }
        }
    }
}
