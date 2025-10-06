using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Id, Name, Gender, Salary.
namespace Labb6
{
    public class Employee(int id, string name, string gender, int salary)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Gender { get; set; } = gender;
        public int Salary { get; set; } = salary;
    }
}