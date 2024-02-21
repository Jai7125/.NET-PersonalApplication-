namespace PersonTracking
{
    partial class frmposition
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
            this.txtPosition = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.txtDepartment = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPosition
            // 
            this.txtPosition.AutoSize = true;
            this.txtPosition.Location = new System.Drawing.Point(118, 111);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(55, 16);
            this.txtPosition.TabIndex = 0;
            this.txtPosition.Text = "Position";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(245, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(159, 295);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(181, 67);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            // 
            // txtDepartment
            // 
            this.txtDepartment.AutoSize = true;
            this.txtDepartment.Location = new System.Drawing.Point(118, 187);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(77, 16);
            this.txtDepartment.TabIndex = 3;
            this.txtDepartment.Text = "Department";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(234, 186);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(231, 24);
            this.cmbDepartment.TabIndex = 4;
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(429, 295);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(181, 67);
            this.Close.TabIndex = 5;
            this.Close.Text = "Close";
            this.Close.UseVisualStyleBackColor = true;
            // 
            // FrmPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtPosition);
            this.Name = "FrmPosition";
            this.Text = "FrmPosition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtPosition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label txtDepartment;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button Close;
    }
}