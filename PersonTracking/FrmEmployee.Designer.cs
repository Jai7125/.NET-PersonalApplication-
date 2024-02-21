namespace PersonTracking
{
    partial class FrmEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Txtpassword = new System.Windows.Forms.Label();
            this.txtcheck = new System.Windows.Forms.Button();
            this.IsAdmin = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Imagepath = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtBrowse = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClose = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.IsAdmin);
            this.panel1.Controls.Add(this.txtcheck);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Txtpassword);
            this.panel1.Controls.Add(this.txtUserNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 166);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(231, 229);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "userNo";
            // 
            // txtUserNo
            // 
            this.txtUserNo.Location = new System.Drawing.Point(80, 26);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(90, 22);
            this.txtUserNo.TabIndex = 1;
            this.txtUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserNo_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(373, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 22);
            this.textBox1.TabIndex = 4;
            // 
            // Txtpassword
            // 
            this.Txtpassword.AutoSize = true;
            this.Txtpassword.Location = new System.Drawing.Point(300, 29);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Size = new System.Drawing.Size(67, 16);
            this.Txtpassword.TabIndex = 3;
            this.Txtpassword.Text = "Password";
            // 
            // txtcheck
            // 
            this.txtcheck.Location = new System.Drawing.Point(176, 23);
            this.txtcheck.Name = "txtcheck";
            this.txtcheck.Size = new System.Drawing.Size(95, 29);
            this.txtcheck.TabIndex = 2;
            this.txtcheck.Text = "Check";
            this.txtcheck.UseVisualStyleBackColor = true;
            // 
            // IsAdmin
            // 
            this.IsAdmin.AutoSize = true;
            this.IsAdmin.Location = new System.Drawing.Point(495, 25);
            this.IsAdmin.Name = "IsAdmin";
            this.IsAdmin.Size = new System.Drawing.Size(90, 20);
            this.IsAdmin.TabIndex = 5;
            this.IsAdmin.Text = "Is Admin ?";
            this.IsAdmin.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 184);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 22);
            this.textBox2.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(24, 187);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(44, 16);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 215);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 22);
            this.textBox3.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.AutoSize = true;
            this.txtSurname.Location = new System.Drawing.Point(24, 218);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(61, 16);
            this.txtSurname.TabIndex = 2;
            this.txtSurname.Text = "Surname";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 243);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(90, 22);
            this.textBox4.TabIndex = 5;
            // 
            // Imagepath
            // 
            this.Imagepath.AutoSize = true;
            this.Imagepath.Location = new System.Drawing.Point(24, 246);
            this.Imagepath.Name = "Imagepath";
            this.Imagepath.Size = new System.Drawing.Size(71, 16);
            this.Imagepath.TabIndex = 4;
            this.Imagepath.Text = "Imagepath";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(359, 172);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 217);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtBrowse
            // 
            this.txtBrowse.Location = new System.Drawing.Point(231, 225);
            this.txtBrowse.Name = "txtBrowse";
            this.txtBrowse.Size = new System.Drawing.Size(95, 37);
            this.txtBrowse.TabIndex = 6;
            this.txtBrowse.Text = "Browse";
            this.txtBrowse.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(97, 279);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(90, 22);
            this.textBox5.TabIndex = 8;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // txtSalary
            // 
            this.txtSalary.AutoSize = true;
            this.txtSalary.Location = new System.Drawing.Point(22, 279);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(46, 16);
            this.txtSalary.TabIndex = 7;
            this.txtSalary.Text = "Salary";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(97, 336);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(90, 22);
            this.txtPosition.TabIndex = 12;
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(15, 342);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(55, 16);
            this.Position.TabIndex = 11;
            this.Position.Text = "Position";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(97, 308);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(90, 22);
            this.txtDepartment.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dep";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(97, 364);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(90, 22);
            this.textBox7.TabIndex = 29;
            // 
            // txtBirthday
            // 
            this.txtBirthday.AutoSize = true;
            this.txtBirthday.Location = new System.Drawing.Point(29, 367);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(56, 16);
            this.txtBirthday.TabIndex = 13;
            this.txtBirthday.Text = "Birthday";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 367);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(97, 434);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(632, 134);
            this.textBox6.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Name";
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(544, 596);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(185, 61);
            this.txtClose.TabIndex = 18;
            this.txtClose.Text = "Close";
            this.txtClose.UseVisualStyleBackColor = true;
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(183, 596);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(185, 61);
            this.Save.TabIndex = 17;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 669);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtBrowse);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Imagepath);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Txtpassword;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button txtcheck;
        private System.Windows.Forms.CheckBox IsAdmin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label txtSurname;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label Imagepath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button txtBrowse;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label txtSalary;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label txtBirthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button txtClose;
        private System.Windows.Forms.Button Save;
    }
}