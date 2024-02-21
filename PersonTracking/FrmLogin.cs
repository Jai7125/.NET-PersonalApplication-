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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUserNo_TextChanged(object sender, EventArgs e)
        {
          


        }

        private void Exit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isnumber(e);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain(); 
            this.Hide();
            frm.ShowDialog();


        }
    }
}
