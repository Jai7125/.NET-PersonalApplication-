using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonTracking
{
    public partial class FrmtaskList : Form
    {
        public FrmtaskList()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Department_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isnumber(e);
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void txtclear_Click(object sender, EventArgs e)
        {
           
        }

        private void FrmtaskList_Load(object sender, EventArgs e)
        {
             
        }

        private void txtNew_Click(object sender, EventArgs e)
        { 
            Frmtask frm = new Frmtask();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void txtUpdate_Click(object sender, EventArgs e)
        {
            Frmtask frm = new Frmtask();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

        }
    }
}
