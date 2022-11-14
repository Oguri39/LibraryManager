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
    public partial class LibarianEditBookForm : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        List<Author> list_author = new List<Author>();
        List<Genre> list_genre = new List<Genre>();
        List<Publisher> list_publisher = new List<Publisher>();
        LibarianMain libarianMain;
        private int id;
        public LibarianEditBookForm(int id, LibarianMain libarianMain)
        {
            InitializeComponent();
            this.id = id;
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
                LibarianEditBookForm.ReleaseCapture();
                LibarianEditBookForm.SendMessage(Handle, LibarianEditBookForm.WM_NCLBUTTONDOWN, LibarianEditBookForm.HT_CAPTION, 0);
            }
        }

        private void LibarianEditBookForm_Load(object sender, EventArgs e)
        {
            checkListGenre.Items.Clear();
            checkListAuthor.Items.Clear();
            checkedListPublisher.Items.Clear();
            list_author.Clear();
            list_genre.Clear();
            list_publisher.Clear();
            list_author = DatabaseConnection.GetAuthorList("SELECT * FROM Author;");
            list_genre = DatabaseConnection.GetGenreList("SELECT * FROM Genre;");
            list_publisher = DatabaseConnection.GetPublisherList("SELECT * FROM Publisher;");
            for (int i = 0; i < list_author.Count; i++)
            {
                checkListAuthor.Items.Insert(i, list_author[i].AuthorName.ToString());
            }
            for (int i = 0; i < list_genre.Count; i++)
            {
                checkListGenre.Items.Insert(i, list_genre[i].GenreName.ToString());
            }
            for (int i = 0; i < list_publisher.Count; i++)
            {
                checkedListPublisher.Items.Insert(i, list_publisher[i].PublisherName.ToString());
            }
            Book current_book = new Book();
            current_book = DatabaseConnection.GetBook("SELECT * FROM Book WHERE Book.BookId = " + id + ";");
            List<Author> list_current_author = new List<Author>();
            List<Genre> list_current_genre = new List<Genre>();
            List<Publisher> list_current_publisher = new List<Publisher>();
            list_current_genre = DatabaseConnection.GetGenreList("SELECT * FROM Book JOIN BookHasGenre ON Book.BookId = BookHasGenre.BookId JOIN Genre ON Genre.GenreId = BookHasGenre.GenreId WHERE Book.BookId = " + id + ";");
            list_current_author = DatabaseConnection.GetAuthorList("SELECT * FROM Book JOIN AuthorHasBooks  ON Book.BookId = AuthorHasBooks.BookId JOIN Author  ON Author.AuthorId = AuthorHasBooks.AuthorId WHERE Book.BookId = " + id + ";");
            list_current_publisher = DatabaseConnection.GetPublisherList("SELECT * FROM Book JOIN PublisherHasBooks  ON Book.BookId = PublisherHasBooks.BookId JOIN Publisher ON Publisher.PublisherId = PublisherHasBooks.PublisherId WHERE Book.BookId = " + id + ";");
            for (int i = 0; i < list_current_author.Count; i++)
            {
                for (int j = 0; j < list_author.Count; j++)
                {
                    if (list_author[j].AuthorId == list_current_author[i].AuthorId)
                    {
                        checkListAuthor.SetItemChecked(j, true);
                    }
                }
            }
            for (int i = 0; i < list_current_genre.Count; i++)
            {
                for (int j = 0; j < list_genre.Count; j++)
                {
                    if (list_genre[j].GenreId == list_current_genre[i].GenreId)
                    {
                        checkListGenre.SetItemChecked(j, true);
                    }
                }
            }
            for (int i = 0; i < list_current_publisher.Count; i++)
            {
                for (int j = 0; j < list_publisher.Count; j++)
                {
                    if (list_publisher[j].PublisherId == list_current_publisher[i].PublisherId)
                    {
                        checkedListPublisher.SetItemChecked(j, true);
                    }
                }
            }
            txtBookName.Text = current_book.BookName;
            txtNumberOfCopies.Text = current_book.BookFee.ToString();
            txtNumberOfPages.Text = current_book.BookNumberOfPages.ToString();
            txtBookFee.Text = current_book.BookFee.ToString();
            txtDescription.Text = current_book.BookDescription.ToString();
            releaseDate.Value = DateTime.Parse(current_book.BookProductDate);
            checkNew.Checked = current_book.BookIsNew == 1 ? true : false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text.Trim() != "" && Double.TryParse(txtBookFee.Text.Trim(), out _) && Int32.TryParse(txtNumberOfCopies.Text.Trim(), out _) && Int32.TryParse(txtNumberOfPages.Text.Trim(), out _))
            {
                String new_bookName = txtBookName.Text.Trim();
                String new_bookFee = txtBookFee.Text.Trim();
                int new_bookNumberOfCopies = Int32.Parse(txtNumberOfCopies.Text.Trim());
                int new_bookNumberOfPages = Int32.Parse(txtNumberOfPages.Text.Trim());
                String new_bookProductDate = releaseDate.Value.ToString("yyyy-MM-dd HH:mm:ss.ff");
                String new_bookDescription = txtDescription.Text.ToString();
                String new_bookImage = "";
                String new_bookIsnew = "0";
                if (checkNew.Checked)
                {
                    new_bookIsnew = "1";
                }
                String addBook_sql = "UPDATE Book SET " +
                    " BookName = '" + new_bookName +
                    "', BookNumberOfPages = " + new_bookNumberOfPages +
                    ", BookProductDate = '" + new_bookProductDate +
                    "', BookNumberOfCopies = " + new_bookNumberOfCopies +
                    ", BookDescription = '" + new_bookDescription +
                    "', BookFee = " + new_bookFee +
                    ", BookImage = '" + new_bookImage +
                    "', BookIsNew = " + new_bookIsnew +
                    " WHERE BookId = " + id + ";";
                DatabaseConnection.CreateCommand(addBook_sql);
                DatabaseConnection.CreateCommand("DELETE FROM AuthorHasBooks WHERE AuthorHasBooks.BookId = " + id);
                DatabaseConnection.CreateCommand("DELETE FROM BookHasGenre WHERE BookHasGenre.BookId = " + id);
                DatabaseConnection.CreateCommand("DELETE FROM PublisherHasBooks WHERE PublisherHasBooks.BookId = " + id);

                int newBookId = DatabaseConnection.GetAddBookId();
                for (int i = 0; i < checkListGenre.Items.Count; i++)
                {
                    if (checkListGenre.GetItemChecked(i))
                    {
                        String addBookHasGenre_sql = "INSERT INTO BookHasGenre (BookId,GenreId) VALUES (" + newBookId + "," + list_genre[i].GenreId + ");";
                        DatabaseConnection.CreateCommand(addBookHasGenre_sql);

                    }
                }
                for (int i = 0; i < checkListAuthor.Items.Count; i++)
                {
                    if (checkListAuthor.GetItemChecked(i))
                    {
                        String addAuthorHasBook_sql = "INSERT INTO AuthorHasBooks (BookId,AuthorId) VALUES (" + newBookId + "," + list_author[i].AuthorId + ");";
                        DatabaseConnection.CreateCommand(addAuthorHasBook_sql);

                    }
                }
                for (int i = 0; i < checkedListPublisher.Items.Count; i++)
                {
                    if (checkedListPublisher.GetItemChecked(i))
                    {
                        String addPublisherHasBook_sql = "INSERT INTO PublisherHasBooks (BookId,PublisherId) VALUES (" + newBookId + "," + list_publisher[i].PublisherId + ");";
                        DatabaseConnection.CreateCommand(addPublisherHasBook_sql);
                    }
                }
                MessageBox.Show("Edit successful");
                libarianMain.LibarianMain_Load(sender, e);
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorect input!");
            }
        }
    }
}
