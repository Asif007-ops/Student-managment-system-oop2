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
    public partial class Student : Form
    {
        public string name, type;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }

        private void Student_Load(object sender, EventArgs e)
        {
            username.Text = name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Attendance at = new Attendance();
            at.type = this.type;
            at.name = this.name;
            at.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddComplain ac = new AddComplain();
            ac.type = this.type;
            ac.name = this.name;
            ac.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Profile pr = new Profile();
            pr.type = this.type;
            pr.name = this.name;
            pr.Show();
            this.Hide();
        }

        public Student()
        {
            InitializeComponent();
        }
        

      
    }
}
