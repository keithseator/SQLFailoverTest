using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace SQLFailoverTestWrite
{
    public class DataAccess
    {
        public List<DateTime> GetDates(int numberOfDates)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("TestDatabase")))
            {
                var output = connection.Query<DateTime>($"SELECT * FROM dbo.TestTable").ToList();
                return output;
            }
        }
    }
}
