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
        Timer t = new Timer(1000);

        public TestWrite()
        {
            InitializeComponent();
            FillTextBox();
        }

        private void btn_InsertToDatabase_Click(object sender, EventArgs e)
        {
            t.AutoReset = true;
            t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);
            t.Start();
        }

        private void InsertDatesIntoDatabase()
        {
            using (SqlConnection openCon = new SqlConnection(Helper.CnnVal("TestDatabase")))
            {
                var dateTimeNow = DateTime.Now.ToString("yyyy'-'MM'-'dd' 'HH':'mm':'ss.fff");
                string insertDate = $"INSERT INTO TimeLogTable (Timelog) VALUES (CAST(N'{dateTimeNow}' AS DateTime))";

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

        private void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            InsertDatesIntoDatabase();
        }

        private void btnStopInsert_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void btnFillTextBox_Click(object sender, EventArgs e)
        {
            FillTextBox();
        }

        private void FillTextBox()
        {
            latestDBWritesListBox.Items.Clear();

            using (var conn = new SqlConnection(Helper.CnnVal("TestDatabase")))
            {
                var cmd = new SqlCommand("SELECT TOP 17 * FROM TimeLogTable ORDER BY TimeLog DESC", conn);
                try
                {
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            latestDBWritesListBox.Items.Add(reader[0].ToString());
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void btnClearTimes_Click(object sender, EventArgs e)
        {
            latestDBWritesListBox.Items.Clear();

            using (var conn = new SqlConnection(Helper.CnnVal("TestDatabase")))
            {
                var cmd = new SqlCommand("DELETE FROM TimeLogTable", conn);
                try
                {
                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
                catch
                {

                }
            }
        }

        private void btnDoNotPress_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I said don't fucking press it!!!");
        }
    }
}
