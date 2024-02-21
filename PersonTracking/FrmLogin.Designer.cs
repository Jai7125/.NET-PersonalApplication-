namespace PersonTracking
{
    partial class FrmLogin
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
            this.UserNo = new System.Windows.Forms.Label();
            this.txtUserNo = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNo
            // 
            this.UserNo.AutoSize = true;
            this.UserNo.Location = new System.Drawing.Point(38, 45);
            this.UserNo.Name = "UserNo";
            this.UserNo.Size = new System.Drawing.Size(54, 16);
            this.UserNo.TabIndex = 0;
            this.UserNo.Text = "UserNo";
            // 
            // txtUserNo
            // 
            this.txtUserNo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtUserNo.Location = new System.Drawing.Point(135, 39);
            this.txtUserNo.Name = "txtUserNo";
            this.txtUserNo.Size = new System.Drawing.Size(246, 22);
            this.txtUserNo.TabIndex = 1;
            this.txtUserNo.TextChanged += new System.EventHandler(this.txtUserNo_TextChanged);
            this.txtUserNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserNo_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(135, 102);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(246, 22);
            this.txtPassword.TabIndex = 3;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(38, 108);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 16);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(436, 211);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(183, 70);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Exit
            // 
            this.Exit.ForeColor = System.Drawing.Color.IndianRed;
            this.Exit.Location = new System.Drawing.Point(135, 211);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(183, 70);
            this.Exit.TabIndex = 5;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtUserNo);
            this.Controls.Add(this.UserNo);
            this.Name = "FrmLogin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserNo;
        private System.Windows.Forms.TextBox txtUserNo;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Exit;
    }
}

