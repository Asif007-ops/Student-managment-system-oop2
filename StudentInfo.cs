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
    public partial class StudentInfo : Form
    {
        public string name, type;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            ldBtn.PerformClick();
        }

        private void ldBtn_Click(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT * from [Sams].[dbo].[UserDetails]");

            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            dataGridView1.ClearSelection();
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string query;

            if (!string.IsNullOrEmpty(searchtxt.Text))
            {
                query = " SELECT * from [Sams].[dbo].[UserDetails] where userID like '%" + searchtxt.Text + "%'";

                DataTable dt = DataAccess.LoadData(query);

                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();
                dataGridView1.ClearSelection();
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Please Select A Row First");
                return;
            }

            int row = DataAccess.ExecuteQuery("delete from [Sams].[dbo].[UserDetails] where [Sams].[dbo].[UserDetails].id='" + txtID.Text + "'");
            if (row > 0)
            {
                MessageBox.Show("Deleted");
                ldBtn.PerformClick();



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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (nametxt.Text != "" && addtxt.Text != "" && phonetxt.Text != "" && gentxt.SelectedItem.ToString() != "" && nidtxt.Text != "" && uidtxt.Text != "" && typetxt.SelectedItem.ToString() != "" && passtxt.Text != "" && cpasstxt.Text != "" && qsntxt.SelectedItem.ToString() != "" && anstxt.Text != "")
                {
                    if (passtxt.Text == cpasstxt.Text)
                    {
                        string query;
                        query = "insert into [Sams].[dbo].[UserDetails](name,address,phone,gender,nid,joindate,dob,userID) values('" + nametxt.Text + "','" + addtxt.Text + "','" + phonetxt.Text + "','" + gentxt.SelectedItem + "','" + nidtxt.Text + "','" + dateTimePicker1.Value + "','" + dateTimePicker2.Value + "','" + uidtxt.Text + "')";


                        int row = DataAccess.ExecuteQuery(query);


                        //login access
                        string query1;
                        query1 = "insert into [Sams].[dbo].[UserLogin](userID,password,type,qsn,ans) values('" + uidtxt.Text + "','" + passtxt.Text + "','" + typetxt.SelectedItem + "','" + qsntxt.SelectedItem + "','" + anstxt.Text + "')";


                        int row1 = DataAccess.ExecuteQuery1(query1);

                        if ((row > 0) && (row1 > 0))
                        {
                            MessageBox.Show("Operation Completed");

                            ldBtn.PerformClick();
                        }
                    }
                    else
                        MessageBox.Show("Password did not match");
                }
                else
                    MessageBox.Show("You left something blank");
            }
            catch (Exception)
            {

                MessageBox.Show("You left something blank");
            }
        }

        public StudentInfo()
        {
            InitializeComponent();
        }

        
    }
}
