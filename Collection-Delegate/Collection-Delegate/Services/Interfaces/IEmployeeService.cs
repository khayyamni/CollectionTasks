using Collection_Delegate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Delegate.Services.Interfaces
{
    internal interface IEmployeeService
    {
        List<Employee> GetAll();
        List<Employee> FilterBySalary(decimal firstSalary, decimal secondSalary, List<Employee> employees);
    }
}
