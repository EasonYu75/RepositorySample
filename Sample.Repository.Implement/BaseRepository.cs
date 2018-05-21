using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Sample.Repository.Implement
{
    public abstract class BaseRepository
    {
        private string ConnectionString { get; set; }

        public BaseRepository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public IEnumerable<T> Query<T>(string sql, DynamicParameters parameters)
        {
            IEnumerable<T> result;

            using (IDbConnection db = new SqlConnection(this.ConnectionString))
            {
                result = db.Query<T>(sql, parameters).ToList();
            }

            return result;
        }
    }
}
