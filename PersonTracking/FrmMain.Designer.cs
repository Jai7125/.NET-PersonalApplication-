namespace PersonTracking
{
    partial class FrmMain
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
            this.txtPosition = new System.Windows.Forms.Button();
            this.Department = new System.Windows.Forms.Button();
            this.txtpermission = new System.Windows.Forms.Button();
            this.txtSalary = new System.Windows.Forms.Button();
            this.txtTasks = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPosition
            // 
            this.txtPosition.Image = global::PersonTracking.Properties.Resources.Image;
            this.txtPosition.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtPosition.Location = new System.Drawing.Point(876, 255);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(213, 125);
            this.txtPosition.TabIndex = 5;
            this.txtPosition.Text = "Position";
            this.txtPosition.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtPosition.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.txtPosition.UseVisualStyleBackColor = true;
            this.txtPosition.Click += new System.EventHandler(this.txtPosition_Click);
            // 
            // Department
            // 
            this.Department.Image = global::PersonTracking.Properties.Resources.Image;
            this.Department.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Department.Location = new System.Drawing.Point(502, 255);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(213, 125);
            this.Department.TabIndex = 4;
            this.Department.Text = "txtDepartment";
            this.Department.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Department.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Department.UseVisualStyleBackColor = true;
            this.Department.Click += new System.EventHandler(this.Department_Click);
            // 
            // txtpermission
            // 
            this.txtpermission.Image = global::PersonTracking.Properties.Resources.Image;
            this.txtpermission.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtpermission.Location = new System.Drawing.Point(42, 255);
            this.txtpermission.Name = "txtpermission";
            this.txtpermission.Size = new System.Drawing.Size(213, 125);
            this.txtpermission.TabIndex = 3;
            this.txtpermission.Text = "txtpermission";
            this.txtpermission.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtpermission.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.txtpermission.UseVisualStyleBackColor = true;
            this.txtpermission.Click += new System.EventHandler(this.txtpermission_Click);
            // 
            // txtSalary
            // 
            this.txtSalary.Image = global::PersonTracking.Properties.Resources.Image;
            this.txtSalary.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtSalary.Location = new System.Drawing.Point(876, 41);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(213, 125);
            this.txtSalary.TabIndex = 2;
            this.txtSalary.Text = "Salary";
            this.txtSalary.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtSalary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.txtSalary.UseVisualStyleBackColor = true;
            this.txtSalary.Click += new System.EventHandler(this.txtSalary_Click);
            // 
            // txtTasks
            // 
            this.txtTasks.AutoEllipsis = true;
            this.txtTasks.Image = global::PersonTracking.Properties.Resources.Image;
            this.txtTasks.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtTasks.Location = new System.Drawing.Point(502, 41);
            this.txtTasks.Name = "txtTasks";
            this.txtTasks.Size = new System.Drawing.Size(213, 125);
            this.txtTasks.TabIndex = 1;
            this.txtTasks.Text = "Tasks";
            this.txtTasks.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtTasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.txtTasks.UseVisualStyleBackColor = true;
            this.txtTasks.Click += new System.EventHandler(this.txtTasks_Click);
            // 
            // button1
            // 
            this.button1.Image = global::PersonTracking.Properties.Resources.Image;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(42, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 125);
            this.button1.TabIndex = 0;
            this.button1.Text = "Employee";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 590);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.txtpermission);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtTasks);
            this.Controls.Add(this.button1);
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button txtTasks;
        private System.Windows.Forms.Button txtSalary;
        private System.Windows.Forms.Button txtpermission;
        private System.Windows.Forms.Button Department;
        private System.Windows.Forms.Button txtPosition;
    }
}