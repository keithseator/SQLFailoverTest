using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

    List<DateTimeClass> listOFDates = new List <DateTimeClass>();
        Timer t = new Timer(1000);

        public TestWrite()
        {
            InitializeComponent();

            DataAccess db = new DataAccess();

            listOFDates = db.GetDates(2);

            UpdateBinding();

        }

        private void UpdateBinding()
        {
            latestDBWritesListBox.DataSource = listOFDates;
            latestDBWritesListBox.DisplayMember = "TimeLog";
        }

        private void btn_InsertToDatabase_Click(object sender, EventArgs e)
        {
             // 1 sec = 1000, 60 sec = 60000

            t.AutoReset = true;

            t.Elapsed += new System.Timers.ElapsedEventHandler(t_Elapsed);

            t.Start();


        }

        private static void t_Elapsed(object sender, System.Timers.ElapsedEventArgs e)

        {
            DataAccess db = new DataAccess();
            db.InsertDates();
            //UpdateBinding();

        }

        private void btnStopInsert_Click(object sender, EventArgs e)
        {
            t.Stop();
        }
    }
}
