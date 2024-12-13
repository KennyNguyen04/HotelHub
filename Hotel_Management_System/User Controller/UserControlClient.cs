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
    public partial class UserControlClient : UserControl
    {
        DbConnector db;
        private string ID = "";
        public UserControlClient()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()
        {
            txtAddress.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtPhoneNo.Clear();
            tabControlClient.SelectedTab = tabPageAddClient;
        }
        public void Clear1()
        {
            txtAddress1.Clear();
            txtFName1.Clear();
            txtLName1.Clear();
            txtPhoneNo1.Clear();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check;
            if(txtFName.Text.Trim() == string.Empty || txtLName.Text.Trim() == string.Empty 
                || txtPhoneNo.Text.Trim() == string.Empty || txtAddress.Text.Trim() == string.Empty)
                MessageBox.Show("please fill out all fields.", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddClient(txtFName.Text.Trim(), txtLName.Text.Trim(), txtPhoneNo.Text.Trim(), txtAddress.Text.Trim());
                if ( check ) 
                    Clear();
            }
        }

        private void tabPageAddClient_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();

        }

        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Client_Table", gvClient);
        }

        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
            txtSearchPhoneNo.Clear();
        }

        private void txtSearchPhoneNo_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Client_Table WHERE Client_Phone LIKE '%" + txtSearchPhoneNo.Text + "%'", gvClient);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (txtFName1.Text.Trim() == string.Empty || txtLName1.Text.Trim() == string.Empty
                || txtPhoneNo1.Text.Trim() == string.Empty || txtAddress1.Text.Trim() == string.Empty)
                MessageBox.Show("please fill out all fields.", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.UpdateClient(ID,txtFName1.Text.Trim(), txtLName1.Text.Trim(), txtPhoneNo1.Text.Trim(), txtAddress1.Text.Trim());
                if (check)
                    Clear1();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check;
            if (ID != "")
            {
                if (txtFName1.Text.Trim() == string.Empty || txtLName1.Text.Trim() == string.Empty
                || txtPhoneNo1.Text.Trim() == string.Empty || txtAddress1.Text.Trim() == string.Empty)
                    MessageBox.Show("please fill out all fields.", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DialogResult result = MessageBox.Show("Are you want to delete this client?", "Client Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        check = db.DeleteClient(ID);
                        if (check)
                            Clear1();
                    }
                }
            }
            else
                MessageBox.Show("please first select row from table.", "selection of row", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabPageUpDelClient_Leave(object sender, EventArgs e)
        {
            Clear1();
        }

        private void gvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = gvClient.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                txtFName1.Text = row.Cells[1].Value.ToString();
                txtLName1.Text = row.Cells[2].Value.ToString();
                txtPhoneNo1.Text = row.Cells[3].Value.ToString();
                txtAddress1.Text = row.Cells[4].Value.ToString();
            }
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự được nhập vào TextBox
            }
        }

        private void txtSearchPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự được nhập vào TextBox
            }
        }

        private void txtPhoneNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự được nhập vào TextBox
            }
        }
    }
}
