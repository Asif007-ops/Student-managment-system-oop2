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
    public partial class Course : Form
    {
        public string name, type;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void Course_Load(object sender, EventArgs e)
        {
            ldBtn.PerformClick();
        }

        private void ldBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT * from [Sams].[dbo].[Course]");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                string query = "";

                query = " update [Sams].[dbo].[Course] set coursename = '" + txtName.Text + "',code = '" + txtCode.Text + "',prerequisite = '" + txtPre.Text + "' where [Sams].[dbo].[Course].id = '" + txtID.Text + "'";

                int row = DataAccess.ExecuteQuery(query);
                if (row > 0)
                {
                    MessageBox.Show("Operation Completed");
                    txtID.Text = "";
                    txtName.Text = "";
                    txtPre.Text = "";
                    txtCode.Text = "";
                    ldBtn.PerformClick();
                }
            }
            else
            {
                MessageBox.Show("select a row first");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtCode.Text != "" && txtPre.Text != "")
            {
                string query;
                query = "insert into [Sams].[dbo].[Course](coursename,code,prerequisite) values('" + txtName.Text + "','" + txtCode.Text + "','" + txtPre.Text + "')";


                int row = DataAccess.ExecuteQuery(query);
                if (row > 0)
                {
                    MessageBox.Show("Operation Completed");
                    txtID.Text = "";
                    txtName.Text = "";
                    txtPre.Text = "";
                    txtCode.Text = "";
                    ldBtn.PerformClick();

                }
            }
            else
            {
                MessageBox.Show("left something blank");
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }

            int row = DataAccess.ExecuteQuery("delete from [Sams].[dbo].[Course] where [Sams].[dbo].[Course].id='" + txtID.Text + "'");
            if (row > 0)
            {
                MessageBox.Show("Deleted");
                ldBtn.PerformClick();

                txtID.Text = "";
                txtName.Text = "";
                txtPre.Text = "";
                txtCode.Text = "";

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPre.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string query;

            if (!string.IsNullOrEmpty(searchtxt.Text))
            {
                query = " SELECT * from [Sams].[dbo].[Course] where coursename like '%" + searchtxt.Text + "%'";

                DataTable dt = DataAccess.LoadData(query);

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();
            }
        }

        public Course()
        {
            InitializeComponent();
        }

        
    }
}
