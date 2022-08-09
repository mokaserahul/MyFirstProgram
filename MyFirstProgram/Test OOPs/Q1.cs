using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.Test_OOPs
{
    class Notebook
    {
        public Notebook()
        {
            Console.WriteLine("*******Notebook*********");
        }
        public Notebook(int pages)
        {
            Console.WriteLine("Pages:"+pages);
        }
        public Notebook(int price,string type)
        {
            Console.WriteLine("Price:"+price+" Type:"+type);
        }
    }
    class NotebookInfo
    {
        static void Main(string[] args)
        {
            Notebook a = new Notebook();
            Notebook b = new Notebook(100);
            Notebook c = new Notebook(35, "Long");
        }
    }
}
