
namespace InventorySystem
{
    partial class FormControl
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControl));
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.panelSecurity = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.addUserContent1 = new InventorySystem.AddUserContent();
            this.dashBoardContent1 = new InventorySystem.DashBoardContent();
            this.viewUsersContent1 = new InventorySystem.ViewUsersContent();
            this.panelSubMenu.SuspendLayout();
            this.panelSecurity.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.Controls.Add(this.panelSecurity);
            this.panelSubMenu.Controls.Add(this.btnSecurity);
            this.panelSubMenu.Controls.Add(this.btnInventory);
            this.panelSubMenu.Controls.Add(this.btnDashboard);
            this.panelSubMenu.Controls.Add(this.panelLogo);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(222, 532);
            this.panelSubMenu.TabIndex = 0;
            // 
            // panelSecurity
            // 
            this.panelSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(90)))), ((int)(((byte)(112)))));
            this.panelSecurity.Controls.Add(this.btnRemoveUser);
            this.panelSecurity.Controls.Add(this.btnAddUser);
            this.panelSecurity.Controls.Add(this.btnViewUsers);
            this.panelSecurity.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSecurity.Location = new System.Drawing.Point(0, 278);
            this.panelSecurity.Name = "panelSecurity";
            this.panelSecurity.Size = new System.Drawing.Size(222, 97);
            this.panelSecurity.TabIndex = 5;
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(222, 155);
            this.panelLogo.TabIndex = 0;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.panelContent.Controls.Add(this.dashBoardContent1);
            this.panelContent.Controls.Add(this.viewUsersContent1);
            this.panelContent.Controls.Add(this.addUserContent1);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(222, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(793, 532);
            this.panelContent.TabIndex = 1;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemoveUser.FlatAppearance.BorderSize = 0;
            this.btnRemoveUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnRemoveUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnRemoveUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveUser.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.btnRemoveUser.Image = global::InventorySystem.Properties.Resources.remove_user;
            this.btnRemoveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveUser.Location = new System.Drawing.Point(0, 64);
            this.btnRemoveUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRemoveUser.Size = new System.Drawing.Size(222, 32);
            this.btnRemoveUser.TabIndex = 6;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRemoveUser.UseVisualStyleBackColor = false;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.btnAddUser.Image = global::InventorySystem.Properties.Resources.add_user;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(0, 32);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAddUser.Size = new System.Drawing.Size(222, 32);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "Add New User";
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnViewUsers
            // 
            this.btnViewUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnViewUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewUsers.FlatAppearance.BorderSize = 0;
            this.btnViewUsers.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnViewUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnViewUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnViewUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUsers.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.btnViewUsers.Image = global::InventorySystem.Properties.Resources.view_user;
            this.btnViewUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewUsers.Location = new System.Drawing.Point(0, 0);
            this.btnViewUsers.Margin = new System.Windows.Forms.Padding(0);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnViewUsers.Size = new System.Drawing.Size(222, 32);
            this.btnViewUsers.TabIndex = 4;
            this.btnViewUsers.Text = "View Users";
            this.btnViewUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewUsers.UseVisualStyleBackColor = false;
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            // 
            // btnSecurity
            // 
            this.btnSecurity.BackColor = System.Drawing.Color.Transparent;
            this.btnSecurity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecurity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecurity.FlatAppearance.BorderSize = 0;
            this.btnSecurity.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnSecurity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnSecurity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecurity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.btnSecurity.Image = ((System.Drawing.Image)(resources.GetObject("btnSecurity.Image")));
            this.btnSecurity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurity.Location = new System.Drawing.Point(0, 237);
            this.btnSecurity.Margin = new System.Windows.Forms.Padding(0);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSecurity.Size = new System.Drawing.Size(222, 41);
            this.btnSecurity.TabIndex = 4;
            this.btnSecurity.Text = "Security";
            this.btnSecurity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSecurity.UseVisualStyleBackColor = false;
            this.btnSecurity.Click += new System.EventHandler(this.btnSecurity_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 196);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(0);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(222, 41);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 155);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(222, 41);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // addUserContent1
            // 
            this.addUserContent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.addUserContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUserContent1.Location = new System.Drawing.Point(0, 0);
            this.addUserContent1.Name = "addUserContent1";
            this.addUserContent1.Size = new System.Drawing.Size(793, 532);
            this.addUserContent1.TabIndex = 2;
            // 
            // dashBoardContent1
            // 
            this.dashBoardContent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.dashBoardContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoardContent1.Location = new System.Drawing.Point(0, 0);
            this.dashBoardContent1.Name = "dashBoardContent1";
            this.dashBoardContent1.Size = new System.Drawing.Size(793, 532);
            this.dashBoardContent1.TabIndex = 0;
            // 
            // viewUsersContent1
            // 
            this.viewUsersContent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.viewUsersContent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewUsersContent1.Location = new System.Drawing.Point(0, 0);
            this.viewUsersContent1.Name = "viewUsersContent1";
            this.viewUsersContent1.Size = new System.Drawing.Size(793, 532);
            this.viewUsersContent1.TabIndex = 1;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(1015, 532);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSubMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1031, 571);
            this.MinimumSize = new System.Drawing.Size(1031, 571);
            this.Name = "FormControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory System";
            this.Load += new System.EventHandler(this.FormControl_Load);
            this.panelSubMenu.ResumeLayout(false);
            this.panelSecurity.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Panel panelSecurity;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelContent;
        public System.Windows.Forms.Button btnAddUser;
        public System.Windows.Forms.Button btnSecurity;
        public System.Windows.Forms.Button btnInventory;
        private DashBoardContent dashBoardContent1;
        private ViewUsersContent viewUsersContent1;
        private AddUserContent addUserContent1;
    }
}