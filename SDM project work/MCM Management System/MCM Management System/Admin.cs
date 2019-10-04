using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCM_Management_System
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login Login = new Login();
            Login.ShowDialog();
        }

        private void BtnStaffAccountMgnt_Click(object sender, EventArgs e)
        {
            panelAdmin.Visible = false;
            staffAccountManagement1.Visible = true;
        }
    }
}
