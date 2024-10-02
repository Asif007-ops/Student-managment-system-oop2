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
    public partial class ChangePass : Form
    {
        public string name, type;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void ChangePass_Load(object sender, EventArgs e)
        {
            UserIdTextBox.Text = name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table1 = DataAccess.LoadData("select * from [Sams].[dbo].[UserLogin] where userID = '" + UserIdTextBox.Text + "'");
            string pass = table1.Rows[0]["password"].ToString();

            if (passtxt.Text != "" && cpasstxt.Text != "")
            {
                if (pass == oldpasstxt.Text)
                {
                    if (passtxt.Text == cpasstxt.Text)
                    {
                        string query = "";

                        query = " update [Sams].[dbo].[UserLogin] set password = '" + passtxt.Text + "' where [Sams].[dbo].[UserLogin].userID = '" + UserIdTextBox.Text + "'";

                        int row = DataAccess.ExecuteQuery(query);
                        if (row > 0)
                        {
                            MessageBox.Show("Operation Completed");
                            Login l = new Login();
                            l.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password did not match");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Old Password");
                }
            }
            else
            {
                MessageBox.Show("You left something blank");
            }
        }

        public ChangePass()
        {
            InitializeComponent();
        }
    }
}
