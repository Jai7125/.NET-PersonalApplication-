namespace PersonTracking
{
    partial class FrmEmployeeList
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
            this.txtClose = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.Button();
            this.txtAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserNo = new System.Windows.Forms.Label();
            this.Department = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.Label();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NewFrm = new System.Windows.Forms.TextBox();
            this.Surname = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.Position = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.Button();
            this.txtclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(622, 360);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(185, 61);
            this.txtClose.TabIndex = 8;
            this.txtClose.Text = "Close";
            this.txtClose.UseVisualStyleBackColor = true;
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(431, 360);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(185, 61);
            this.txtDelete.TabIndex = 7;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(230, 360);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(185, 61);
            this.txtUpdate.TabIndex = 6;
            this.txtUpdate.Text = "Update";
            this.txtUpdate.UseVisualStyleBackColor = true;
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(27, 360);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(185, 61);
            this.txtAdd.TabIndex = 5;
            this.txtAdd.Text = "New";
            this.txtAdd.UseVisualStyleBackColor = true;
            this.txtAdd.Click += new System.EventHandler(this.txtAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 209);
            this.dataGridView1.TabIndex = 9;
            // 
            // UserNo
            // 
            this.UserNo.AutoSize = true;
            this.UserNo.Location = new System.Drawing.Point(29, 27);
            this.UserNo.Name = "UserNo";
            this.UserNo.Size = new System.Drawing.Size(54, 16);
            this.UserNo.TabIndex = 10;
            this.UserNo.Text = "UserNo";
            // 
            // Department
            // 
            this.Department.Location = new System.Drawing.Point(104, 21);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(203, 22);
            this.Department.TabIndex = 11;
            this.Department.FontChanged += new System.EventHandler(this.textBox1_FontChanged);
            this.Department.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(203, 22);
            this.txtName.TabIndex = 13;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(39, 52);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(44, 16);
            this.Name.TabIndex = 12;
            this.Name.Text = "Name";
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(415, 21);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(147, 22);
            this.txtDepartment.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Dep";
            // 
            // NewFrm
            // 
            this.NewFrm.Location = new System.Drawing.Point(118, 84);
            this.NewFrm.Name = "NewFrm";
            this.NewFrm.Size = new System.Drawing.Size(189, 22);
            this.NewFrm.TabIndex = 17;
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Location = new System.Drawing.Point(39, 90);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(73, 16);
            this.Surname.TabIndex = 16;
            this.Surname.Text = "txtSurname";
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(424, 59);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(147, 22);
            this.txtPosition.TabIndex = 19;
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(363, 65);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(55, 16);
            this.Position.TabIndex = 18;
            this.Position.Text = "Position";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(630, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(158, 33);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.Text = "Search";
            this.txtSearch.UseVisualStyleBackColor = true;
            // 
            // txtclear
            // 
            this.txtclear.Location = new System.Drawing.Point(630, 73);
            this.txtclear.Name = "txtclear";
            this.txtclear.Size = new System.Drawing.Size(158, 33);
            this.txtclear.TabIndex = 21;
            this.txtclear.Text = "Clear";
            this.txtclear.UseVisualStyleBackColor = true;
            // 
            // FrmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtclear);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.Position);
            this.Controls.Add(this.NewFrm);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Department);
            this.Controls.Add(this.UserNo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.txtAdd);
          
            this.Text = "FrmEmployeeList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtClose;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.Button txtUpdate;
        private System.Windows.Forms.Button txtAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label UserNo;
        private System.Windows.Forms.TextBox Department;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewFrm;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.Button txtclear;
    }
}