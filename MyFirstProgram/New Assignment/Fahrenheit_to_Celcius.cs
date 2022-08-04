using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.New_Assignment
{
    class Fahrenheit_to_Celcius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Fahrenheit");
            float f = float.Parse(Console.ReadLine());
            float c = (f - 32) * 5 / 9;
            Console.WriteLine("Temperature in Degree Celcius:"+c);
        }
    }
}
