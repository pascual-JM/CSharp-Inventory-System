using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventorySystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(returnConnectionString());
                string query = "SELECT * FROM tblAdmin WHERE Username = '" + tbUsername.Text.Trim() + "'" +
                    " AND PASSWORD = '" + tbPassword.Text.Trim() + "'";
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                if(tbUsername.Text.Equals("") || tbPassword.Text.Equals(""))
                {
                    MessageBox.Show("Please fill out the form!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dtbl.Rows.Count == 1)
                {
                    string username = tbUsername.Text;
                    FormControl frmc = new FormControl();
                    frmc.Username = username;
                    frmc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clear();
                }
                conn.Close();
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("An Error Occured!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clear();
            }
        }

        public string returnConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\InventorySystem\InventorySystem\dbInventory.mdf;Integrated Security=True";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clear()
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
        }
    }
}
