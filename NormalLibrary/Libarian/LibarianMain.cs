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
    public partial class LibarianMain : Form
    {
        private int screenSize = 0;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
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

        private void LibarianMain_Load(object sender, EventArgs e)
        {
            dgvLibrary.DataSource = DatabaseConnection.GetDataTable("SELECT Book.BookId, Book.BookName, Book.BookNumberOfPages, Book.BookProductDate, Book.BookNumberOfCopies,Book.BookFee,Book.BookIsNew,Genre.GenreName,Author.AuthorName FROM Book JOIN BookHasGenre ON Book.BookId = BookHasGenre.BookId JOIN Genre ON Genre.GenreId = BookHasGenre.GenreId JOIN AuthorHasBooks  ON Book.BookId = AuthorHasBooks.BookId JOIN Author  ON Author.AuthorId = AuthorHasBooks.AuthorId");

        }

        private void dgvLibrary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
