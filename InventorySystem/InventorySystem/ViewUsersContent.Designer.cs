
namespace InventorySystem
{
    partial class ViewUsersContent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.lblGreet = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMiddleName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(21, 264);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowTemplate.Height = 30;
            this.dgvUsers.Size = new System.Drawing.Size(745, 236);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // lblGreet
            // 
            this.lblGreet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGreet.AutoSize = true;
            this.lblGreet.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.lblGreet.Location = new System.Drawing.Point(15, 21);
            this.lblGreet.Name = "lblGreet";
            this.lblGreet.Size = new System.Drawing.Size(162, 29);
            this.lblGreet.TabIndex = 6;
            this.lblGreet.Text = "View Users";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(110, 69);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(205, 23);
            this.tbUsername.TabIndex = 7;
            this.tbUsername.TextChanged += new System.EventHandler(this.tbUsername_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(17, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(17, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Name:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFirstName.Location = new System.Drawing.Point(110, 116);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(205, 23);
            this.tbFirstName.TabIndex = 9;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label3.Location = new System.Drawing.Point(340, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(429, 69);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(205, 23);
            this.tbPassword.TabIndex = 11;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label4.Location = new System.Drawing.Point(382, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Age:";
            // 
            // tbAge
            // 
            this.tbAge.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAge.Location = new System.Drawing.Point(429, 165);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(90, 23);
            this.tbAge.TabIndex = 13;
            this.tbAge.TextAlignChanged += new System.EventHandler(this.tbAge_TextAlignChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label5.Location = new System.Drawing.Point(321, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "MiddleName:";
            // 
            // tbMiddleName
            // 
            this.tbMiddleName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMiddleName.Location = new System.Drawing.Point(429, 116);
            this.tbMiddleName.Name = "tbMiddleName";
            this.tbMiddleName.Size = new System.Drawing.Size(205, 23);
            this.tbMiddleName.TabIndex = 15;
            this.tbMiddleName.TextChanged += new System.EventHandler(this.tbMiddleName_TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label6.Location = new System.Drawing.Point(14, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Last Name:";
            // 
            // tbLastName
            // 
            this.tbLastName.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.Location = new System.Drawing.Point(110, 165);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(205, 23);
            this.tbLastName.TabIndex = 17;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.btnEdit.Image = global::InventorySystem.Properties.Resources.edit;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(21, 211);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnEdit.Size = new System.Drawing.Size(171, 34);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Edit Account";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.btnDeleteAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteAccount.Enabled = false;
            this.btnDeleteAccount.FlatAppearance.BorderSize = 0;
            this.btnDeleteAccount.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnDeleteAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnDeleteAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.btnDeleteAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteAccount.Location = new System.Drawing.Point(211, 211);
            this.btnDeleteAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(153, 34);
            this.btnDeleteAccount.TabIndex = 20;
            this.btnDeleteAccount.Text = "Delete Account";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // ViewUsersContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbMiddleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.lblGreet);
            this.Controls.Add(this.dgvUsers);
            this.Name = "ViewUsersContent";
            this.Size = new System.Drawing.Size(793, 532);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblGreet;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDeleteAccount;
    }
}
