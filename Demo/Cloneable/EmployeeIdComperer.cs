using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Cloneable
{
    internal class EmployeeIdComperer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee? employeeX = x as Employee;
            Employee? employeeY = y as Employee;
            // employeeX.Id >  employeeY.Id >> +vew
            // employeeX.Id <  employeeY.Id >> -vew
            // employeeX.Id == employeeY.Id >> 0

            //if(employeeX.Id > employeeY.Id)
            //    return 1;
            //else if (employeeX.Id > employeeY.Id)
            //    return -1;
            //else if (employeeX.Id > employeeY.Id)
            //    return 0;

            return employeeX?.Id.CompareTo(employeeY?.Id) ?? (employeeY is null ? 0 : -1);


        }
    }
}
