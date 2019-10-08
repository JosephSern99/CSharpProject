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
            string uname = Login.uname.ToString();
            helloUser.Text = "Hello " + uname;
        }
        public void HideAll()
        {
            clientAcctMgnt1.Visible = false;
            staffAccountManagement1.Visible = false;
            jobForum1.Visible = false;
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            HideAll();
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {

            this.Close();
            System.Windows.Forms.Application.ExitThread();
        }

        private void BtnStaffAccountMgnt_Click(object sender, EventArgs e)
        {
            HideAll();
            staffAccountManagement1.Visible = true;
        }

        private void BtnClientAccountMgnt_Click(object sender, EventArgs e)
        {
            HideAll();
            clientAcctMgnt1.Visible = true;
        }
    }
}
