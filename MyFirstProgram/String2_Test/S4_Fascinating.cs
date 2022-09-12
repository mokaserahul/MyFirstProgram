using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.String2_Test
{
    class S4_Fascinating
    {
        public static bool CheckFascinating(int n)
        {
            int[] count = new int[10];
            string result = "" + n.ToString() + (n * 2).ToString() + (n * 3).ToString();
            for(int i=0;i<result.Length;i++)
            {
                int d = result[i]-'0';
                if(count[d]!=0 && d !=0 )
                {
                    return false;
                }
                else
                {
                    count[d]++;
                }
            }
            for(int i=1;i<count.Length;i++)
            {
                if(count[i]==0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            bool res = CheckFascinating(192);
            if(res)
            {
                Console.WriteLine("Fascinating Number");
            }
            else
            {
                Console.WriteLine("Not Fascinating Number");
            }
        }
    }
}
