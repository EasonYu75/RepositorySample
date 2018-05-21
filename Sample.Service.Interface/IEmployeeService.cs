using Sample.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Service.Interface
{
    public interface IEmployeeService
    {
        Employee GetEmployee(string Id);

        IEnumerable<Employee> GetEmployees();
    }
}
