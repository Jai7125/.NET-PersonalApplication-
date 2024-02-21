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
    public partial class DeptList : Form
    {
        public DeptList()
        {
            InitializeComponent();
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void txtAdd_Click(object sender, EventArgs e)
        {
            Department frm = new Department(); 
            this.Hide();
            frm.ShowDialog();   
            this.Visible = true;    
            
           
        }
    }
}
