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
    public partial class HomeStudent : UserControl
    {
        private List<Book> list_book = new List<Book>();
        public HomeStudent()
        {
            InitializeComponent();
        }

        public void HomeStudent_Load(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            list_book = DatabaseConnection.GetBookList("SELECT * FROM Book");
            List<Book> first_part = new List<Book>();
            List<Book> second_part = new List<Book>();

            for (int i = 0; i < list_book.Count; i++) {
                if (list_book[i].BookIsNew == 1)
                {
                    first_part.Add(list_book[i]);
                }
                else { 
                    second_part.Add(list_book[i]);
                }
            }
            list_book.Clear();
            list_book.InsertRange(0, second_part);
            list_book.InsertRange(0, first_part);
            BookItemStudent[] list_book_items = new BookItemStudent[list_book.Count];
            for (int i = 0; i < list_book.Count; i++)
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
                list_book_items[i].NAME = list_book[i].BookName;
                list_book_items[i].ID = list_book[i].BookId;
                list_book_items[i].AUTHOR = new_author;
                list_book_items[i].PUBLISHER = new_publisher;
                list_book_items[i].GENRE = new_genre;
                list_book_items[i].IMAGE = list_book[i].BookImage;
                list_book_items[i].ISNEW = list_book[i].BookIsNew;
                list_book_items[i].PRICE = list_book[i].BookFee;     
            }
            List<BookItemStudent> search_list_book_items = new List<BookItemStudent>();

            for (int i = 0; i < list_book_items.Count(); i++)
            {
                if (list_book_items[i].IsContain(MainStudents.search_bar, MainStudents.search_tab))
                {
                    search_list_book_items.Add(list_book_items[i]);
                }
            }
            for (int i = 0; i < search_list_book_items.Count; i++)
            {
                flowLayoutPanel.Controls.Add(search_list_book_items[i]);
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

        private void InitializeComponent()
        {
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(797, 686);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // HomeStudent
            // 
            this.Controls.Add(this.flowLayoutPanel);
            this.Name = "HomeStudent";
            this.Size = new System.Drawing.Size(797, 686);
            this.ResumeLayout(false);

        }

    }
}
