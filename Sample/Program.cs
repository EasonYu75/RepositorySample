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
        private static IEmployeeService EmployeeService = new EmployeeService();
        static void Main(string[] args)
        {
            //Employee employee = EmployeeService.GetEmployee("1");

            //IEnumerable<Employee> employees = EmployeeService.GetEmployees();

            string[] t = new string[96];

            for(int i = 1; i<=96; i++)
            {
                t[i - 1] = i.ToString();
            }

            Console.WriteLine(string.Join(",", t));

            Console.Read();
        }
    }
}
