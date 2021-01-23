
namespace InventorySystem
{
    partial class DashBoardContent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoardContent));
            this.lblTime = new System.Windows.Forms.Label();
            this.btnInventory = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDateTitle = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblGreet = new System.Windows.Forms.Label();
            this.lblLogHistoryTitle = new System.Windows.Forms.Label();
            this.lbLogHistory = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSecurity = new System.Windows.Forms.Button();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.lblTime.Location = new System.Drawing.Point(644, 29);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(48, 18);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time";
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnInventory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnInventory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.btnInventory.Image = ((System.Drawing.Image)(resources.GetObject("btnInventory.Image")));
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(39, 162);
            this.btnInventory.Margin = new System.Windows.Forms.Padding(0);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(161, 55);
            this.btnInventory.TabIndex = 3;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.lblDate.Location = new System.Drawing.Point(122, 76);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 18);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // lblDateTitle
            // 
            this.lblDateTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTitle.AutoSize = true;
            this.lblDateTitle.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.lblDateTitle.Location = new System.Drawing.Point(44, 76);
            this.lblDateTitle.Name = "lblDateTitle";
            this.lblDateTitle.Size = new System.Drawing.Size(76, 18);
            this.lblDateTitle.TabIndex = 8;
            this.lblDateTitle.Text = "Today is";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.lblUsername.Location = new System.Drawing.Point(247, 31);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(84, 29);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "User!";
            // 
            // lblGreet
            // 
            this.lblGreet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGreet.AutoSize = true;
            this.lblGreet.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.lblGreet.Location = new System.Drawing.Point(36, 31);
            this.lblGreet.Name = "lblGreet";
            this.lblGreet.Size = new System.Drawing.Size(207, 29);
            this.lblGreet.TabIndex = 5;
            this.lblGreet.Text = "Welcome Back";
            // 
            // lblLogHistoryTitle
            // 
            this.lblLogHistoryTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLogHistoryTitle.AutoSize = true;
            this.lblLogHistoryTitle.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.lblLogHistoryTitle.Location = new System.Drawing.Point(36, 246);
            this.lblLogHistoryTitle.Name = "lblLogHistoryTitle";
            this.lblLogHistoryTitle.Size = new System.Drawing.Size(166, 29);
            this.lblLogHistoryTitle.TabIndex = 10;
            this.lblLogHistoryTitle.Text = "Log History";
            // 
            // lbLogHistory
            // 
            this.lbLogHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLogHistory.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogHistory.FormattingEnabled = true;
            this.lbLogHistory.ItemHeight = 18;
            this.lbLogHistory.Items.AddRange(new object[] {
            "Log History goes here......"});
            this.lbLogHistory.Location = new System.Drawing.Point(41, 293);
            this.lbLogHistory.Name = "lbLogHistory";
            this.lbLogHistory.Size = new System.Drawing.Size(710, 202);
            this.lbLogHistory.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(34, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "Shortcuts";
            // 
            // btnSecurity
            // 
            this.btnSecurity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.btnSecurity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecurity.FlatAppearance.BorderSize = 0;
            this.btnSecurity.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnSecurity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnSecurity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecurity.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecurity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.btnSecurity.Image = global::InventorySystem.Properties.Resources.security;
            this.btnSecurity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecurity.Location = new System.Drawing.Point(246, 162);
            this.btnSecurity.Margin = new System.Windows.Forms.Padding(0);
            this.btnSecurity.Name = "btnSecurity";
            this.btnSecurity.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnSecurity.Size = new System.Drawing.Size(161, 55);
            this.btnSecurity.TabIndex = 3;
            this.btnSecurity.Text = "Security";
            this.btnSecurity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSecurity.UseVisualStyleBackColor = false;
            this.btnSecurity.Click += new System.EventHandler(this.btnSecurity_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.btnNewUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnNewUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.btnNewUser.Image = global::InventorySystem.Properties.Resources.add_user;
            this.btnNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewUser.Location = new System.Drawing.Point(453, 162);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnNewUser.Size = new System.Drawing.Size(161, 55);
            this.btnNewUser.TabIndex = 3;
            this.btnNewUser.Text = "Add New User";
            this.btnNewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(78)))), ((int)(((byte)(112)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(119)))), ((int)(((byte)(134)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(647, 62);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(104, 32);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // DashBoardContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(248)))), ((int)(((byte)(190)))));
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLogHistoryTitle);
            this.Controls.Add(this.lbLogHistory);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblDateTitle);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblGreet);
            this.Controls.Add(this.btnNewUser);
            this.Controls.Add(this.btnSecurity);
            this.Controls.Add(this.btnInventory);
            this.Controls.Add(this.lblTime);
            this.Name = "DashBoardContent";
            this.Size = new System.Drawing.Size(793, 532);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDateTitle;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblGreet;
        private System.Windows.Forms.Label lblLogHistoryTitle;
        private System.Windows.Forms.ListBox lbLogHistory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSecurity;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnLogout;
    }
}
