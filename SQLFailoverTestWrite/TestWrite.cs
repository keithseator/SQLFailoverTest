using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLFailoverTestWrite
{
    public partial class TestWrite : Form
    { 

    List<DateTimeClass> listOFDates = new List <DateTimeClass>();
    
        public TestWrite()
        {
            InitializeComponent();

            UpdateBinding();

        }

        private void UpdateBinding()
        {
            latestDBWritesListBox.DataSource = listOFDates;
            latestDBWritesListBox.DisplayMember = "TimeLog";
        }

        private void btn_InsertToDatabase_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            listOFDates = db.GetDates(2);

            UpdateBinding();
        }
    }
}
