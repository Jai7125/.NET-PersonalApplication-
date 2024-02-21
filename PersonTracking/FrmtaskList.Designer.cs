namespace PersonTracking
{
    partial class FrmtaskList
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
            this.txtclear = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.Button();
            this.Taskstate = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.EndDate = new System.Windows.Forms.RadioButton();
            this.StartDate = new System.Windows.Forms.RadioButton();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dpEnd = new System.Windows.Forms.Label();
            this.dpStart = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Position = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.TextBox();
            this.UserNo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IsApproved = new System.Windows.Forms.Button();
            this.txtClose = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.Button();
            this.txtNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtclear);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.Taskstate);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.EndDate);
            this.panel1.Controls.Add(this.StartDate);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.dpEnd);
            this.panel1.Controls.Add(this.dpStart);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1224, 254);
            this.panel1.TabIndex = 0;
            // 
            // txtclear
            // 
            this.txtclear.Location = new System.Drawing.Point(971, 166);
            this.txtclear.Name = "txtclear";
            this.txtclear.Size = new System.Drawing.Size(158, 43);
            this.txtclear.TabIndex = 11;
            this.txtclear.Text = "Clear";
            this.txtclear.UseVisualStyleBackColor = true;
            this.txtclear.Click += new System.EventHandler(this.txtclear_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(765, 166);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(158, 43);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Text = "Search";
            this.txtSearch.UseVisualStyleBackColor = true;
            // 
            // Taskstate
            // 
            this.Taskstate.AutoSize = true;
            this.Taskstate.Location = new System.Drawing.Point(394, 161);
            this.Taskstate.Name = "Taskstate";
            this.Taskstate.Size = new System.Drawing.Size(67, 16);
            this.Taskstate.TabIndex = 6;
            this.Taskstate.Text = "Taskstate";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(467, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Location = new System.Drawing.Point(810, 101);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(84, 20);
            this.EndDate.TabIndex = 9;
            this.EndDate.TabStop = true;
            this.EndDate.Text = "End Date";
            this.EndDate.UseVisualStyleBackColor = true;
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Location = new System.Drawing.Point(810, 63);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(87, 20);
            this.StartDate.TabIndex = 8;
            this.StartDate.TabStop = true;
            this.StartDate.Text = "Start Date";
            this.StartDate.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(467, 101);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(467, 65);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dpEnd
            // 
            this.dpEnd.AutoSize = true;
            this.dpEnd.Location = new System.Drawing.Point(397, 101);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(42, 16);
            this.dpEnd.TabIndex = 4;
            this.dpEnd.Text = "Finish";
            // 
            // dpStart
            // 
            this.dpStart.AutoSize = true;
            this.dpStart.Location = new System.Drawing.Point(397, 65);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(34, 16);
            this.dpStart.TabIndex = 2;
            this.dpStart.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taskdate";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.Position);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.Surname);
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.Name);
            this.panel3.Controls.Add(this.Department);
            this.panel3.Controls.Add(this.UserNo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 254);
            this.panel3.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(121, 163);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(218, 24);
            this.comboBox3.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(121, 122);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(218, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(42, 166);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(55, 16);
            this.Position.TabIndex = 8;
            this.Position.Text = "Position";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dep";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(121, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(42, 88);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(73, 16);
            this.Surname.TabIndex = 4;
            this.Surname.Text = "txtSurname";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(121, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 22);
            this.txtName.TabIndex = 3;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(42, 53);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(44, 16);
            this.Name.TabIndex = 2;
            this.Name.Text = "Name";
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(121, 22);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(203, 22);
            this.Department.TabIndex = 1;
            this.Department.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Department_KeyPress);
            // 
            // UserNo
            // 
            this.UserNo.AutoSize = true;
            this.UserNo.Location = new System.Drawing.Point(42, 25);
            this.UserNo.Name = "UserNo";
            this.UserNo.Size = new System.Drawing.Size(54, 16);
            this.UserNo.TabIndex = 0;
            this.UserNo.Text = "UserNo";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IsApproved);
            this.panel2.Controls.Add(this.txtClose);
            this.panel2.Controls.Add(this.txtDelete);
            this.panel2.Controls.Add(this.txtUpdate);
            this.panel2.Controls.Add(this.txtNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 496);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1224, 90);
            this.panel2.TabIndex = 1;
            // 
            // IsApproved
            // 
            this.IsApproved.Location = new System.Drawing.Point(70, 17);
            this.IsApproved.Name = "IsApproved";
            this.IsApproved.Size = new System.Drawing.Size(185, 61);
            this.IsApproved.TabIndex = 0;
            this.IsApproved.Text = "Approved";
            this.IsApproved.UseVisualStyleBackColor = true;
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(900, 17);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(185, 61);
            this.txtClose.TabIndex = 4;
            this.txtClose.Text = "Close";
            this.txtClose.UseVisualStyleBackColor = true;
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(710, 17);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(185, 61);
            this.txtDelete.TabIndex = 3;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(509, 17);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(185, 61);
            this.txtUpdate.TabIndex = 2;
            this.txtUpdate.Text = "Update";
            this.txtUpdate.UseVisualStyleBackColor = true;
            this.txtUpdate.Click += new System.EventHandler(this.txtUpdate_Click);
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(306, 17);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(185, 61);
            this.txtNew.TabIndex = 1;
            this.txtNew.Text = "new";
            this.txtNew.UseVisualStyleBackColor = true;
            this.txtNew.Click += new System.EventHandler(this.txtNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1224, 242);
            this.dataGridView1.TabIndex = 2;
            // 
            // FrmtaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 586);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            
            this.Text = "Frmtask";
            this.Load += new System.EventHandler(this.FrmtaskList_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button IsApproved;
        private System.Windows.Forms.Button txtClose;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.Button txtUpdate;
        private System.Windows.Forms.Button txtNew;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.Label UserNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dpEnd;
        private System.Windows.Forms.Label dpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Taskstate;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton EndDate;
        private System.Windows.Forms.RadioButton StartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button txtclear;
        private System.Windows.Forms.Button txtSearch;
    }
}