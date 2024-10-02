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
    public partial class ForgotPass : Form
    {
        private string userID, qsn, ans;

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable table1 = DataAccess.LoadData("select * from [Sams].[dbo].[UserLogin] where userID = '" + UserIdTextBox.Text + "'");




            if (table1.Rows.Count != 1)
            {
                MessageBox.Show("ID NOT FOUND");
            }
            else
            {
                userID = table1.Rows[0]["userID"].ToString();
                fUid.Text = userID;

                qsn = table1.Rows[0]["qsn"].ToString();
                ans = table1.Rows[0]["ans"].ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (qsn == comboBox1.SelectedItem.ToString() && ans == txtans.Text)

                {
                    if (txtpass.Text != "" && txtcpass.Text != "")
                    {
                        if (txtpass.Text == txtcpass.Text)
                        {
                            string query = "";

                            query = " update [Sams].[dbo].[UserLogin] set password = '" + txtpass.Text + "' where [Sams].[dbo].[UserLogin].userID = '" + fUid.Text + "'";

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
                            MessageBox.Show("Password didn't match");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Left something blank");
                    }
                }
                else
                {
                    MessageBox.Show("Question or Answer didn't match");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Question is missing");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }
        public ForgotPass()
        {
            InitializeComponent();
        }

        
    }
}
