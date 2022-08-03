using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProgram.OOPs
{
    class Department
    {
        public int dept_id;
        public string dept_name;
        public Department(int dept_id,string dept_name)
        {
            this.dept_id = dept_id;
            this.dept_name = dept_name;
        }
        public void ShowDepartment()
        {
            Console.WriteLine(dept_id+" "+dept_name);
        }
    }
    class Employee
    {
        public int id;
        public string name;
        public int sal;
        public Department dept;
        public Employee(int id,string name,int sal,Department dept)
        {
            this.id = id;
            this.name = name;
            this.sal = sal;
            this.dept = dept;
        }
        public void ShowEmployee()
        {
            Console.WriteLine(id+" "+name+" "+sal);
            dept.ShowDepartment();
        }
        static void Main(string[] args)
        {
            Department d = new Department(2361,"Accounts");
            Employee e = new Employee(1001,"Amit",45000,d);
            e.ShowEmployee();
        }
    }
}
