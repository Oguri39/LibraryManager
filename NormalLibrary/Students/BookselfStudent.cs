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
        private List<Book> list_book = new List<Book>();
        public BookselfStudent()
        {
            InitializeComponent();
        }
        private void BookselfStudent_Load(object sender, EventArgs e)
        {
            list_book = DatabaseConnection.GetBookList("SELECT * FROM Book");
            BookBorrowedItemStudent[] list_book_items = new BookBorrowedItemStudent[list_book.Count];
            for (int i = 0; i < list_book.Count; i++)
            {
                list_book_items[i] = new BookBorrowedItemStudent();
                List<Author> list_author = new List<Author>();
                list_author = DatabaseConnection.GetAuthorList("SELECT * FROM Book JOIN AuthorHasBooks  ON Book.BookId = AuthorHasBooks.BookId JOIN Author  ON Author.AuthorId = AuthorHasBooks.AuthorId WHERE Book.BookId = " + list_book[i].BookId + ";");
                string new_author = "";
                for (int j = 0; j < list_author.Count; j++)
                {
                    new_author = new_author + list_author[j].AuthorName + "; ";
                }
                list_book_items[i].NAME = list_book[i].BookName;
                list_book_items[i].ID = list_book[i].BookId;
                list_book_items[i].DESCRIPTION = list_book[i].BookDescription;
                list_book_items[i].AUTHOR = new_author;
                list_book_items[i].IMAGE = list_book[i].BookImage;
                flowLayoutPanel.Controls.Add(list_book_items[i]);
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
