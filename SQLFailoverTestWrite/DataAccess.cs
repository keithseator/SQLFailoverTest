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
        public List<DateTimeClass> GetDates(int numberOfDates)
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("TestDatabase")))
            {
                var output = connection.Query<DateTimeClass>("SELECT * FROM TimeLogTable").ToList();
                return output;
            }
        }

        public void InsertDates()
        {
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("TestDatabase")))
            {
                var dateTimeNow = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss.fff");
                //System.Windows.Forms.MessageBox.Show(dateTimeNow);
                connection.Query<DateTimeClass>($"INSERT INTO TimeLogTable (Timelog) VALUES (CAST(N'{dateTimeNow}' AS DateTime))");
            }
        }
    }
}
