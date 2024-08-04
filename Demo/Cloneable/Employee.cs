using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Cloneable
{
    internal class Employee : ICloneable,IComparable
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

        public int CompareTo(object? obj)
        {
            // return this.salary > obj.salary +Ve
            // return this.salary < obj.salary -Ve
            // return this.salary == obj.salary 0

            Employee PassEmployee = (Employee)obj!;

            if(this.Salary > PassEmployee.Salary)
                return 1;
            else if (this.Salary < PassEmployee.Salary)
                return -1;
            else return 0;

        }
    }
}
