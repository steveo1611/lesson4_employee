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
            Console.WriteLine("Please select which item you need to edit:");
            Console.WriteLine("1: Employee's ID is: " + Id);
            Console.WriteLine("2: Employee's name: " + Name);
            Console.WriteLine("3: Employee's Technology is: " + Technology);
            var editItem = Console.ReadLine();

            int.TryParse(editItem, out int intItem);
            if (intItem == 1)
            {
                Console.WriteLine("Employee's current ID is: " + Id);
                Console.WriteLine("Change ID to:");
                Id = Convert.ToInt32(Console.ReadLine());
            }
            else if (intItem == 2)
            {
                Console.WriteLine("Employee's current Name is: " + Name);
                Console.WriteLine("Change Name to:");
                Name = Console.ReadLine();
            }
            else if (intItem == 3)
            {
                Console.WriteLine("Employee's current Technology is: " + Technology);
                Console.WriteLine("Change Technology to:");
                Technology = Console.ReadLine();
            }
            else if (intItem == 0)
            {
                Console.WriteLine("That is not a valid option");
                EditEmployeeInfo();
            }

        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Display the Employee Info");
            Console.WriteLine("Employee's ID is: " + Id);
            Console.WriteLine("Employee's name: " + Name);
            Console.WriteLine("Employee's Technology is: " + Technology);
            Console.ReadKey();
        }

        public void DeleteEmployeeInfo()
        {
            Console.WriteLine("Delete Employee Info");
            Name = "";
            Technology = "";
            Id = 0;
            DisplayEmployeeInfo();
            
        }

    }
}
