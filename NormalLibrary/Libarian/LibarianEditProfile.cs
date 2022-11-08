using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormalLibrary.Libarian
{
    public partial class LibarianEditProfile : Form
    {
        LibrianProfile librianProfile;
        UserProfile user_profile;

        public LibarianEditProfile(LibrianProfile librianProfile)
        {
            InitializeComponent();
            this.librianProfile = librianProfile;
        }

        private void LibarianEditProfile_Load(object sender, EventArgs e)
        {
            user_profile = DatabaseConnection.GetUserProfile("SELECT * FROM Profile WHERE ProfileId = " + Program.login_user.ProfileId + ";");
            txtFirstName.Text = user_profile.ProfileFirstName;
            txtLastName.Text = user_profile.ProfileLastName;
            txtEmail.Text = user_profile.ProfileEmail;
            txtPhoneNumber.Text = user_profile.ProfilePhoneNumber;
            txtSchoolID.Text = user_profile.ProfileSchoolId;
            txtAddress.Text = user_profile.ProfileAddress;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Do you want to save?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                DatabaseConnection.CreateCommand("UPDATE Profile SET ProfileFirstName = '" + txtFirstName.Text +
                    "',ProfileLastName = '" + txtLastName.Text +
                     "',ProfileSchoolId = '" + txtSchoolID.Text +
                      "',ProfileAddress = '" + txtAddress.Text +
                       "',ProfilePhoneNumber = '" + txtPhoneNumber.Text +
                       "',ProfileEmail = '" + txtEmail.Text +
                    "'  WHERE ProfileId = " + user_profile.ProfileId + ";");
                MessageBox.Show("You have successful edit!");
                librianProfile.LibrianProfile_Load(sender, e);
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
