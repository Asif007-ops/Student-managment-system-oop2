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
    public partial class AdminHome : Form
    {
        public string name,type;
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            Application.Exit();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Attendance at = new Attendance();
            at.type = this.type;
            at.name = this.name;
            at.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Classroom cls = new Classroom();
            cls.type = this.type;
            cls.name = this.name;
            cls.Show();
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

        private void button9_Click(object sender, EventArgs e)
        {
            StudentInfo si = new StudentInfo();
            si.type = this.type;
            si.name = this.name;
            si.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Course crs = new Course();
            crs.type = this.type;
            crs.name = this.name;
            crs.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddAttendance aa = new AddAttendance();
            aa.type = this.type;
            aa.name = this.name;
            aa.Show();
            this.Hide();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            username.Text = name;
        }

        public AdminHome()
        {
            InitializeComponent();
        }
    }
}
