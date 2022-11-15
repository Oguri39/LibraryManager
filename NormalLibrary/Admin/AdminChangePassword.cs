using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormalLibrary.Admin
{
    public partial class AdminChangePassword : Form
    {
        public AdminChangePassword()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string current_password = txtCurrentPassword.Text.Trim();
            string new_password = txtNewPassword.Text.Trim();
            string confirm_password = txtConfirmPassword.Text.Trim();
            DialogResult rs = MessageBox.Show("Do you want to save?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (current_password == "" || new_password == "" || confirm_password == "")
                {
                    MessageBox.Show("Please enter correct password");
                }
                else
                {
                    if (DatabaseConnection.CheckUserLogin(Program.login_user.UserName, current_password))
                    {
                        if (new_password != confirm_password)
                        {
                            MessageBox.Show("Please enter correct password");
                        }
                        else
                        {
                            DatabaseConnection.CreateCommand("UPDATE [User] SET UserPassword = '" + new_password + "'  WHERE UserId = " + Program.login_user.UserId + ";");
                            MessageBox.Show("You have successful change password!");
                            this.Close();
                        }

                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
