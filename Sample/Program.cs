using Sample.Model;
using Sample.Service.Implement;
using Sample.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample
{
    class Program
    {
        private IEmployeeService EmployeeService = new EmployeeService();
        static void Main(string[] args)
        {
            //Employee employee = EmployeeService.GetEmployee("1");

            //IEnumerable<Employee> employees = EmployeeService.GetEmployees();
        }
    }
}
