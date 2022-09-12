using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String2_Test
{
    class S3_Freq
    {
        public static void Freq(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {

                bool isvisited = false;
                int count = 1;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (a[i] == a[j])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine(a[i] + ":" + count);
                }
            }
        }
        static void Main(string[] args)
        {
            Freq("9503440762");
        }
    }
}
