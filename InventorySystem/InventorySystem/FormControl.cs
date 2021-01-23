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
    public partial class FormControl : Form
    {
        public string Username = "";
        public FormControl()
        {
            InitializeComponent();
        }

        public void hideSubMenu()
        {
            panelSecurity.Visible = false;
        }

        private void FormControl_Load(object sender, EventArgs e)
        {
            dashBoardContent1.setUserName(Username);
            dashBoardContent1.BringToFront();
            hideSubMenu();
        }
         private void btnDashboard_Click(object sender, EventArgs e)
         {
            dashBoardContent1.BringToFront();
            hideSubMenu();
         }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnSecurity_Click(object sender, EventArgs e)
        {
            if(panelSecurity.Visible == false)
                panelSecurity.Visible = true;
            else
            {
                hideSubMenu();
            }
        }

        private void btnViewUsers_Click(object sender, EventArgs e)
        {
            viewUsersContent1.BringToFront();
            viewUsersContent1.populateTable();
            hideSubMenu();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            addUserContent1.BringToFront();
            hideSubMenu();
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

    }
}
