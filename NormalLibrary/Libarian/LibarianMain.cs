using NormalLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
        private int book_cell_click_id = -1;
        private int author_cell_click_id = -1;
        private int genre_cell_click_id = -1;
        private int publisher_cell_click_id = -1;
        private int askingReturn_cell_click_id = -1;
        private int currentlyBorrowed_cell_click_id =-1;

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
            load_books();
        }
        private void load_library() {
            dgvLibrary.DataSource = DatabaseConnection.GetDataTable("SELECT Book.BookId, Book.BookName, Book.BookNumberOfPages, Book.BookProductDate, Book.BookNumberOfCopies,Book.BookFee,Book.BookIsNew,Genre.GenreName,Author.AuthorName FROM Book JOIN BookHasGenre ON Book.BookId = BookHasGenre.BookId JOIN Genre ON Genre.GenreId = BookHasGenre.GenreId JOIN AuthorHasBooks  ON Book.BookId = AuthorHasBooks.BookId JOIN Author  ON Author.AuthorId = AuthorHasBooks.AuthorId WHERE Book.BookIsDeleted = 0");

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
            dgvAskingReturn.DataSource = DatabaseConnection.GetDataTable("SELECT BorrowReciept.BorrowRecieptId, Profile.ProfileFirstName, Profile.ProfileLastName, Profile.ProfileSchoolId, Book.BookName, Book.BookFee, BorrowReciept.BorrowRecieptBorrowedDate, BorrowReciept.BorrowRecieptDeadline, BorrowReciept.BorrowRecieptQuantity FROM Profile JOIN [User]  ON Profile.ProfileId = [User].ProfileId  JOIN UserHasBorrowReciept ON [User].UserId = UserHasBorrowReciept.UserId  JOIN BorrowReciept  ON BorrowReciept.BorrowRecieptId = UserHasBorrowReciept.BorrowRecieptId  JOIN Book  ON Book.BookId = BorrowReciept.BookId Where UserHasBorrowReciept.UserHasBorrowRecieptIsAskingForCheck = 1;");
        }
        private void load_borrowed()
        {

            dgvCurrentlyBorrowed.DataSource = DatabaseConnection.GetDataTable("SELECT BorrowReciept.BorrowRecieptId, Profile.ProfileFirstName, Profile.ProfileLastName, Profile.ProfileSchoolId, Book.BookName, Book.BookFee, BorrowReciept.BorrowRecieptBorrowedDate, BorrowReciept.BorrowRecieptDeadline, BorrowReciept.BorrowRecieptQuantity FROM Profile JOIN [User]  ON Profile.ProfileId = [User].ProfileId  JOIN UserHasBorrowReciept ON [User].UserId = UserHasBorrowReciept.UserId  JOIN BorrowReciept  ON BorrowReciept.BorrowRecieptId = UserHasBorrowReciept.BorrowRecieptId  JOIN Book  ON Book.BookId = BorrowReciept.BookId Where UserHasBorrowReciept.UserHasBorrowRecieptIsAskingForCheck = 0;");

        }
        private void load_books() {
            dgvLibraryBook.DataSource = DatabaseConnection.GetDataTable("SELECT * FROM Book WHERE Book.BookIsDeleted = 0");
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
            if (book_cell_click_id != -1) { 
                LibarianEditBookForm new_form = new LibarianEditBookForm(book_cell_click_id, this);
                new_form.Show();
                book_cell_click_id = -1;
            }
            else
            {

                MessageBox.Show("Please select book to edit");
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (book_cell_click_id != -1)
            {
                if (DatabaseConnection.CheckIfBookIsBorrowed(book_cell_click_id))
                {
                    MessageBox.Show("Book is currently borrowed");
                }
                else { 
                    DatabaseConnection.CreateCommand("UPDATE Book SET Book.BookIsDeleted = 1 WHERE BookId = " + book_cell_click_id);
                    DatabaseConnection.CreateCommand("DELETE FROM AuthorHasBooks WHERE BookId = " + book_cell_click_id);
                    DatabaseConnection.CreateCommand("DELETE FROM BookHasGenre WHERE BookId = " + book_cell_click_id);
                    DatabaseConnection.CreateCommand("DELETE FROM PublisherHasBooks WHERE BookId = " + book_cell_click_id);
                    book_cell_click_id = -1;
                    load_library();
                    load_genre();
                    load_author();
                    load_publisher();
                    load_return();
                    load_borrowed();
                    load_books();
                }
            }
            else
            {

                MessageBox.Show("Please select book to delete");
            }
        }

        private void dgvLibrary_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLibrary.Rows[e.RowIndex];
                if (row.Cells[0].Value.ToString() != "")
                {
                    book_cell_click_id = Int32.Parse(row.Cells[0].Value.ToString());
                }
            }
        }

        private void dgvLibraryBook_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLibraryBook.Rows[e.RowIndex];
                if (row.Cells[0].Value.ToString() != "") { 
                    book_cell_click_id = Int32.Parse(row.Cells[0].Value.ToString());  
                }
            }
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            LibarianAddGenrePublisherAuthorForm new_form = new LibarianAddGenrePublisherAuthorForm("Genre",this);
            new_form.Show();
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            LibarianAddGenrePublisherAuthorForm new_form = new LibarianAddGenrePublisherAuthorForm("Publisher", this);
            new_form.Show();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            LibarianAddGenrePublisherAuthorForm new_form = new LibarianAddGenrePublisherAuthorForm("Author", this);
            new_form.Show();
        }

        private void btnEditGenre_Click(object sender, EventArgs e)
        {
            LibarianEditGenrePublisherAuthorForm new_form = new LibarianEditGenrePublisherAuthorForm("Genre", this, genre_cell_click_id);
            new_form.Show();
        }

        private void btnEditPublisher_Click(object sender, EventArgs e)
        {
            LibarianEditGenrePublisherAuthorForm new_form = new LibarianEditGenrePublisherAuthorForm("Publisher", this, publisher_cell_click_id);
            new_form.Show();
        }

        private void btnEditAuthor_Click(object sender, EventArgs e)
        {
            LibarianEditGenrePublisherAuthorForm new_form = new LibarianEditGenrePublisherAuthorForm("Author", this, author_cell_click_id);
            new_form.Show();
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            if (genre_cell_click_id != -1)
            {
                DatabaseConnection.CreateCommand("DELETE FROM Genre WHERE GenreId = " + genre_cell_click_id);
                DatabaseConnection.CreateCommand("DELETE FROM BookHasGenre WHERE GenreId = " + genre_cell_click_id);
                genre_cell_click_id = -1;
                load_library();
                load_genre();
                load_author();
                load_publisher();
                load_return();
                load_borrowed();
                load_books();
            }
            else
            {
                MessageBox.Show("Please select genre to delete");
            }
        }

        private void btnDeletePublisher_Click(object sender, EventArgs e)
        {
            if (publisher_cell_click_id != -1)
            {
                DatabaseConnection.CreateCommand("DELETE FROM Publisher WHERE PublisherId = " + publisher_cell_click_id);
                DatabaseConnection.CreateCommand("DELETE FROM PublisherHasBooks WHERE PublisherId = " + publisher_cell_click_id);
                publisher_cell_click_id = -1;
                load_library();
                load_genre();
                load_author();
                load_publisher();
                load_return();
                load_borrowed();
                load_books();
            }
            else
            {
                MessageBox.Show("Please select publisher to delete");
            }
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            if (author_cell_click_id != -1)
            {
                DatabaseConnection.CreateCommand("DELETE FROM Author WHERE AuthorId = " + author_cell_click_id);
                DatabaseConnection.CreateCommand("DELETE FROM AuthorHasBooks WHERE AuthorId = " + author_cell_click_id);
                author_cell_click_id = -1;
                load_library();
                load_genre();
                load_author();
                load_publisher();
                load_return();
                load_borrowed();
                load_books();
            }
            else
            {
                MessageBox.Show("Please select author to delete");
            }
        }

        private void dgvGenre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGenre.Rows[e.RowIndex];
                if (row.Cells[0].Value.ToString() != "")
                {
                    genre_cell_click_id = Int32.Parse(row.Cells[0].Value.ToString());
                }
            }
        }

        private void dgvPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPublisher.Rows[e.RowIndex];
                if (row.Cells[0].Value.ToString() != "")
                {
                    publisher_cell_click_id = Int32.Parse(row.Cells[0].Value.ToString());
                }
            }
        }

        private void dgvAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAuthor.Rows[e.RowIndex];
                if (row.Cells[0].Value.ToString() != "")
                {
                    author_cell_click_id = Int32.Parse(row.Cells[0].Value.ToString());
                }
            }
        }

        private void dgvAskingReturn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAskingReturn.Rows[e.RowIndex];
                if (row.Cells[0].Value.ToString() != "")
                {
                    askingReturn_cell_click_id = Int32.Parse(row.Cells[0].Value.ToString());
                }
            }
        }

        private void dgvCurrentlyBorrowed_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCurrentlyBorrowed.Rows[e.RowIndex];
                if (row.Cells[0].Value.ToString() != "")
                {
                    currentlyBorrowed_cell_click_id = Int32.Parse(row.Cells[0].Value.ToString());
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (askingReturn_cell_click_id != -1)
            {
                String ReturnDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.ff");
                BorrowReciept borrowReciept = DatabaseConnection.GetBorrowReciept("SELECT * FROM BorrowReciept WHERE BorrowRecieptId = " + askingReturn_cell_click_id);
                Console.WriteLine(askingReturn_cell_click_id);
                DateTime StartDate = DateTime.Parse(borrowReciept.BorrowRecieptBorrowedDate.Trim());
                DateTime CurrentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                Book book = DatabaseConnection.GetBook("SELECT * FROM Book WHERE BookId = " + borrowReciept.BookId);
                double totalDays = (CurrentDate - StartDate).TotalDays + 1.0;
                double total = ((CurrentDate - StartDate).TotalDays + 1.0) * book.BookFee;
                DialogResult rs = MessageBox.Show("Do you want to accept return?\nDays borrowed: " + totalDays +"\nTotal Fee: " + total, "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                { 
                    DatabaseConnection.CreateCommand("UPDATE BorrowReciept SET BorrowRecieptIsReturned = "+ 1 +" WHERE BorrowRecieptId = " + askingReturn_cell_click_id);
                    DatabaseConnection.CreateCommand("INSERT INTO PaymentRecord (BorrowRecieptId, PaymentRecordDateRecieve, PaymentRecordRecieved) VALUES ("+ askingReturn_cell_click_id + ",'" + ReturnDate + "'," + total + ")");
                    DatabaseConnection.CreateCommand("DELETE FROM UserHasBorrowReciept WHERE BorrowRecieptId = " + askingReturn_cell_click_id);
                
                }
                askingReturn_cell_click_id = -1;
                load_library();
                load_genre();
                load_author();
                load_publisher();
                load_return();
                load_borrowed();
                load_books();
            }
            else
            {
                MessageBox.Show("Please select reciept to accept");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (currentlyBorrowed_cell_click_id != -1)
            {
                DatabaseConnection.CreateCommand("DELETE FROM UserHasBorrowReciept WHERE BorrowRecieptId = " + currentlyBorrowed_cell_click_id);
                DatabaseConnection.CreateCommand("DELETE FROM BorrowReciept WHERE BorrowRecieptId = " + currentlyBorrowed_cell_click_id);
                currentlyBorrowed_cell_click_id = -1;
                load_library();
                load_genre();
                load_author();
                load_publisher();
                load_return();
                load_borrowed();
                load_books();
            }
            else
            {
                MessageBox.Show("Please select author to delete");
            }
        }
    }
}
