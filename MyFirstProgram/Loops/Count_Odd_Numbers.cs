using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class Count_Odd_Numbers
    {
        static void Main(string[] args)
        {
            int count = 0;
            for(int i=1;i<=10;i++)
            {
                if(i%2==1)
                {
                    count++;
                }
            }
            Console.WriteLine("odd count="+ count);
        }
    }
}
