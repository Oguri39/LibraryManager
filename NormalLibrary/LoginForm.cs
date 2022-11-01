using NormalLibrary.Libarian;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormalLibrary
{
    public partial class LoginForm : Form
    {
        public static int screenSize = 0;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public LoginForm()
        {
            InitializeComponent();
            if (screenSize == 1)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (screenSize == 0)
            {
                screenSize = 1;
                this.WindowState = FormWindowState.Maximized;
                
            }
            else
            {
                screenSize = 0;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void loginTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
               ReleaseCapture();
               SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Firebrick;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Black;
        }
        private void btnSignup_MouseHover(object sender, EventArgs e)
        {
            btnSignup.ForeColor = Color.Firebrick;
        }

        private void btnSignup_MouseLeave(object sender, EventArgs e)
        {
            btnSignup.ForeColor = Color.Black;
        }

        private void btnSubmit_MouseHover(object sender, EventArgs e)
        {
            btnSubmit.ForeColor = Color.Firebrick;
        }

        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.ForeColor = Color.Black;
        }
        private void btnForgetPasswordLoginForm_Click(object sender, EventArgs e)
        {
            panelForgotPassword.Visible = true;
            panelLogin.Visible = false;
        }

        private void btnSignupLoginForm_Click(object sender, EventArgs e)
        {
            panelSignup.Visible = true;
            panelLogin.Visible=false;
        }

        private void btnLoginForgetPasswordForm_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelForgotPassword.Visible=false;
        }

        private void btnSignupForgetPasswordForm_Click(object sender, EventArgs e)
        {
            panelSignup.Visible=true;
            panelForgotPassword.Visible = false;
        }


        private void btnForgetPasswordSignupForm_Click(object sender, EventArgs e)
        {
            panelForgotPassword.Visible = true;
            panelSignup.Visible = false;
        }

        private void btnLoginSignupForm_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelSignup.Visible = false;
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserIDLoginForm.Text.Trim();
            string userPassword = txtPasswordLoginForm.Text.Trim();
            if(userName == "" || userPassword == "")
            {
                MessageBox.Show("Please enter correct username and password");
            }
            else
            {
                if (DatabaseConnection.CheckUserLogin(userName, userPassword))
                {
                    if (Program.login_user.UserApproved == 0)
                    {
                        MessageBox.Show("Your account need verify... Please contact the library");
                    }
                    else {
                        if (Program.login_user.UserRoles == 3)
                        {
                            Admin.AdminMain homeAdmin = new Admin.AdminMain();
                            homeAdmin.Show();
                            if (homeAdmin != null)
                            {
                                this.Hide();
                            }
                        }
                        else if (Program.login_user.UserRoles == 2)
                        {
                            Libarian.LibarianMain homeLibarian = new Libarian.LibarianMain();
                            homeLibarian.Show();
                            if (homeLibarian != null)
                            {
                                this.Hide();
                            }
                        }
                        else {
                            Students.MainStudents homeStudents = new Students.MainStudents();
                            homeStudents.Show();
                            if (homeStudents != null)
                            {
                                this.Hide();
                            }
                        }
                    }
                   
                }
                else {
                    MessageBox.Show("Please enter correct username and password");
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }


    }
}
