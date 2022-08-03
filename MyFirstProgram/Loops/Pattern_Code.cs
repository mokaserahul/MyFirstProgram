using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class Pattern_Code
    {
        static void Main(string[] args)
        {                                                   //OUTPUT
            for(int i=1;i<=4;i++)                           //****
            {                                               //****
                for(int j=1;j<=4;j++)                       //****
                {                                           //****
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n***************\n***************\n");
            for (int i = 1; i <= 4; i++)                    //OUTPUT
            {                                               //****
                for (int j = 4; j >= i; j--)                //***
                {                                           //**
                    Console.Write("*");                     //*
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n***************\n***************\n");
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k >= i; k--)                //OUTPUT
                {                                           //   *
                    Console.Write(" ");                     //  * *
                }                                           // * * *
                for (int j = 1; j <= i; j++)                //* * * *
                {                                           // * * *
                    Console.Write("* ");                    //  * *
                }                                           //   *

                Console.WriteLine();
            }
            for (int m = 1; m <= 3; m++)
            {
                for (int n = 1; n <= m; n++)
                {
                    Console.Write(" ");
                }
                for (int l = 3; l >= m; l--)
                {
                    Console.Write(" *");
                }

                Console.WriteLine();
            }
            Console.WriteLine("\n***************\n***************\n");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {                                               //OUTPUT
                    Console.Write(i);                           //1
                }                                               //22
                Console.WriteLine();                            //333
            }                                                   //4444
            Console.WriteLine("\n***************\n***************\n");
            for (int i = 1; i <= 4; i++)                        //OUTPUT
            {                                                   //1
                for (int j = 1; j <= i; j++)                    //12
                {                                               //123
                    Console.Write(j);                           //1234
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n***************\n***************\n");
            for (int i = 1; i <= 4; i++)
            {
                for (int k = 1; k <= i; k++)                    //OUTPUT
                {                                               //4 3 2 1
                    Console.Write(" ");                         // 4 3 2
                }                                               //  4 3
                for (int j = 4; j >= i; j--)                    //   4
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n***************\n***************\n");
            for (int i = 4; i >= 1; i--)
            {
                for (int k = 1; k <= 4 - i; k++)                //OUTPUT
                {                                               //1 2 3 4
                    Console.Write(" ");                         // 1 2 3
                }                                               //  1 2
                for (int j = 1; j <= i; j++)                    //   1
                {
                    Console.Write(" " + j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n***************\n***************\n");
            for (int i = 4; i >= 1; i--)
            {
                                                                //OUTPUT
                for (int j = 1; j <= i; j++)                    //1234
                {                                               //123
                    Console.Write(j);                           //12
                }                                               //1
                Console.WriteLine();
            }
            Console.WriteLine("\n***************\n***************\n");
            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char k = 'A'; k <='D'; k++)                //OUTPUT
                {                                               //A B C D
                    Console.Write(" ");                         // A B C
                }                                               //  A B
                for (char j = 'A'; j <= i; j++)                 //   A
                {
                    Console.Write(" "+j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n***************\n***************\n");
            
            for(int i=1;i<=4;i++)
            {
                if(i%2!=0)                              //OUTPUT
                {                                       //A
                    int c = 1;                          //12
                    for(char j='A';c<=i;j++)            //ABC
                    {                                   //1234
                        Console.Write(j);
                        c++;
                    }
                }
                else
                {
                    for(int j=1;j<=i;j++)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
        }
        
    }
}
