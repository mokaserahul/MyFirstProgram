using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class TryAccess:Student2
    {
        static void Main(string[] args)
        {
            Student2 t = new Student2();
            t.Show_Roll_no(29);
            t.Show_name("Amit");
            //t.Show_address("Pune");   Error due to private access modifier
            TryAccess a = new TryAccess();
            a.Show_marks(81.50f);
        }
    }
}
