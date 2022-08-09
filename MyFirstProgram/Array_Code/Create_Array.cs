using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Array_Code
{
    class Create_Array
    {
        static void Main(string[] args)
        {
            float[] arr = new float[4];
            Console.WriteLine("Enter the Array Elements:");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("...........First Way...........");
            
            for(int i=0;i<arr.Length;i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\n...........Second Way..........");
            foreach(int x in arr)
            {
                Console.Write(x+" ");
            }
            Console.WriteLine("\n...........Third Way..........");
            Console.WriteLine(string.Join(" ",arr));


        }
    }
}
