using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Id, Name, Gender, Salary.
namespace Labb6
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public int salary { get; set; }

        public Employee(int id, string name, string gender, int salary)
        {
            this.id = id;
            this.name = name;
            this.gender = gender;
            this.salary = salary;
        }
    }
}