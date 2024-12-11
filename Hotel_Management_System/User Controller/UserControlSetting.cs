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
           
        }
    }
}
