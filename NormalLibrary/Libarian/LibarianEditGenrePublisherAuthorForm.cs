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
    public partial class LibarianEditGenrePublisherAuthorForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        String choice;
        LibarianMain libarianMain;
        int id;
        public LibarianEditGenrePublisherAuthorForm(String choice, LibarianMain libarianMain, int id)
        {
            InitializeComponent();
            this.choice = choice;
            this.libarianMain = libarianMain;
            this.id = id;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void windowTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LibarianEditGenrePublisherAuthorForm.ReleaseCapture();
                LibarianEditGenrePublisherAuthorForm.SendMessage(Handle, LibarianEditGenrePublisherAuthorForm.WM_NCLBUTTONDOWN, LibarianEditGenrePublisherAuthorForm.HT_CAPTION, 0);
            }
        }
        private void LibarianEditGenrePublisherAuthorForm_Load(object sender, EventArgs e)
        {
            if (choice == "Genre")
            {
                txtTittle.Text = "Edit Genre";
                txtName.Text = "Genre:";
                txtAddString.Text = DatabaseConnection.GetGenre("SELECT * FROM Genre WHERE GenreId = " + id).GenreName;
            }
            if (choice == "Author")
            {
                txtTittle.Text = "Edit Author";
                txtName.Text = "Author name:";
                txtAddString.Text = DatabaseConnection.GetAuthor("SELECT * FROM Genre WHERE AuthorId = " + id).AuthorName;

            }
            if (choice == "Publisher")
            {
                txtTittle.Text = "Edit Publisher";
                txtName.Text = "Publisher name:";
                txtAddString.Text = DatabaseConnection.GetPublisher("SELECT * FROM Genre WHERE PublisherId = " + id).PublisherName;

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtAddString.Text.Trim() != "")
            {

                if (choice == "Genre")
                {
                    DatabaseConnection.CreateCommand("UPDATE Genre SET GenreName = '" + txtAddString.Text.Trim() + "' WHERE GenreId = " + id);
                    MessageBox.Show("Edit successful");
                    libarianMain.LibarianMain_Load(sender, e);
                    this.Close();
                }
                if (choice == "Author")
                {
                    DatabaseConnection.CreateCommand("UPDATE Author SET AuthorName = '" + txtAddString.Text.Trim() + "' WHERE AuthorId = " + id);
                    MessageBox.Show("Edit successful");
                    libarianMain.LibarianMain_Load(sender, e);
                    this.Close();
                }
                if (choice == "Publisher")
                {
                    DatabaseConnection.CreateCommand("UPDATE Publisher SET PublisherName = '" + txtAddString.Text.Trim() + "' WHERE PublisherId = " + id);
                    MessageBox.Show("Edit successful");
                    libarianMain.LibarianMain_Load(sender, e);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Incorect input!");
            }
        }
    }
}
