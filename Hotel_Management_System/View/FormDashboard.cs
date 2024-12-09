using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class FormDashboard : Form
    {
        public string Username;
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void linkLabelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Do you want to Log Out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                timer1.Stop();
                this.Close();
            }
        }

        private void movePanel(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelDateTime.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            labelUser.Text = Username;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            movePanel(btnDashboard);
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            movePanel(btnClient);
        }

        private void btnRoom_Click(object sender, EventArgs e)
        {
            movePanel(btnRoom);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            movePanel(btnReservation);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            movePanel(btnSetting);
        }
    }
}
