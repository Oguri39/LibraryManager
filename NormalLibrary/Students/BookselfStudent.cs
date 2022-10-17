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
            BookItemStudent[] list_book_items = new BookItemStudent[list_book.Count];
            for(int i = 0; i < list_book.Count; i++)
            {
                list_book_items[i] = new BookItemStudent();
                List<Genre> list_genre = new List<Genre>();
                List<Author> list_author = new List<Author>();
                List<Publisher> list_publisher = new List<Publisher>();
                list_genre = DatabaseConnection.GetGenreList("SELECT * FROM Book JOIN BookHasGenre ON Book.BookId = BookHasGenre.BookId JOIN Genre ON Genre.GenreId = BookHasGenre.GenreId WHERE Book.BookId = " + list_book[i].BookId + ";");
                list_author = DatabaseConnection.GetAuthorList("SELECT * FROM Book JOIN AuthorHasBooks  ON Book.BookId = AuthorHasBooks.BookId JOIN Author  ON Author.AuthorId = AuthorHasBooks.AuthorId WHERE Book.BookId = " + list_book[i].BookId + ";");
                list_publisher = DatabaseConnection.GetPublisherList("SELECT * FROM Book JOIN PublisherHasBooks  ON Book.BookId = PublisherHasBooks.BookId JOIN Publisher ON Publisher.PublisherId = PublisherHasBooks.PublisherId WHERE Book.BookId = " + list_book[i].BookId + ";");

                string new_genre = "";
                string new_author = "";
                string new_publisher = "";
                for(int j = 0; j < list_genre.Count; j++)
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
                list_book_items[i].NAME = list_book[i].BookName;
                list_book_items[i].ID = list_book[i].BookId;
                list_book_items[i].DESCRIPTION = list_book[i].BookDescription;
                list_book_items[i].AUTHOR = new_author;
                list_book_items[i].PUBLISHER = new_publisher;
                list_book_items[i].GENRE = new_genre;
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
