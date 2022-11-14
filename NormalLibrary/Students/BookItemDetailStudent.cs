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
    public partial class BookItemDetailStudent : Form
    {
        private int screenSize = 0;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private int _id;
        private string _name;
        private string _author;
        private string _publisher;
        private string _genre;
        private string _image;
        private double _price;
        private string _description;
        private int _isnew;
        private int _numofpage;
        private int _numofcopy;
        private int _numofcopyleft;
        private string _productdate;
        public BookItemDetailStudent(int _id)
        {
            this._id = _id;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
                BookItemDetailStudent.ReleaseCapture();
                BookItemDetailStudent.SendMessage(Handle, BookItemDetailStudent.WM_NCLBUTTONDOWN, BookItemDetailStudent.HT_CAPTION, 0);
            }
        }

        private void BookItemDetailStudent_Load(object sender, EventArgs e)
        {
            screenSize = 0;
            this.WindowState = FormWindowState.Normal;
            FormLoad();
        }
        private void FormLoad() {
            Book book = new Book();
            book = DatabaseConnection.GetBook("SELECT * FROM Book WHERE BookId = " + _id + ";");
            List<Genre> list_genre = new List<Genre>();
            List<Author> list_author = new List<Author>();
            List<Publisher> list_publisher = new List<Publisher>();
            list_genre = DatabaseConnection.GetGenreList("SELECT * FROM Book JOIN BookHasGenre ON Book.BookId = BookHasGenre.BookId JOIN Genre ON Genre.GenreId = BookHasGenre.GenreId WHERE Book.BookId = " + _id + ";");
            list_author = DatabaseConnection.GetAuthorList("SELECT * FROM Book JOIN AuthorHasBooks  ON Book.BookId = AuthorHasBooks.BookId JOIN Author  ON Author.AuthorId = AuthorHasBooks.AuthorId WHERE Book.BookId = " + _id + ";");
            list_publisher = DatabaseConnection.GetPublisherList("SELECT * FROM Book JOIN PublisherHasBooks  ON Book.BookId = PublisherHasBooks.BookId JOIN Publisher ON Publisher.PublisherId = PublisherHasBooks.PublisherId WHERE Book.BookId = " + _id + ";");

            string new_genre = "";
            string new_author = "";
            string new_publisher = "";
            for (int j = 0; j < list_genre.Count; j++)
            {
                new_genre = new_genre + list_genre[j].GenreName + "; ";
            }
            for (int j = 0; j < list_author.Count; j++)
            {
                new_author = new_author + list_author[j].AuthorName + "; ";
            }
            for (int j = 0; j < list_publisher.Count; j++)
            {
                new_publisher = new_publisher + list_publisher[j].PublisherName + "; ";
            }
            _name = book.BookName;
            _author = new_author;
            _publisher = new_publisher;
            _genre = new_genre;
            _image = book.BookImage;
            _price = book.BookFee;
            _description = book.BookDescription;
            _isnew = book.BookIsNew;
            _numofpage = book.BookNumberOfPages;
            _numofcopy = book.BookNumberOfCopies;
            _productdate = book.BookProductDate;
            //fix later
            _numofcopyleft = _numofcopy - DatabaseConnection.GetNumberOfBorrowedCopies(_id);
            setText();
        }
        private void setText() {
            txtBookName.Text = _name;
            txtBookAuthor.Text = _author;
            txtBookPublisher.Text = _publisher;
            txtBookGenre.Text = _genre;
            pictureBoxDetailBook.ImageLocation = _image;
            txtBookPrice.Text = _price.ToString() + "$";
            txtBookPages.Text = _numofpage.ToString() + " Pages";
            txtBookCopies.Text = _numofcopyleft.ToString() + " Copies left";
            txtBookProductDate.Text = _productdate;
            txtDescription.Text = _description;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (_numofcopyleft <= 0)
            {
                MessageBox.Show("Out of Stock");
            }
            else if (txtBorrowedDays.Text.Trim() == "" || Int32.TryParse(txtBorrowedDays.Text.Trim(), out int a) == false || Int32.Parse(txtBorrowedDays.Text.Trim()) == 0) {
                MessageBox.Show("Please enter number of days you want to borrow");
            } else {
                DialogResult rs = MessageBox.Show("Do you want to borrow this book?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    String BorrowRecieptBorrowedDate = DateTime.Now.ToShortDateString();
                    String BorrowRecieptDeadline = DateTime.Now.AddDays(Int32.Parse(txtBorrowedDays.Text.Trim())).ToShortDateString();
                    DatabaseConnection.CreateCommand("INSERT INTO BorrowReciept (BorrowRecieptBorrowedDate,BorrowRecieptDeadline,BorrowRecieptQuantity,BorrowRecieptIsReturned,BookId,UserId) VALUES " +
                         "('" + BorrowRecieptBorrowedDate + "','" + BorrowRecieptDeadline + "'," + 1 + "," + 0 + "," + _id + "," + Program.login_user.UserId + ");"); ;
                    int new_reciept_id = DatabaseConnection.GetBorrowedRecieptId(Program.login_user.UserId);
                    DatabaseConnection.CreateCommand("INSERT INTO UserHasBorrowReciept (UserId,BorrowRecieptId) VALUES (" + Program.login_user.UserId + ", " + new_reciept_id + ");");
                    MessageBox.Show("Succesful borrowed");
                    FormLoad();
                }
            }
        }

        private void btnBorrow_MouseHover(object sender, EventArgs e)
        {
            btnBorrow.ForeColor = Color.Firebrick;
        }

        private void btnBorrow_MouseLeave(object sender, EventArgs e)
        {
            btnBorrow.ForeColor = Color.Black;
        }
    }
}
