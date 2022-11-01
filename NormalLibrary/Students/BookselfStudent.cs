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


namespace NormalLibrary.Students
{
    public partial class BookselfStudent : UserControl
    {
        private List<BorrowedBook> list_borrowed_book = new List<BorrowedBook>();
        public BookselfStudent()
        {
            InitializeComponent();
        }
        public void BookselfStudent_Load(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();


            list_borrowed_book = DatabaseConnection.GetBorrowedBookList("SELECT * FROM Book JOIN BorrowReciept ON Book.BookId = BorrowReciept.BookId JOIN UserHasBorrowReciept ON UserHasBorrowReciept.BorrowRecieptId = BorrowReciept.BorrowRecieptId WHERE UserHasBorrowReciept.UserId = " + Program.login_user.UserId + ";");
            BookBorrowedItemStudent[] list_borrowed_book_items = new BookBorrowedItemStudent[list_borrowed_book.Count];
            for (int i = 0; i < list_borrowed_book.Count; i++)
            {
                list_borrowed_book_items[i] = new BookBorrowedItemStudent();
                List<Author> list_author = new List<Author>();
                List<Genre> list_genre = new List<Genre>();
                list_genre = DatabaseConnection.GetGenreList("SELECT * FROM Book JOIN BookHasGenre ON Book.BookId = BookHasGenre.BookId JOIN Genre ON Genre.GenreId = BookHasGenre.GenreId WHERE Book.BookId = " + list_borrowed_book[i].BookId + ";");
                list_author = DatabaseConnection.GetAuthorList("SELECT * FROM Book JOIN AuthorHasBooks  ON Book.BookId = AuthorHasBooks.BookId JOIN Author  ON Author.AuthorId = AuthorHasBooks.AuthorId WHERE Book.BookId = " + list_borrowed_book[i].BookId + ";");
                string new_author = "";
                string new_genre = "";
                for (int j = 0; j < list_author.Count; j++)
                {
                    new_author = new_author + list_author[j].AuthorName + "; ";
                }
                for (int j = 0; j < list_genre.Count; j++)
                {
                    new_genre = new_genre + list_genre[j].GenreName + "; ";
                }
                DateTime StartDate = DateTime.Parse(list_borrowed_book[i].BorrowRecieptBorrowedDate);
                DateTime CurrentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                DateTime EndDate = DateTime.Parse(list_borrowed_book[i].BorrowRecieptDeadline);
                double totalDays = (CurrentDate - StartDate).TotalDays + 1.0;
                int LateDays = 0;
                if((CurrentDate - EndDate).TotalDays > 0)
                {
                    LateDays = (int)(CurrentDate - EndDate).TotalDays;
                }
                list_borrowed_book_items[i].NAME = list_borrowed_book[i].BookName;
                list_borrowed_book_items[i].ID = list_borrowed_book[i].BookId;
                list_borrowed_book_items[i].AUTHOR = new_author;
                list_borrowed_book_items[i].GENRE = new_genre;
                list_borrowed_book_items[i].RETURN_DATE = list_borrowed_book[i].BorrowRecieptDeadline;
                list_borrowed_book_items[i].PAYMENT = totalDays * list_borrowed_book[i].BookFee;
                list_borrowed_book_items[i].IMAGE = list_borrowed_book[i].BookImage;
                list_borrowed_book_items[i].LATEDAYS = LateDays;
                list_borrowed_book_items[i].BORROWEDDATE = StartDate.ToShortDateString();
                list_borrowed_book_items[i].TOTALDAYS = totalDays;
                list_borrowed_book_items[i].BORROWEDID = list_borrowed_book[i].BorrowRecieptId;
                list_borrowed_book_items[i].ISASKINGFORCHECK = DatabaseConnection.CheckIfUserHasBorrowRecieptIsAskingForCheck(list_borrowed_book[i].BorrowRecieptId);

            }
            List<BookBorrowedItemStudent> search_list_borrowed_book_items = new List<BookBorrowedItemStudent>();

            for (int i = 0; i < list_borrowed_book_items.Count(); i++)
            {
                if (list_borrowed_book_items[i].IsContain(MainStudents.search_bar, MainStudents.search_tab)){
                    search_list_borrowed_book_items.Add(list_borrowed_book_items[i]);
                }
            }
            for (int i = 0; i < search_list_borrowed_book_items.Count; i++)
            {
                flowLayoutPanel.Controls.Add(search_list_borrowed_book_items[i]);
            }
        }

        private void flowLayoutPanel_SizeChanged(object sender, EventArgs e)
        {
            flowLayoutPanel.SuspendLayout();
            foreach (Control ctrl in flowLayoutPanel.Controls)
            {
                ctrl.Width = flowLayoutPanel.ClientSize.Width - 10;
            }
            flowLayoutPanel.ResumeLayout();
        }
    }
}
