//  Create a console program which can add, edit, delete and read employee details.
//    - use array with 3 values and menu to select what to "pull out" of object?
//  Employee details should have 3 fields(ID, Name, Technology)
//  -create employee object that has these 3 fields as properties (could also use a noSQL db to expand out to mmultiple employees, just a write to disk)

using System;
using Lesson4_employee.Components;


namespace Lesson4_employee
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Hello Heaven!");
          Menu menu = new Menu();
            menu.OpenMenu();
             
        }

    }
}
