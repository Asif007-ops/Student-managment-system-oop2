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
    public partial class Classroom : Form
    {
        public string name, type;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void ldBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT * from [Sams].[dbo].[Classroom]");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string query;

            if (!string.IsNullOrEmpty(searchtxt.Text))
            {
                query = " SELECT * from [Sams].[dbo].[Classroom] where class_code like '%" + searchtxt.Text + "%'";

                DataTable dt = DataAccess.LoadData(query);

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();
            }
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

                query = " update [Sams].[dbo].[Classroom] set class_code = '" + txtclsCode.Text + "',course_code = '" + txtcrsCode.Text + "',standard = '" + txtStandard.Text + "',s_id = '" + txtsID.Text + "',s_name = '" + txtsName.Text + "',t_name = '" + txttName.Text + "',section = '" + txtSec.Text + "' where [Sams].[dbo].[Classroom].id = '" + txtID.Text + "'";

                int row = DataAccess.ExecuteQuery(query);
                if (row > 0)
                {
                    MessageBox.Show("Operation Completed");
                    txtID.Text = "";
                    txtclsCode.Text = "";
                    txtcrsCode.Text = "";
                    txtStandard.Text = "";
                    txtsID.Text = "";
                    txtsName.Text = "";
                    txttName.Text = "";
                    txtSec.Text = "";
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
            if (txtclsCode.Text != "" && txtcrsCode.Text != "" && txtStandard.Text != "" && txtsID.Text != "" && txtsName.Text != "" && txttName.Text != "" && txtSec.Text != "")
            {
                string query;
                query = "insert into [Sams].[dbo].[Classroom](class_code,course_code,standard, s_id, s_name, t_name, section) values('" + txtclsCode.Text + "','" + txtcrsCode.Text + "','" + txtStandard.Text + "','" + txtsID.Text + "','" + txtsName.Text + "','" + txttName.Text + "','" + txtSec.Text + "')";


                int row = DataAccess.ExecuteQuery(query);
                if (row > 0)
                {
                    MessageBox.Show("Operation Completed");
                    txtID.Text = "";
                    txtclsCode.Text = "";
                    txtcrsCode.Text = "";
                    txtStandard.Text = "";
                    txtsID.Text = "";
                    txtsName.Text = "";
                    txttName.Text = "";
                    txtSec.Text = "";
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

            int row = DataAccess.ExecuteQuery("delete from [Sams].[dbo].[Classroom] where [Sams].[dbo].[Classroom].id='" + txtID.Text + "'");
            if (row > 0)
            {
                MessageBox.Show("Deleted");
                ldBtn.PerformClick();

                txtID.Text = "";
                txtclsCode.Text = "";
                txtcrsCode.Text = "";
                txtStandard.Text = "";
                txtsID.Text = "";
                txtsName.Text = "";
                txttName.Text = "";
                txtSec.Text = "";

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            txtID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtclsCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtcrsCode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtStandard.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtsID.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtsName.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txttName.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtSec.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        public Classroom()
        {
            InitializeComponent();
        }

        
    }
}
