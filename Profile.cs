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
    public partial class Profile : Form
    {
        public string name, type;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public Profile()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.type = this.type;
            ep.name = this.name;
            ep.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            DataTable dt = DataAccess.LoadData("SELECT [Sams].[dbo].[UserDetails].*,[Sams].[dbo].[UserLogin].type FROM [Sams].[dbo].[UserDetails],[Sams].[dbo].[UserLogin] where [Sams].[dbo].[UserLogin].userID = '" + name + "' and [Sams].[dbo].[UserDetails].userID = '" + name + "'");


            namelb.Text = dt.Rows[0]["name"].ToString();
            addresslb.Text = dt.Rows[0]["address"].ToString();
            emaillb.Text = dt.Rows[0]["userID"].ToString();
            phonelb.Text = dt.Rows[0]["phone"].ToString();
            genderlb.Text = dt.Rows[0]["gender"].ToString();
            typelb.Text = dt.Rows[0]["type"].ToString();
            nidlb.Text = dt.Rows[0]["nid"].ToString();
            salarylb.Text = dt.Rows[0]["salary"].ToString();
            joindatelb.Text = dt.Rows[0]["joindate"].ToString();
            doblb.Text = dt.Rows[0]["dob"].ToString();

        }
    }
}
