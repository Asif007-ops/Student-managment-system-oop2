using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class AddAttendance : Form
    {
        public string name, type;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (type == "Admin")
            {
                AdminHome A = new AdminHome();
                A.type = this.type;
                A.name = this.name;
                A.Show();
                this.Hide();

            }

            

            else if (type == "Student")
            {
                Student S = new Student();
                S.type = this.type;
                S.name = this.name;
                S.Show();
                this.Hide();
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string query;

            if (!string.IsNullOrEmpty(searchtxt.Text))
            {
                query = " SELECT * from [Sams].[dbo].[Attendance] where uid like '%" + searchtxt.Text + "%'";

                DataTable dt = DataAccess.LoadData(query);

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();
            }
        }

        private void ldBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT * from [Sams].[dbo].[Attendance]");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void AddAttendance_Load(object sender, EventArgs e)
        {
            ldBtn.PerformClick();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtCode.Text != "" && cboxStat.SelectedItem.ToString() != "")
            {
                string query;
                query = "insert into [Sams].[dbo].[Attendance](uid,class_code,date,status) values('" + txtID.Text + "','" + txtCode.Text + "','" + dateTimePicker1.Value + "','" + cboxStat.SelectedItem + "')";


                int row = DataAccess.ExecuteQuery(query);
                if (row > 0)
                {
                    MessageBox.Show("Operation Completed");

                    ldBtn.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("left something blank");
            }
        }

        public AddAttendance()
        {
            InitializeComponent();
        }

        
    }
}
