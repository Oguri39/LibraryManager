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
    public partial class LibarianMain : Form
    {
        private int screenSize = 0;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public LibarianMain()
        {
            InitializeComponent();
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

        private void windowTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                LibarianMain.ReleaseCapture();
                LibarianMain.SendMessage(Handle, LibarianMain.WM_NCLBUTTONDOWN, LibarianMain.HT_CAPTION, 0);
            }
        }

        public void LibarianMain_Load(object sender, EventArgs e)
        {
            load_library();
            load_genre();
            load_author();
            load_publisher();
            load_return();
            load_borrowed();
        }
        private void load_library() {
            dgvLibrary.DataSource = DatabaseConnection.GetDataTable("SELECT Book.BookId, Book.BookName, Book.BookNumberOfPages, Book.BookProductDate, Book.BookNumberOfCopies,Book.BookFee,Book.BookIsNew,Genre.GenreName,Author.AuthorName FROM Book JOIN BookHasGenre ON Book.BookId = BookHasGenre.BookId JOIN Genre ON Genre.GenreId = BookHasGenre.GenreId JOIN AuthorHasBooks  ON Book.BookId = AuthorHasBooks.BookId JOIN Author  ON Author.AuthorId = AuthorHasBooks.AuthorId");

        }
        private void load_genre() {
            dgvGenre.DataSource = DatabaseConnection.GetDataTable("SELECT * FROM Genre");

        }
        private void load_publisher()
        {
            dgvPublisher.DataSource = DatabaseConnection.GetDataTable("SELECT * FROM Publisher");

        }
        private void load_author() {
            dgvAuthor.DataSource = DatabaseConnection.GetDataTable("SELECT * FROM Author");

        }
        private void load_return() { 
            dgvAskingReturn.DataSource = DatabaseConnection.GetDataTable("SELECT Profile.ProfileFirstName, Profile.ProfileLastName, Profile.ProfileSchoolId, Book.BookName, Book.BookFee, BorrowReciept.BorrowRecieptBorrowedDate, BorrowReciept.BorrowRecieptDeadline, BorrowReciept.BorrowRecieptQuantity FROM Profile JOIN [User]  ON Profile.ProfileId = [User].ProfileId  JOIN UserHasBorrowReciept ON [User].UserId = UserHasBorrowReciept.UserId  JOIN BorrowReciept  ON BorrowReciept.BorrowRecieptId = UserHasBorrowReciept.BorrowRecieptId  JOIN Book  ON Book.BookId = BorrowReciept.BookId Where UserHasBorrowReciept.UserHasBorrowRecieptIsAskingForCheck = 1;");
        }
        private void load_borrowed()
        {

            dgvCurrentlyBorrowed.DataSource = DatabaseConnection.GetDataTable("SELECT Profile.ProfileFirstName, Profile.ProfileLastName, Profile.ProfileSchoolId, Book.BookName, Book.BookFee, BorrowReciept.BorrowRecieptBorrowedDate, BorrowReciept.BorrowRecieptDeadline, BorrowReciept.BorrowRecieptQuantity FROM Profile JOIN [User]  ON Profile.ProfileId = [User].ProfileId  JOIN UserHasBorrowReciept ON [User].UserId = UserHasBorrowReciept.UserId  JOIN BorrowReciept  ON BorrowReciept.BorrowRecieptId = UserHasBorrowReciept.BorrowRecieptId  JOIN Book  ON Book.BookId = BorrowReciept.BookId Where UserHasBorrowReciept.UserHasBorrowRecieptIsAskingForCheck = 0;");

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LibrianProfile new_form = new LibrianProfile(this);
            new_form.Show();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            LibarianAddBookForm new_form = new LibarianAddBookForm(this);
            new_form.Show();
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {

        }
    }
}
