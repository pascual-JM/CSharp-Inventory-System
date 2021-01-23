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
    public partial class ViewUsersContent : UserControl
    {
        string id = "";
        public ViewUsersContent()
        {
            InitializeComponent();
        }

        public void populateTable()
        {
            try
            {
                SqlConnection connection = new SqlConnection(returnConnectionString());
                string query = "SELECT * FROM tblAdmin";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                dgvUsers.DataSource = table;
                connection.Close();
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }

        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsers.Rows[e.RowIndex];
                id = Convert.ToString(row.Cells[0].Value);
                tbUsername.Text = row.Cells[1].Value.ToString();
                tbPassword.Text = row.Cells[2].Value.ToString();
                tbFirstName.Text = row.Cells[3].Value.ToString();
                tbMiddleName.Text = row.Cells[4].Value.ToString();
                tbLastName.Text = row.Cells[5].Value.ToString();
                tbAge.Text = row.Cells[6].Value.ToString();
                if (!id.Equals("")){
                    btnDeleteAccount.Enabled = true;
                    btnEdit.Enabled = true;
                }
                else
                {
                    btnDeleteAccount.Enabled = false;
                    btnEdit.Enabled = false;
                }
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var ConfirmAction = MessageBox.Show("Are you sure you want to delete this Account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(ConfirmAction == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection(returnConnectionString());
                if (id.Equals(""))
                {
                    MessageBox.Show("Please Select an Account from the Table!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        string query = "DELETE FROM tblAdmin WHERE Id='" + id + "'";
                        SqlCommand command = new SqlCommand(query, conn);
                        conn.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Account Deleted successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch (SqlException sqlex)
                    {
                        MessageBox.Show(sqlex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                        populateTable();
                        clearCredentials();
                        btnDeleteAccount.Enabled = false;
                        btnEdit.Enabled = false;
                    }
                }
            }
            else
            {

            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var ConfirmAction = MessageBox.Show("Are you sure you want to made changes to this Account?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ConfirmAction == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(returnConnectionString());
                if (id.Equals(""))
                {
                    MessageBox.Show("Please Select an Account from the Table!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string query = "UPDATE tblAdmin SET " +
                    "Username='" + tbUsername.Text + "', " +
                    "Password='" + tbPassword.Text + "', " +
                    "FirstName='" + tbFirstName.Text + "', " +
                    "MiddleName='" + tbMiddleName.Text + "', " +
                    "LastName='" + tbLastName.Text + "', " +
                    "Age='" + tbAge.Text + "'" +
                    "WHERE Id='" + id + "'";
                    try
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        command.ExecuteNonQuery();
                        
                        MessageBox.Show("Account Updated Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch (SqlException sqlex)
                    {
                        MessageBox.Show("An Error Occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                        populateTable();
                        clearCredentials();
                        btnEdit.Enabled = false;
                        btnDeleteAccount.Enabled = false;
                    }
                }
            }
            else
            {

            }
        }

        public void clearCredentials()
        {
            id = "";
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbFirstName.Text = "";
            tbMiddleName.Text = "";
            tbLastName.Text = "";
            tbAge.Text = "";
        }

        public string returnConnectionString()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\InventorySystem\InventorySystem\dbInventory.mdf;Integrated Security=True";
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
        }

        private void tbMiddleName_TextChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
        }

        private void tbAge_TextAlignChanged(object sender, EventArgs e)
        {
            btnEdit.Enabled = true;
        }
    }
}
