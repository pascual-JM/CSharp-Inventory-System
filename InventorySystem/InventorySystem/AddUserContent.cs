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
    public partial class AddUserContent : UserControl
    {
        public AddUserContent()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(returnConnectionString());
            if (tbUsername.Text.Equals("") || tbPassword.Text.Equals("") ||
                tbFirstName.Text.Equals("") || tbLastName.Text.Equals("") ||
                tbAge.Text.Equals(""))
            {
                MessageBox.Show("Please fill out the form!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(tbPassword.Text != tbConfirm.Text)
                {
                    MessageBox.Show("Passwords do not match", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string query = "INSERT INTO tblAdmin(Username, Password, FirstName, MiddleName, LastName, Age) VALUES('" + tbUsername.Text + "', '" + tbPassword.Text + "', '" + tbFirstName.Text + "', '" + tbMiddleName.Text + "', '" + tbLastName.Text + "', '" + tbAge.Text + "')";
                    SqlCommand command = new SqlCommand(query, conn);
                    try
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Registered Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException sqlex)
                    {
                        MessageBox.Show("An Error Occured!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
        }
        public string returnConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\InventorySystem\InventorySystem\dbInventory.mdf;Integrated Security=True";
        }


    }
}
