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


        private void btnAdd_Click(object sender, EventArgs e)
        {

        }


    }
}
