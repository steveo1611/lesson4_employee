using System;
using System.Collections.Generic;
using System.Text;


namespace Lesson4_employee.Components
{
    public class Menu
    {
        string menuChoice = "";

        private static Employee employee = new Employee("", "");

    public void CreateUser()
        {
            Console.WriteLine(@"    Hello!!!! Please enter inital employee info");
            Console.Clear();
            employee.AddEmployeeInfo();
            OpenMenu();
        }
    public void OpenMenu()
        {
        Console.WriteLine(@"    Hello!!!! Now that you have Employee Created: 
        What do you want to do? Please select from the options below:
        1:  Edit Employee Infomation:
        2:  Display Employees Infomation
        3:  Deleted Employee Infomation
        4:  Exit Application
        ");

        menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    employee.EditEmployeeInfo();
                    OpenMenu();
                    break;

                case "2":
                    employee.DisplayEmployeeInfo();
                    OpenMenu();
                    break;

                case "3":
                    employee.DeleteEmployeeInfo();
                    break;

                case "4":
                    Console.WriteLine("Exit");
                    break;

                default:
                    Console.WriteLine("the end");
                    break;
            }
        }
    }
}
