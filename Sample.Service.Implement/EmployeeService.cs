using Sample.Model;
using Sample.Repository.Implement;
using Sample.Repository.Interface;
using Sample.Service.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace Sample.Service.Implement
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository EmployeeRepository;

        public EmployeeService()
        {
            EmployeeRepository = new EmployeeRepository(ConfigurationManager.AppSettings["connectionString"]);
        }


        public Employee GetEmployee(string Id)
        {
            return EmployeeRepository.GetEmployee(Id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return EmployeeRepository.GetEmployees();
        }
    }
}