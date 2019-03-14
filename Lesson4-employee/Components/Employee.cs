using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4_employee.Components
{
    class Employee
    {
    public int Id { get; set; }
    public String Name { get; set; }
    public String Technology { get; set; }


        public Employee(string name, string technology)
        {
            Id++;
            Name = name;
            Technology = technology;
        }
/*
        public string EmployeeAdd()
        {

            Console.WriteLine("case1");
        }
        public string EmployeeEdit()
        {
            Console.WriteLine("Case2");

        }
        public string EmployeeDelete()
        {
            Console.WriteLine("case3");

        }
        public string EmployeeList()
        {
            Console.WriteLine("Case4");
        }
*/

    }
}
