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
    public partial class LibarianAddBookForm : Form
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
        public LibarianAddBookForm(LibarianMain libarianMain)
        {
            InitializeComponent();
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
                LibarianAddBookForm.ReleaseCapture();
                LibarianAddBookForm.SendMessage(Handle, LibarianAddBookForm.WM_NCLBUTTONDOWN, LibarianAddBookForm.HT_CAPTION, 0);
            }
        }
 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text.Trim() != "" && Double.TryParse(txtBookFee.Text.Trim(), out _) && Int32.TryParse(txtNumberOfCopies.Text.Trim(), out _) && Int32.TryParse(txtNumberOfPages.Text.Trim(), out _))
            {

               
                String new_bookName = txtBookName.Text.Trim();
                String new_bookFee = txtBookFee.Text.Trim();
                String new_bookNumberOfCopies = txtNumberOfCopies.Text.Trim();
                String new_bookNumberOfPages = txtNumberOfPages.Text.Trim();
                String new_bookProductDate = releaseDate.Value.ToString("yyyy-MM-dd HH:mm:ss.ff");
                String new_bookDescription = txtDescription.Text.ToString();
                String new_bookImage = "";
                String new_bookIsnew = "0";
                if (checkNew.Checked)
                {
                    new_bookIsnew = "1";
                }
                String addBook_sql = "INSERT INTO Book (BookName, BookNumberOfPages, BookProductDate, BookNumberOfCopies, BookDescription, BookFee, BookImage, BookIsNew) VALUES ('" + new_bookName + "'," + new_bookNumberOfPages + ",'" + new_bookProductDate + "'," + new_bookNumberOfCopies + ",'" + new_bookDescription + "'," + new_bookFee + ",'" + new_bookImage + "'," + new_bookIsnew + ");";
                DatabaseConnection.CreateCommand(addBook_sql);
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
                MessageBox.Show("Add successful");
                libarianMain.LibarianMain_Load(sender,e);
                this.Close();
            }
            else
            {
                MessageBox.Show("Incorect input!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LibarianAddBookForm_Load(object sender, EventArgs e)
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
            for (int i = 0; i < list_author.Count; i++) {
                checkListAuthor.Items.Insert(i, list_author[i].AuthorName.ToString());
            }
            for (int i = 0; i < list_genre.Count; i++)
            {
                checkListGenre.Items.Insert(i,list_genre[i].GenreName.ToString());
            }
            for (int i = 0; i < list_publisher.Count; i++)
            {
                checkedListPublisher.Items.Insert(i, list_publisher[i].PublisherName.ToString());
            }
        }
    }
}
