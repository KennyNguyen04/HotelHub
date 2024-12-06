using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Hotel_Management_System
{
    public partial class FormLogin : Form
    {

        DbConnector db;
        public FormLogin()
        {
            InitializeComponent();

            db = new DbConnector();

        }

        private void pictureBoxMinimize_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxMinimize, "Minimize");
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Close");
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBoxMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            int cornerRadius = 10;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            path.AddArc(btnlogin.Width - cornerRadius * 2, 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            path.AddArc(btnlogin.Width - cornerRadius * 2, btnlogin.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            path.AddArc(0, btnlogin.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
            path.CloseFigure();
            btnlogin.Region = new Region(path);

            // Bo tròn pictureBoxMinimize
            GraphicsPath pathMinimize = new GraphicsPath();
            pathMinimize.AddEllipse(0, 0, pictureBoxMinimize.Width - 1, pictureBoxMinimize.Height - 1);
            pictureBoxMinimize.Region = new Region(pathMinimize);

            // Bo tròn pictureBoxClose
            GraphicsPath pathClose = new GraphicsPath();
            pathClose.AddEllipse(0, 0, pictureBoxClose.Width - 2, pictureBoxClose.Height - 2);
            pictureBoxClose.Region = new Region(pathClose);
        }


        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Show Password");
        }


        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxClose, "Hide Password");
        }
        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            txtPassword.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            pictureBoxHide.Show();
            txtPassword.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            bool check = db.IsValidNamePass(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (txtUsername.Text.Trim() == string.Empty || txtPassword.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please fill out all field.", "Required field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (check)
                {
                    FormDashboard fd = new FormDashboard(); 
                    fd.Show();  
                }
                else {
                    MessageBox.Show("Invalid Username or Password", "Username or Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
