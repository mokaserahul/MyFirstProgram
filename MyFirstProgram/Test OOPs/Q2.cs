using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Test_OOPs
{
    class Watch
    {
        public int budget=5000;
        
        public void Display()
        {
            Console.WriteLine("********Watch*********");
        }
        public Watch(int code)
        {
            Console.WriteLine("Code:" + code);
        }
    }
    class Titan:Watch
    {
        public int price = 3000;
        public void ShowTitan()
        {   
            base.Display();
            Console.WriteLine("Titan");                                     //Second Use of base
            Console.WriteLine("Budget:"+base.budget+"  Price:"+price);       //First Use of base
        }
        public Titan() : base(2341)                                          //Third Use of base
        {

        }
    }
    class WatchInfo
    {
        static void Main(string[] args)
        {
            Titan t = new Titan();
            t.ShowTitan();
        }
    }
}
