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
    public partial class Login : Form
    {
        public string type;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public Login()
        {
            InitializeComponent();
        }

        

        private void forgotbtn_Click(object sender, EventArgs e)
        {
            ForgotPass f = new ForgotPass();
            f.Show();
            this.Hide();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            DataTable table1 = DataAccess.LoadData("select * from [Sams].[dbo].[UserLogin] where userID = '" + UserIdTextBox.Text + "' AND password = '" + PasswordTextBox.Text + "'");


            if (table1.Rows.Count != 1)
            {

                MessageBox.Show("wrong user Id or Password");



                UserIdTextBox.Clear();
                PasswordTextBox.Clear();
                return;


            }


            type = table1.Rows[0]["type"].ToString();


            if (type == "Admin")
            {
                AdminHome A = new AdminHome();
                A.name = UserIdTextBox.Text;
                A.type = this.type;
                A.Show();
                this.Hide();

            }

           

            else if (type == "Student")
            {
                Student S = new Student();
                S.name = UserIdTextBox.Text;
                S.type = this.type;
                S.Show();
                this.Hide();
            }
        }

        private void forgotbtn_Click_1(object sender, EventArgs e)
        {
            ForgotPass f = new ForgotPass();
            f.Show();
            this.Hide();
        }
    }
}
