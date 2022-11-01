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
    public partial class BookBorrowedItemDetailStudent : Form
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
        private int _numofpage;
        private string _productdate;
        private string _borrowed_date;
        private string _return_date;
        private double _payment;
        private double _total_day;
        private int _late_days;
        private int _borrowed_id;
        public BookBorrowedItemDetailStudent(int _id, string _borrowed_date, string _return_date, double _payment, double _total_day, int _late_days,int _borrowed_id)
        {
            this._id = _id;
            this._borrowed_date = _borrowed_date;
            this._return_date = _return_date;
            this._payment = _payment;
            this._total_day = _total_day;
            this._late_days = _late_days;
            this._borrowed_id = _borrowed_id;
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
                BookBorrowedItemDetailStudent.ReleaseCapture();
                BookBorrowedItemDetailStudent.SendMessage(Handle, BookBorrowedItemDetailStudent.WM_NCLBUTTONDOWN, BookBorrowedItemDetailStudent.HT_CAPTION, 0);
            }
        }

        private void BookBorrowedItemDetailStudent_Load(object sender, EventArgs e)
        {
            screenSize = 0;
            this.WindowState = FormWindowState.Normal;
            FormLoad();
        }
        private void FormLoad()
        {
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
            _numofpage = book.BookNumberOfPages;
            _productdate = book.BookProductDate;
            setText();
        }
        private void setText()
        {
            txtBookName.Text = _name;
            txtBookAuthor.Text = _author;
            txtBookPublisher.Text = _publisher;
            txtBookGenre.Text = _genre;
            pictureBoxDetailBook.ImageLocation = _image;
            txtBookPrice.Text = _price.ToString() + "$";
            txtBookPages.Text = _numofpage.ToString() + " Pages";
            txtBookProductDate.Text = _productdate;
            txtDescription.Text = _description;
            txtBorrowedDate.Text = _borrowed_date;
            txtDeadline.Text = _return_date;
            txtTotalDay.Text = _total_day.ToString();
            txtLateDays.Text = _late_days.ToString();
            txtPayment.Text = _payment.ToString();
        }

        private void btnReturn_MouseHover(object sender, EventArgs e)
        {
            btnReturn.ForeColor = Color.Firebrick;
        }

        private void btnReturn_MouseLeave(object sender, EventArgs e)
        {
            btnReturn.ForeColor = Color.Black;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {

            DialogResult rs = MessageBox.Show("Do you want to return this book?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                DatabaseConnection.CreateCommand("UPDATE UserHasBorrowReciept SET UserHasBorrowRecieptIsAskingForCheck = 1 WHERE BorrowRecieptId = " + _borrowed_id + ";");
                MessageBox.Show("You have successful send notification to libarian!");
                FormLoad();
            }
            
        }
    }
}
