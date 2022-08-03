using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Loops
{
    class PatternTask
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of rows:");
            int n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                   if(i==1 || j==1 || i==n || j==n)
                    { 
                        Console.Write("*");
                    }
                   else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n****************\n****************\n");
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if (j==1|| i==n || j==i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n******************\n******************\n");
            for (int i=1;i<=n;i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    if(i==(n/2)+1||j==(n/2)+1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n******************\n******************\n");
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write('0');
                    }
                    else
                    {
                        Console.Write('1');
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n******************\n******************\n");
            /*for(char i='D';i>='A';i--)
            {
                for(char j='A'; j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }*/
            for(int i=n;i>=1;i--)
            {
                int c = 1;
                for(char j='A';c<=i;j++)
                {
                    Console.Write(j);
                    c++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n******************\n******************\n");
            for(int i=n;i>=1;i--)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n******************\n******************\n");
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=n;j++)
                {
                    if(j==1||j==n||j==i)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n******************\n******************\n");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    int c = 1;
                    for (char j = 'A'; c <= i; j++)
                    {
                        Console.Write(j);
                        c++;
                    }
                }
                else
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(j);
                    }
                }
                Console.WriteLine();
            }
        }

    }
}
