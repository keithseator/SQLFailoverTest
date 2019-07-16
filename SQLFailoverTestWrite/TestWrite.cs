using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace SQLFailoverTestWrite
{
    public partial class TestWrite : Form
    { 

        //List<DateTimeClass> listOFDates = new List <DateTimeClass>();
        Timer t = new Timer(1000);
        

        public TestWrite()
        {
            InitializeComponent();

            //DataAccess db = new DataAccess();

            //listOFDates = db.GetDates(2);

            //UpdateBinding();

        }

        private void UpdateBinding()
        {
            //latestDBWritesListBox.DataSource = listOFDates;
            //latestDBWritesListBox.DisplayMember = "TimeLog";
        }

        private void btn_InsertToDatabase_Click(object sender, EventArgs e)
        {
            //using (SqlConnection openCon = new SqlConnection("Server=localhost;Database=TestDatabase;Trusted_Connection=True"))
            //{
            //    var dateTimeNow = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss.fff");
            //    string insertDate = $"INSERT INTO TimeLogTable (Timelog) VALUES (CAST(N'{dateTimeNow}' AS DateTime))";

            //    using (SqlCommand queryInsertDate = new SqlCommand(insertDate))
            //    {
            //        queryInsertDate.Connection = openCon;

            //        try
            //        {
            //            openCon.Open();
            //            queryInsertDate.ExecuteNonQuery();
            //        }
            //        catch (SqlException)
            //        {
            //            // error here
            //        }
            //        finally
            //        {
            //            openCon.Close();
            //        }
            //    }
            //}
            //1 sec = 1000, 60 sec = 60000

            t.AutoReset = true;

            t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);

            t.Start();


        }

        private static void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)

        {
            //DataAccess db = new DataAccess();
            //db.InsertDates();
            //UpdateBinding();
            using (SqlConnection openCon = new SqlConnection("Server=localhost;Database=TestDatabase;Trusted_Connection=True"))
            {
                var dateTimeNow = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss.fff");
                string insertDate = $"INSERT INTO TimeLogTable (Timelog) VALUES (CAST(N'{dateTimeNow}' AS DateTime))";
                string readDates = "SELECT TOP 10 * FROM TimeLogTable ORDER BY TimeLog DESC";

                using (SqlCommand queryInsertDate = new SqlCommand(insertDate))
                {
                    queryInsertDate.Connection = openCon;

                    try
                    {
                        openCon.Open();
                        queryInsertDate.ExecuteNonQuery();
                    }
                    catch (SqlException)
                    {
                        // error here
                    }
                    finally
                    {
                        openCon.Close();
                    }
                }
            }
        }

        private void btnStopInsert_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void btnFillTextBox_Click(object sender, EventArgs e)
        {
            var connString = "Server=localhost;Database=TestDatabase;Trusted_Connection=True";

            latestDBWritesListBox.Items.Clear();

            using (var conn = new SqlConnection(connString))
            {
                var cmd = new SqlCommand("SELECT TOP 10 * FROM TimeLogTable ORDER BY TimeLog DESC", conn);
                conn.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //MessageBox.Show(reader[0].ToString());
                        latestDBWritesListBox.Items.Add(reader[0].ToString());
                    }
                }
                    //var dt = (DateTime)cmd.ExecuteScalar();
                    //List<DateTime> dt = (DateTime)cmd.ExecuteQuery();
                //MessageBox.Show(dt.ToString());
            }





            //using (SqlConnection c = new SqlConnection(connString))
            //{
            //    c.Open();

            //    //use a SqlAdapter to execute the query
            //    using (SqlDataAdapter a = new SqlDataAdapter("SELECT * FROM TimeLogTable", c))
            //    {
            //        // fill a data table
            //        var t = new DataTable();
            //        //t.Columns.Add("TimeLog", typeof(DateTime));
            //        a.Fill(t);

            //        // Bind the table to the list box
            //        latestDBWritesListBox.DisplayMember = "TimeLog";
            //        latestDBWritesListBox.ValueMember = "TimeLog";
            //        latestDBWritesListBox.DataSource = t;
            //    }




            //}




            //using (SqlConnection openCon = new SqlConnection("Server=localhost;Database=TestDatabase;Trusted_Connection=True"))
            //{
            //    string rertieveDate = $"SELECT * FROM TimeLogTable";

            //    using (SqlCommand queryRetrieveDate = new SqlCommand(rertieveDate))
            //    {
            //        queryRetrieveDate.Connection = openCon;

            //        try
            //        {
            //            openCon.Open();
            //            List<DateTime> balls = new List<DateTime>;
            //            balls = queryRetrieveDate.ExecuteNonQuery().;
            //            MessageBox.Show(someshit.ToString());
            //        }
            //        catch (SqlException)
            //        {
            //            error here
            //        }
            //        finally
            //        {
            //            openCon.Close();
            //        }
            //    }
            //}
        }
    }
}
