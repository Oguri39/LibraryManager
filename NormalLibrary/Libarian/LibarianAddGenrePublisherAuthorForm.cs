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
    public partial class LibarianAddGenrePublisherAuthorForm : Form
    {
        
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        String choice;
        LibarianMain libarianMain;
        public LibarianAddGenrePublisherAuthorForm(String choice, LibarianMain libarianMain)
        {
            InitializeComponent();
            this.choice = choice;
            this.libarianMain = libarianMain;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void windowTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LibarianAddGenrePublisherAuthorForm.ReleaseCapture();
                LibarianAddGenrePublisherAuthorForm.SendMessage(Handle, LibarianAddGenrePublisherAuthorForm.WM_NCLBUTTONDOWN, LibarianAddGenrePublisherAuthorForm.HT_CAPTION, 0);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAddString.Text.Trim() != "")
            {

                if (choice == "Genre")
                {
                    DatabaseConnection.CreateCommand("INSERT INTO Genre (GenreName) VALUES ('" + txtAddString.Text.Trim() + "')");
                    MessageBox.Show("Add successful");
                    libarianMain.LibarianMain_Load(sender, e);
                    this.Close();
                }
                if (choice == "Author")
                {
                    DatabaseConnection.CreateCommand("INSERT INTO Author (AuthorName) VALUES ('" + txtAddString.Text.Trim() + "')");
                    MessageBox.Show("Add successful");
                    libarianMain.LibarianMain_Load(sender, e);
                    this.Close();
                }
                if (choice == "Publisher")
                {
                    DatabaseConnection.CreateCommand("INSERT INTO Publisher (PublisherName) VALUES ('" + txtAddString.Text.Trim() + "')");
                    MessageBox.Show("Add successful");
                    libarianMain.LibarianMain_Load(sender, e);
                    this.Close();
                }
            }
            else {
                MessageBox.Show("Incorect input!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LibarianAddGenrePublisherAuthorForm_Load(object sender, EventArgs e)
        {
            if (choice == "Genre") {
                txtTittle.Text = "Add Genre";
                txtName.Text = "Genre:";
            }
            if (choice == "Author") {
                txtTittle.Text = "Add Author";
                txtName.Text = "Author name:";
            }
            if (choice == "Publisher") {
                txtTittle.Text = "Add Publisher";
                txtName.Text = "Publisher name:";
            }
        }
    }
}
