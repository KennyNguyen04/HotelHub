namespace Hotel_Management_System.User_Controller
{
    partial class UserControlSetting
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
            this.tabControlUser = new System.Windows.Forms.TabControl();
            this.tabPageAddUser = new System.Windows.Forms.TabPage();
            this.tabPageSearchUser = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gvUser = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageUpdateUser = new System.Windows.Forms.TabPage();
            this.txtUsername1 = new System.Windows.Forms.TextBox();
            this.txtPassword1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControlUser.SuspendLayout();
            this.tabPageAddUser.SuspendLayout();
            this.tabPageSearchUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).BeginInit();
            this.tabPageUpdateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUser
            // 
            this.tabControlUser.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlUser.Controls.Add(this.tabPageAddUser);
            this.tabControlUser.Controls.Add(this.tabPageSearchUser);
            this.tabControlUser.Controls.Add(this.tabPageUpdateUser);
            this.tabControlUser.Location = new System.Drawing.Point(46, 39);
            this.tabControlUser.Name = "tabControlUser";
            this.tabControlUser.SelectedIndex = 0;
            this.tabControlUser.Size = new System.Drawing.Size(1504, 595);
            this.tabControlUser.TabIndex = 0;
            // 
            // tabPageAddUser
            // 
            this.tabPageAddUser.Controls.Add(this.btnAddUser);
            this.tabPageAddUser.Controls.Add(this.txtConfirmPassword);
            this.tabPageAddUser.Controls.Add(this.label4);
            this.tabPageAddUser.Controls.Add(this.txtUsername);
            this.tabPageAddUser.Controls.Add(this.txtPassword);
            this.tabPageAddUser.Controls.Add(this.label3);
            this.tabPageAddUser.Controls.Add(this.label2);
            this.tabPageAddUser.Controls.Add(this.label1);
            this.tabPageAddUser.Location = new System.Drawing.Point(10, 10);
            this.tabPageAddUser.Name = "tabPageAddUser";
            this.tabPageAddUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddUser.Size = new System.Drawing.Size(1484, 521);
            this.tabPageAddUser.TabIndex = 0;
            this.tabPageAddUser.Text = "Add User";
            this.tabPageAddUser.UseVisualStyleBackColor = true;
            // 
            // tabPageSearchUser
            // 
            this.tabPageSearchUser.Controls.Add(this.gvUser);
            this.tabPageSearchUser.Controls.Add(this.txtSearchUsername);
            this.tabPageSearchUser.Controls.Add(this.label6);
            this.tabPageSearchUser.Controls.Add(this.label5);
            this.tabPageSearchUser.Location = new System.Drawing.Point(10, 10);
            this.tabPageSearchUser.Name = "tabPageSearchUser";
            this.tabPageSearchUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchUser.Size = new System.Drawing.Size(1484, 521);
            this.tabPageSearchUser.TabIndex = 1;
            this.tabPageSearchUser.Text = "Search User";
            this.tabPageSearchUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add User:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 47);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(639, 187);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(590, 57);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(639, 83);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(590, 57);
            this.txtUsername.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(639, 296);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(590, 57);
            this.txtConfirmPassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(376, 47);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirm Password:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(749, 395);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(8);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(262, 93);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(261, 47);
            this.label5.TabIndex = 0;
            this.label5.Text = "Search User:";
            // 
            // txtSearchUsername
            // 
            this.txtSearchUsername.Location = new System.Drawing.Point(590, 58);
            this.txtSearchUsername.Name = "txtSearchUsername";
            this.txtSearchUsername.Size = new System.Drawing.Size(590, 57);
            this.txtSearchUsername.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 47);
            this.label6.TabIndex = 1;
            this.label6.Text = "Username:";
            // 
            // gvUser
            // 
            this.gvUser.AllowUserToAddRows = false;
            this.gvUser.AllowUserToDeleteRows = false;
            this.gvUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.gvUser.GridColor = System.Drawing.Color.White;
            this.gvUser.Location = new System.Drawing.Point(43, 140);
            this.gvUser.Name = "gvUser";
            this.gvUser.ReadOnly = true;
            this.gvUser.RowHeadersVisible = false;
            this.gvUser.RowHeadersWidth = 102;
            this.gvUser.RowTemplate.Height = 40;
            this.gvUser.Size = new System.Drawing.Size(1409, 363);
            this.gvUser.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.DataPropertyName = "User_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 12;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 113;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "User_Username";
            this.Column2.HeaderText = "Username";
            this.Column2.MinimumWidth = 12;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "User_Password";
            this.Column3.HeaderText = "Password";
            this.Column3.MinimumWidth = 12;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // tabPageUpdateUser
            // 
            this.tabPageUpdateUser.Controls.Add(this.btnDelete);
            this.tabPageUpdateUser.Controls.Add(this.btnUpdate);
            this.tabPageUpdateUser.Controls.Add(this.txtUsername1);
            this.tabPageUpdateUser.Controls.Add(this.txtPassword1);
            this.tabPageUpdateUser.Controls.Add(this.label7);
            this.tabPageUpdateUser.Controls.Add(this.label8);
            this.tabPageUpdateUser.Controls.Add(this.label9);
            this.tabPageUpdateUser.Location = new System.Drawing.Point(10, 10);
            this.tabPageUpdateUser.Name = "tabPageUpdateUser";
            this.tabPageUpdateUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateUser.Size = new System.Drawing.Size(1484, 521);
            this.tabPageUpdateUser.TabIndex = 2;
            this.tabPageUpdateUser.Text = "Update and Delete User";
            this.tabPageUpdateUser.UseVisualStyleBackColor = true;
            // 
            // txtUsername1
            // 
            this.txtUsername1.Location = new System.Drawing.Point(548, 122);
            this.txtUsername1.Name = "txtUsername1";
            this.txtUsername1.Size = new System.Drawing.Size(590, 57);
            this.txtUsername1.TabIndex = 1;
            // 
            // txtPassword1
            // 
            this.txtPassword1.Location = new System.Drawing.Point(548, 226);
            this.txtPassword1.Name = "txtPassword1";
            this.txtPassword1.Size = new System.Drawing.Size(590, 57);
            this.txtPassword1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 47);
            this.label7.TabIndex = 0;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 47);
            this.label8.TabIndex = 0;
            this.label8.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.label9.Location = new System.Drawing.Point(9, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 47);
            this.label9.TabIndex = 0;
            this.label9.Text = "Add User:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(548, 343);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(8);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(182, 79);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(956, 343);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 79);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // UserControlSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 47F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlUser);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UserControlSetting";
            this.Size = new System.Drawing.Size(1597, 669);
            this.tabControlUser.ResumeLayout(false);
            this.tabPageAddUser.ResumeLayout(false);
            this.tabPageAddUser.PerformLayout();
            this.tabPageSearchUser.ResumeLayout(false);
            this.tabPageSearchUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvUser)).EndInit();
            this.tabPageUpdateUser.ResumeLayout(false);
            this.tabPageUpdateUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUser;
        private System.Windows.Forms.TabPage tabPageAddUser;
        private System.Windows.Forms.TabPage tabPageSearchUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.TextBox txtSearchUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView gvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage tabPageUpdateUser;
        private System.Windows.Forms.TextBox txtUsername1;
        private System.Windows.Forms.TextBox txtPassword1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
    }
}
