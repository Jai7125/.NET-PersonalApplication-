namespace PersonTracking
{
    partial class DeptList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtnew = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.Button();
            this.txtClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtnew
            // 
            this.txtnew.Location = new System.Drawing.Point(12, 357);
            this.txtnew.Name = "txtnew";
            this.txtnew.Size = new System.Drawing.Size(185, 61);
            this.txtnew.TabIndex = 1;
            this.txtnew.Text = "new";
            this.txtnew.UseVisualStyleBackColor = true;
            this.txtnew.Click += new System.EventHandler(this.txtAdd_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(215, 357);
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(185, 61);
            this.txtUpdate.TabIndex = 2;
            this.txtUpdate.Text = "Update";
            this.txtUpdate.UseVisualStyleBackColor = true;
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(416, 357);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(185, 61);
            this.txtDelete.TabIndex = 3;
            this.txtDelete.Text = "Delete";
            this.txtDelete.UseVisualStyleBackColor = true;
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(607, 357);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(185, 61);
            this.txtClose.TabIndex = 4;
            this.txtClose.Text = "Close";
            this.txtClose.UseVisualStyleBackColor = true;
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // DeptList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.txtDelete);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.txtnew);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeptList";
            this.Text = "DeptList";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button txtnew;
        private System.Windows.Forms.Button txtUpdate;
        private System.Windows.Forms.Button txtDelete;
        private System.Windows.Forms.Button txtClose;
    }
}