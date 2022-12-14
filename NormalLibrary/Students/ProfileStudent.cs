using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormalLibrary.Students
{

    public partial class ProfileStudent : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        MainStudents tmp_main;
        UserProfile user_profile;
        public ProfileStudent(MainStudents tmp_main)
        {
            InitializeComponent();
            this.tmp_main = tmp_main;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void profileTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProfile new_form = new EditProfile(this);
            new_form.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login_form = new LoginForm();
            login_form.Show();
            Program.login_user = null;
            tmp_main.Close();
            this.Close();
        }

        public void ProfileStudent_Load(object sender, EventArgs e)
        {
            user_profile = DatabaseConnection.GetUserProfile("SELECT * FROM Profile WHERE ProfileId = " + Program.login_user.ProfileId + ";");
            txtFirstName.Text = user_profile.ProfileFirstName;
            txtLastName.Text = user_profile.ProfileLastName;
            txtEmail.Text = user_profile.ProfileEmail;
            txtPhoneNumber.Text = user_profile.ProfilePhoneNumber;
            txtSchoolID.Text = user_profile.ProfileSchoolId;
            txtAddress.Text = user_profile.ProfileAddress;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword new_form = new ChangePassword();
            new_form.Show();
        }
    }
}
