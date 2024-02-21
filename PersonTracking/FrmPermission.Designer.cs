namespace PersonTracking
{
    partial class FrmPermission
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
            this.Department = new System.Windows.Forms.TextBox();
            this.UserNo = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dpEnd = new System.Windows.Forms.Label();
            this.dpStart = new System.Windows.Forms.Label();
            this.txtDayAmount = new System.Windows.Forms.TextBox();
            this.DayAmount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtExplain = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(102, 24);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(203, 22);
            this.Department.TabIndex = 3;
            // 
            // UserNo
            // 
            this.UserNo.AutoSize = true;
            this.UserNo.Location = new System.Drawing.Point(23, 27);
            this.UserNo.Name = "UserNo";
            this.UserNo.Size = new System.Drawing.Size(54, 16);
            this.UserNo.TabIndex = 2;
            this.UserNo.Text = "UserNo";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(102, 106);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker2.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dpEnd
            // 
            this.dpEnd.AutoSize = true;
            this.dpEnd.Location = new System.Drawing.Point(32, 106);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(42, 16);
            this.dpEnd.TabIndex = 8;
            this.dpEnd.Text = "Finish";
            // 
            // dpStart
            // 
            this.dpStart.AutoSize = true;
            this.dpStart.Location = new System.Drawing.Point(32, 70);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(34, 16);
            this.dpStart.TabIndex = 6;
            this.dpStart.Text = "Start";
            // 
            // txtDayAmount
            // 
            this.txtDayAmount.Location = new System.Drawing.Point(119, 163);
            this.txtDayAmount.Name = "txtDayAmount";
            this.txtDayAmount.Size = new System.Drawing.Size(203, 22);
            this.txtDayAmount.TabIndex = 11;
            // 
            // DayAmount
            // 
            this.DayAmount.AutoSize = true;
            this.DayAmount.Location = new System.Drawing.Point(40, 166);
            this.DayAmount.Name = "DayAmount";
            this.DayAmount.Size = new System.Drawing.Size(77, 16);
            this.DayAmount.TabIndex = 10;
            this.DayAmount.Text = "DayAmount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 214);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(436, 122);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtExplain
            // 
            this.txtExplain.AutoSize = true;
            this.txtExplain.Location = new System.Drawing.Point(32, 214);
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(41, 16);
            this.txtExplain.TabIndex = 12;
            this.txtExplain.Text = "Expla";
            // 
            // Exit
            // 
            this.Exit.ForeColor = System.Drawing.Color.IndianRed;
            this.Exit.Location = new System.Drawing.Point(102, 358);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(183, 70);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Save";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(419, 358);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(183, 70);
            this.Enter.TabIndex = 15;
            this.Enter.Text = "Close";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // FrmPermission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtExplain);
            this.Controls.Add(this.txtDayAmount);
            this.Controls.Add(this.DayAmount);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dpEnd);
            this.Controls.Add(this.dpStart);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.UserNo);
            this.Name = "FrmPermission";
            this.Text = "FrmPermission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.Label UserNo;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dpEnd;
        private System.Windows.Forms.Label dpStart;
        private System.Windows.Forms.TextBox txtDayAmount;
        private System.Windows.Forms.Label DayAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtExplain;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Enter;
    }
}