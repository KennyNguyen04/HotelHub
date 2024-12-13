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
    public partial class UserControlRoom : UserControl
    {
        DbConnector db;
        private string No = "", Free = "";
        public UserControlRoom()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void Clear()
        {
            comboBoxType.SelectedIndex = -1;
            txtPhoneNo.Clear();
            rbtnNo.Checked = false;
            rbtnYes.Checked = false;
            tabControlRoom.SelectedTab = tabPageAddRoom;
        }
        public void Clear1()
        {
            comboBoxType1.SelectedIndex = -1;
            txtPhoneNo1.Clear();
            rbtnNo1.Checked = false;
            rbtnYes1.Checked = false;
            No = "";
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            Free = "";
            if (rbtnYes.Checked)
                Free = "Yes";
            else if (rbtnNo.Checked)
                Free = "No";
            bool check;
            if (comboBoxType.SelectedIndex == -1 || txtPhoneNo.Text.Trim() == string.Empty || Free== "")
                MessageBox.Show("please fill out all fields.", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                check = db.AddRoom(comboBoxType.SelectedItem.ToString(), txtPhoneNo.Text.Trim(), Free);
                if (check)
                    Clear();
            }
        }

        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            Clear();
            Clear1();

        }

        private void tabPageSearchRoom_Enter(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Room_Table", gvRoom);
        }

        private void tabPageSearchRoom_Leave(object sender, EventArgs e)
        {
            txtSearchRoomNo.Clear();
        }

        private void txtSearchRoomNo_TextChanged(object sender, EventArgs e)
        {
            db.DisplayAndSearch("SELECT * FROM Room_Table WHERE Room_Number LIKE '%" + txtSearchRoomNo.Text + "%'", gvRoom);
        }

        private void gvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = gvRoom.Rows[e.RowIndex];
                No = row.Cells[0].Value.ToString();
                comboBoxType1.SelectedItem = row.Cells[1].Value.ToString();
                txtPhoneNo1.Text = row.Cells[2].Value.ToString();
                Free = row.Cells[3].Value.ToString();
                if (Free=="Yes")
                    rbtnYes1.Checked = true;
                if (Free=="No")
                    rbtnNo1.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbtnYes1.Checked)
                Free = "Yes";
            else if (rbtnNo1.Checked)
                Free = "No";
            bool check;
            if (No != "")
            {
                if (comboBoxType1.SelectedIndex == -1 || txtPhoneNo1.Text.Trim() == string.Empty || Free == "")
                    MessageBox.Show("please fill out all fields.", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    check = db.UpdateRoom(No, comboBoxType1.SelectedItem.ToString(), txtPhoneNo1.Text.Trim(), Free);
                    if (check)
                        Clear1();
                }
            }
            else
            {
                MessageBox.Show("please first select row from table.", "selection of row",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool check;
            if (No != "")
            {
                if (comboBoxType1.SelectedIndex == -1 || txtPhoneNo1.Text.Trim() == string.Empty || Free == "")
                    MessageBox.Show("please fill out all fields.", "Require all field", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    DialogResult result = MessageBox.Show("Are you want to delete this room?", "Room Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (DialogResult.Yes == result)
                    {
                        check = db.DeleteRoom(No);
                        if (check)
                            Clear1();
                    }
                }
            }
            else
                MessageBox.Show("please first select row from table.", "selection of row", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn chặn ký tự được nhập vào TextBox
            }
        }

        private void txtSearchRoomNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }


    }
}
