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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEmployee frm =  new FrmEmployee();
            this.Hide();

            frm.ShowDialog();
            this.Visible = true;    
 

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void txtTasks_Click(object sender, EventArgs e)
        {
            FrmtaskList frm = new FrmtaskList();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void txtSalary_Click(object sender, EventArgs e)
        {
            FrmsalaryList frm = new FrmsalaryList();
            this.Hide();    
            frm.ShowDialog();
            this.Visible = true;
        }

        private void txtpermission_Click(object sender, EventArgs e)
        {
            FrmPermission frm = new FrmPermission();
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void Department_Click(object sender, EventArgs e)
        {
            DeptList frm = new DeptList();  
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;
        }

        private void txtPosition_Click(object sender, EventArgs e)
        {
            PositionList frm  = new PositionList(); 
            this.Hide();
            frm.ShowDialog();
            this.Visible = true;

        }
    }
}
