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
    public partial class UserControlDashboard : UserControl
    {
        DbConnector db;
        public UserControlDashboard()
        {
            InitializeComponent();
            db = new DbConnector();
        }

        public void User()
        {
            labelUsercount.Text = db.Count("SELECT COUNT (*) FROM User_Table").ToString();
        }
        public void Client()
        {
            labelClientcount.Text = db.Count("SELECT COUNT (*) FROM Client_Table").ToString();
        }
        public void Room()
        {
            labelRoomCount.Text = db.Count("SELECT COUNT (*) FROM Room_Table").ToString();
        }

        private void UserControlDashboard_Load(object sender, EventArgs e)
        {
            User();
            Client();
            Room();
        }
    }
}
