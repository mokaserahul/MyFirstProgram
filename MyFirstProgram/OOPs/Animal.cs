using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Animal
    {
        public string animal_name;
        public int no_of_legs;
        public string food_type;

        static void Main(string[] args)
        {
            Animal c = new Animal();
            c.animal_name = "Lion";
            c.no_of_legs = 4;
            c.food_type = "Meat";
            Console.WriteLine("Animal Name:"+c.animal_name+" No of legs:"+c.no_of_legs+" Food Type:"+c.food_type);
           
            
            Animal a = new Animal();
            a.animal_name = "Cow";
            a.no_of_legs = 4;
            a.food_type = "Grass";
            Console.WriteLine("Animal Name:" + a.animal_name + " No of legs:" + a.no_of_legs + " Food Type:" + a.food_type);
        }
    }
}
