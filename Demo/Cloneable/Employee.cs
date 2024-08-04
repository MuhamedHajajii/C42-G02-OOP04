using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Cloneable
{
    internal class Employee : ICloneable
    {
        public int Id { get; set; }

        //public StringBuilder? Name { get; set;}
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        // Copy Constructor
        public Employee(Employee employee)
        {
            Id = employee.Id;
            Name = employee.Name;
            Salary = employee.Salary;
        }

        public Employee()
        {
            
        }

        public object Clone()
        {
            return new Employee(this);
        }


        public override string ToString()
        {
            return $"Id = {Id} , Name = {Name} , Salary = {Salary}";
        }

    }
}
