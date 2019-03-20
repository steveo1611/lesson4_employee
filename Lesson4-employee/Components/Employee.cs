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

        public void AddEmployeeInfo()
        {
            Console.WriteLine("Hello, please enter the Employee's name:");
            Name = Console.ReadLine();
            Console.WriteLine("Hello, please enter the Employee's technology:");
            Technology = Console.ReadLine();
            Console.WriteLine("Employee's ID is: " + Id);
            Console.WriteLine("Employee's name: " + Name);
            Console.WriteLine("Employee's Technology is: " + Technology);
            Console.WriteLine("Please type any key to go back to menu");
            Console.ReadKey();


        }
        public void EditEmployeeInfo()
        {
            Console.WriteLine("Employee's ID is: " + Id);
            Console.WriteLine("Employee's name: " + Name);
            Console.WriteLine("Employee's Technology is: " + Technology);
            Console.ReadKey();

        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Display the Employee Info");

        }

        public void DeleteEmployeeInfo()
        {
            Console.WriteLine("Delete Employee Info");

        }

    }
}
