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


        //private Employee(string name, string technology)
        public Employee()
        {
            Id++;
            Name = name;
            Technology = technology;
        }
        public void AddEmployeeInfo()
        {
            Console.WriteLine("Hello, please enter the Employee's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, please enter the Employee's technology:");
            string technology = Console.ReadLine();
            //          Employee employee = new Employee(name, tech);
            Console.ReadKey();

        }

    }
}
