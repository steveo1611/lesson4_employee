using System;
using System.Collections.Generic;
using System.Text;
using Lesson4_employee.Components;


namespace Lesson4_employee.Components
{
    public class Menu
    {
    string menuChoice = "";
            
    public void OpenMenu()
        {
        Console.WriteLine(@"    Hello!!!! Glad you have decided to blah blah blah
        What do you want to do? Please select the option below:
        1:  Add Employee Infomation:
        2:  Edit Employee Infomation:
        3:  Deleted Employee Infomation
        4:  Display Employees Infomation
        5:  Exit Application
        ");

        menuChoice = Console.ReadLine();


            // Need to take input and check if it's 1-5 then send to next step.  If not, give message back about not being a valid choice
            // can I use a case select to check for number? (is this best option???)

            switch (menuChoice)
            {
                case "1":
                    //Console.WriteLine("case1");
                    Console.Clear();
                    AddEmployeeInfo();
                    break;

                case "2":
                    Console.WriteLine("Case2");
                    break;

                case "3":
                    Console.WriteLine("case3");
                    break;

                case "4":
                    Console.WriteLine("Case4");
                    break;

                case "5":
                    Console.WriteLine("case5");
                    break;

                default:
                    Console.WriteLine("the end");
                    break;
            }
  //      Console.WriteLine(menuChoice);
            Console.ReadLine();

        }
        public void AddEmployeeInfo()
        {
            Console.WriteLine("Hello, please enter the Employee's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, please enter the Employee's technology:");
            string tech = Console.ReadLine();
            Employee employee = new Employee(name, tech);
            Console.Clear();
            Console.WriteLine("Employee's ID is: " + employee.Id);
            Console.WriteLine("Employee's name: " + employee.Name);
            Console.WriteLine("Employee's Technology is: " + employee.Technology);

            Console.WriteLine("Please type any key to go back to menu");
            Console.ReadKey();
            OpenMenu();

        }
    }
}
