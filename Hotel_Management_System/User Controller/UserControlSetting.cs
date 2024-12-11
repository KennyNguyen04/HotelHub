using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hotel_Management_System.User_Controller
{
    public partial class UserControlSetting : UserControl
    {
        DbConnector db;
        private string ID = "";
        public UserControlSetting()
        {
            InitializeComponent();
            db = new DbConnector();

        }

        public void Clear()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            tabControlUser.SelectedTab = tabPageAddUser;
        }
        public void Clear1()
        {
            txtUsername1.Clear();
            txtPassword1.Clear();
            ID = "";
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            Clear();
        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM User_Table", gvUser);

        }

        private void tabPageSearchUser_Leave(object sender, EventArgs e)
        {
            txtSearchUsername.Clear();
        }

        private void tabPageUpDelUser_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            bool check;
            if (txtUsername.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty || txtConfirmPassword.Text.Trim() == string.Empty)
                MessageBox.Show("please fill out all fields.", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txtPassword.Text.Trim() != txtConfirmPassword.Text.Trim()) 
                MessageBox.Show("Password and confirm password do not match.", "Password confirmation error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddUser(txtUsername.Text.Trim(), txtPassword.Text.Trim());
                if (check)
                    Clear();
            }
        }

        private void gvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = gvUser.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                txtUsername1.Text = row.Cells[1].Value.ToString();
                txtPassword1.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (txtUsername1.Text.Trim() == string.Empty || txtPassword1.Text.Trim() == string.Empty)
                    MessageBox.Show("please fill out all fields.", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    check = db.UpdateUser(ID, txtUsername1.Text.Trim(), txtPassword1.Text.Trim());
                    if (check)
                        Clear1();
                }
            }
            else
                MessageBox.Show("please first select row from table.", "selection of row", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (txtUsername1.Text.Trim() == string.Empty || txtPassword1.Text.Trim() == string.Empty)
                    MessageBox.Show("please fill out all fields.", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DialogResult result = MessageBox.Show("Are you want to delete this user?","User Delete",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(DialogResult.Yes == result)
                    {
                        check = db.DeleteUser(ID);
                        if (check)
                            Clear1();
                    }
                }
            }
            else
                MessageBox.Show("please first select row from table.", "selection of row", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtSearchUsername_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM User_Table WHERE User_Name LIKE '%" + txtSearchUsername.Text + "%'", gvUser );
        }
    }
}
