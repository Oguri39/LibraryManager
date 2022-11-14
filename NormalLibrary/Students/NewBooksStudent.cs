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
    public partial class NewBooksStudent : UserControl
    {
        List<Book> list_book = new List<Book>();
        public NewBooksStudent()
        {
            InitializeComponent();
        }

        public void NewBooksStudent_Load(object sender, EventArgs e)
        {
            formLoad();
        }
        public void formLoad() {
            flowLayoutPanel.Controls.Clear();
            list_book.Clear();
            list_book = DatabaseConnection.GetBookList("SELECT * FROM Book WHERE Book.BookIsNew = 1 AND Book.BookIsDeleted = 0;");
            for (int i = 0; i < list_book.Count; i++) {
                List<Author> list_author = new List<Author>();
                list_author = DatabaseConnection.GetAuthorList("SELECT * FROM Book JOIN AuthorHasBooks  ON Book.BookId = AuthorHasBooks.BookId JOIN Author  ON Author.AuthorId = AuthorHasBooks.AuthorId WHERE Book.BookId = " + list_book[i].BookId + ";");
                string new_author = "";
                for (int j = 0; j < list_author.Count; j++)
                {
                    new_author = new_author + list_author[j].AuthorName + "; ";
                }

                NewBookItemStudent new_NewBookItemStudent = new NewBookItemStudent();
                new_NewBookItemStudent.ID = list_book[i].BookId;
                new_NewBookItemStudent.NAME = list_book[i].BookName;
                new_NewBookItemStudent.AUTHOR = new_author;
                new_NewBookItemStudent.IMAGE = list_book[i].BookImage;

                flowLayoutPanel.Controls.Add(new_NewBookItemStudent);
            }


        }
    }
}
