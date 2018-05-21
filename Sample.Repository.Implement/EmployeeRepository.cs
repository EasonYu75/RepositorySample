using Sample.Model;
using Sample.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample.Repository.Implement
{
    public class EmployeeRepository : BaseRepository , IEmployeeRepository
    {
        private readonly string connectionString = "";
        public EmployeeRepository(string connectionString) : base(connectionString)
        {
        }

        public Employee GetEmployee(string Id)
        {
            string sql = string.Empty;

            return Query<Employee>(sql, new Dapper.DynamicParameters()).FirstOrDefault();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            string sql = string.Empty;

            return Query<Employee>(sql, new Dapper.DynamicParameters());
        }
    }
}
