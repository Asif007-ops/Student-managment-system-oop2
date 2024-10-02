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
    public partial class EditProfile : Form
    {
        public string name, type;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public EditProfile()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (nametxt.Text != "" && addresstxt.Text != "" && phonetxt.Text != "" && gendertxt.SelectedItem.ToString() != "" && nidtxt.Text != "" && dobtxt.Text != "")
            {
                string query = "";

                query = "  update [Sams].[dbo].[UserDetails] set name='" + nametxt.Text + "',address='" + addresstxt.Text + "',phone='" + phonetxt.Text + "',gender='" + gendertxt.SelectedItem + "',nid='" + nidtxt.Text + "', dob='" + dobtxt.Text + "' where [Sams].[dbo].[UserDetails].userID = '" + name + "'";


                int row = DataAccess.ExecuteQuery(query);
                if (row > 0)
                {
                    MessageBox.Show("Operation Completed");
                    Login lg = new Login();
                    lg.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("left something blank");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangePass cp = new ChangePass();
            cp.name = this.name;
            cp.type = this.type;
            cp.Show();
            this.Hide();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            
            if (type == "Student")
            {
                typetxt.Enabled = false;

            }

            DataTable dt = DataAccess.LoadData("SELECT [Sams].[dbo].[UserDetails].*,[Sams].[dbo].[UserLogin].type FROM [Sams].[dbo].[UserDetails],[Sams].[dbo].[UserLogin] where [Sams].[dbo].[UserLogin].userID = '" + name + "' and [Sams].[dbo].[UserDetails].userID = '" + name + "'");


            nametxt.Text = dt.Rows[0]["name"].ToString();
            addresstxt.Text = dt.Rows[0]["address"].ToString();
            emailtxt.Text = dt.Rows[0]["userID"].ToString();
            phonetxt.Text = dt.Rows[0]["phone"].ToString();
            gendertxt.Text = dt.Rows[0]["gender"].ToString();
            typetxt.Text = dt.Rows[0]["type"].ToString();
            nidtxt.Text = dt.Rows[0]["nid"].ToString();
            dobtxt.Text = dt.Rows[0]["dob"].ToString();
        }
    }
}
