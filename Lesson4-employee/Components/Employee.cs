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


        public Employee(int id, string name, string technology)
        {
            Id = id;
            Name = name;
            Technology = technology;
        }
    }
}
