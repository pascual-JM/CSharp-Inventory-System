using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySystem
{
    public partial class DashBoardContent : UserControl
    {
        public DashBoardContent()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("dddd, MMM dd, yyyy");
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
            Login logout = new Login();
            logout.Show();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FormControl fc = new FormControl();
            fc.btnAddUser.PerformClick();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            FormControl fc = new FormControl();
            fc.btnSecurity.PerformClick();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            FormControl fc = new FormControl();
            fc.btnInventory.PerformClick();
        }

        public void setUserName(string username)
        {
            lblUsername.Text = username + "!";
        }
    }
}
