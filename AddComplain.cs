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
    public partial class AddComplain : Form
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

        private void ldBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT * from [Sams].[dbo].[Complain]");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtName.Text != "" && txtReport.Text != "")
            {
                string query;
                query = "insert into [Sams].[dbo].[Complain](uid,name,report,date) values('" + txtID.Text + "','" + txtName.Text + "','" + txtReport.Text + "','" + dateTimePicker1.Value + "')";


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

        private void AddComplain_Load(object sender, EventArgs e)
        {
            ldBtn.PerformClick();
        }

        public AddComplain()
        {
            InitializeComponent();
        }

        
    }
}
