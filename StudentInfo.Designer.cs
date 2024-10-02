namespace SMS
{
    partial class StudentInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.delBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.typetxt = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.uidtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.nidtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gentxt = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phonetxt = new System.Windows.Forms.TextBox();
            this.addtxt = new System.Windows.Forms.TextBox();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.ldBtn = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.searchtxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.anstxt = new System.Windows.Forms.TextBox();
            this.qsntxt = new System.Windows.Forms.ComboBox();
            this.cpasstxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(1041, 20);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(123, 49);
            this.delBtn.TabIndex = 234;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(730, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 20);
            this.label4.TabIndex = 233;
            this.label4.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(803, 36);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(209, 26);
            this.txtID.TabIndex = 232;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(1114, 487);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(319, 20);
            this.dateTimePicker2.TabIndex = 231;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(920, 488);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 20);
            this.label18.TabIndex = 230;
            this.label18.Text = "Join Date";
            // 
            // typetxt
            // 
            this.typetxt.FormattingEnabled = true;
            this.typetxt.Items.AddRange(new object[] {
            "Student"});
            this.typetxt.Location = new System.Drawing.Point(1114, 582);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(319, 21);
            this.typetxt.TabIndex = 229;
            this.typetxt.Text = "Give a Type";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(920, 580);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 20);
            this.label13.TabIndex = 228;
            this.label13.Text = "Type";
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(1114, 626);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '*';
            this.passtxt.Size = new System.Drawing.Size(319, 20);
            this.passtxt.TabIndex = 227;
            // 
            // uidtxt
            // 
            this.uidtxt.Location = new System.Drawing.Point(1114, 539);
            this.uidtxt.Name = "uidtxt";
            this.uidtxt.Size = new System.Drawing.Size(319, 20);
            this.uidtxt.TabIndex = 226;
            this.uidtxt.Text = "User ID";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(920, 626);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 20);
            this.label14.TabIndex = 225;
            this.label14.Text = "Password";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(920, 539);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 20);
            this.label15.TabIndex = 224;
            this.label15.Text = "User ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(1114, 441);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(319, 20);
            this.dateTimePicker1.TabIndex = 223;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(920, 442);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 222;
            this.label10.Text = "Join Date";
            // 
            // nidtxt
            // 
            this.nidtxt.Location = new System.Drawing.Point(1114, 383);
            this.nidtxt.Name = "nidtxt";
            this.nidtxt.Size = new System.Drawing.Size(319, 20);
            this.nidtxt.TabIndex = 221;
            this.nidtxt.Text = "Valid NID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(920, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 20);
            this.label8.TabIndex = 220;
            this.label8.Text = "NID";
            // 
            // gentxt
            // 
            this.gentxt.FormattingEnabled = true;
            this.gentxt.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.gentxt.Location = new System.Drawing.Point(1114, 337);
            this.gentxt.Name = "gentxt";
            this.gentxt.Size = new System.Drawing.Size(319, 21);
            this.gentxt.TabIndex = 219;
            this.gentxt.Text = "Select Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(920, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 218;
            this.label6.Text = "Gender";
            // 
            // phonetxt
            // 
            this.phonetxt.Location = new System.Drawing.Point(1114, 292);
            this.phonetxt.Name = "phonetxt";
            this.phonetxt.Size = new System.Drawing.Size(319, 20);
            this.phonetxt.TabIndex = 217;
            this.phonetxt.Text = "Phone Number";
            // 
            // addtxt
            // 
            this.addtxt.Location = new System.Drawing.Point(1114, 254);
            this.addtxt.Name = "addtxt";
            this.addtxt.Size = new System.Drawing.Size(319, 20);
            this.addtxt.TabIndex = 216;
            this.addtxt.Text = "Address";
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(1114, 215);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(319, 20);
            this.nametxt.TabIndex = 215;
            this.nametxt.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(920, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 214;
            this.label3.Text = "Phone";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(920, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 20);
            this.label16.TabIndex = 213;
            this.label16.Text = "Address";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(920, 215);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(51, 20);
            this.label17.TabIndex = 212;
            this.label17.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1074, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 24);
            this.label5.TabIndex = 211;
            this.label5.Text = "ADD STUDENT";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(1330, 20);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(117, 43);
            this.btnHome.TabIndex = 210;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // ldBtn
            // 
            this.ldBtn.Location = new System.Drawing.Point(22, 20);
            this.ldBtn.Name = "ldBtn";
            this.ldBtn.Size = new System.Drawing.Size(137, 52);
            this.ldBtn.TabIndex = 209;
            this.ldBtn.Text = "Load";
            this.ldBtn.UseVisualStyleBackColor = true;
            this.ldBtn.Click += new System.EventHandler(this.ldBtn_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.Location = new System.Drawing.Point(354, 105);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(141, 34);
            this.searchbtn.TabIndex = 208;
            this.searchbtn.Text = "Search";
            this.searchbtn.UseVisualStyleBackColor = true;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // searchtxt
            // 
            this.searchtxt.Location = new System.Drawing.Point(53, 113);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(270, 20);
            this.searchtxt.TabIndex = 207;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(787, 549);
            this.dataGridView1.TabIndex = 206;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(920, 768);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 241;
            this.label7.Text = "Answer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(920, 718);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 240;
            this.label1.Text = "Security Question";
            // 
            // anstxt
            // 
            this.anstxt.Location = new System.Drawing.Point(1114, 768);
            this.anstxt.Name = "anstxt";
            this.anstxt.Size = new System.Drawing.Size(319, 20);
            this.anstxt.TabIndex = 239;
            this.anstxt.Text = "Remember Your Answer";
            // 
            // qsntxt
            // 
            this.qsntxt.FormattingEnabled = true;
            this.qsntxt.Items.AddRange(new object[] {
            "Where did you born?",
            "Who was your first school friend?",
            "What was your favorite place?",
            "What is your favorite video game?",
            "Which city did your parents first meet?"});
            this.qsntxt.Location = new System.Drawing.Point(1114, 717);
            this.qsntxt.Name = "qsntxt";
            this.qsntxt.Size = new System.Drawing.Size(319, 21);
            this.qsntxt.TabIndex = 238;
            this.qsntxt.Text = "Select a Question";
            // 
            // cpasstxt
            // 
            this.cpasstxt.Location = new System.Drawing.Point(1114, 668);
            this.cpasstxt.Name = "cpasstxt";
            this.cpasstxt.PasswordChar = '*';
            this.cpasstxt.Size = new System.Drawing.Size(319, 20);
            this.cpasstxt.TabIndex = 237;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(920, 668);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 236;
            this.label2.Text = "Confirm Password";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1032, 861);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(288, 54);
            this.btnAdd.TabIndex = 235;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // StudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 968);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anstxt);
            this.Controls.Add(this.qsntxt);
            this.Controls.Add(this.cpasstxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.typetxt);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.uidtxt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nidtxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gentxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phonetxt);
            this.Controls.Add(this.addtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.ldBtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentInfo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.StudentInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox typetxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox uidtxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox nidtxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox gentxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phonetxt;
        private System.Windows.Forms.TextBox addtxt;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button ldBtn;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox anstxt;
        private System.Windows.Forms.ComboBox qsntxt;
        private System.Windows.Forms.TextBox cpasstxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
    }
}