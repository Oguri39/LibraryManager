using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormalLibrary.Students
{
    public partial class MainStudents : Form
    {
        private int screenSize = 0;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        public static String search_tab = "ALL";
        public static String search_bar = "";
        public MainStudents()
        {
            InitializeComponent();
            if (screenSize == 1)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
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

        private void homeTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnHome_MouseHover(object sender, EventArgs e)
        {
            btnHome.ForeColor = Color.Firebrick;
        }

        private void btnBookself_MouseHover(object sender, EventArgs e)
        {
            btnBookself.ForeColor = Color.Firebrick;

        }

        private void btnContact_MouseHover(object sender, EventArgs e)
        {
            btnContact.ForeColor = Color.Firebrick;

        }

        private void btnProfile_MouseHover(object sender, EventArgs e)
        {
            btnProfile.ForeColor = Color.Firebrick;

        }

        private void btnFilterAll_MouseHover(object sender, EventArgs e)
        {
            btnFilterAll.ForeColor = Color.Firebrick;

        }

        private void btnFilterAuthor_MouseHover(object sender, EventArgs e)
        {
            btnFilterAuthor.ForeColor = Color.Firebrick;

        }

        private void btnFilterGenre_MouseHover(object sender, EventArgs e)
        {
            btnFilterGenre.ForeColor = Color.Firebrick;

        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            btnHome.ForeColor = Color.Black;
        }

        private void btnBookself_MouseLeave(object sender, EventArgs e)
        {
            btnBookself.ForeColor = Color.Black;

        }

        private void btnContact_MouseLeave(object sender, EventArgs e)
        {
            btnContact.ForeColor = Color.Black;

        }

        private void btnProfile_MouseLeave(object sender, EventArgs e)
        {
            btnProfile.ForeColor = Color.Black;

        }

        private void btnFilterAll_MouseLeave(object sender, EventArgs e)
        {
            btnFilterAll.ForeColor = Color.Black;

        }

        private void btnFilterAuthor_MouseLeave(object sender, EventArgs e)
        {
            btnFilterAuthor.ForeColor = Color.Black;

        }

        private void btnFilterGenre_MouseLeave(object sender, EventArgs e)
        {
            btnFilterGenre.ForeColor = Color.Black;

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = true;
            bookselfStudent.Visible = false;
            contactStudent.Visible = false;
            homeStudent.Visible = true;
            search_bar = "";
            search_tab = "ALL";
            btnFilterAll.ForeColor = Color.Firebrick;
            btnFilterAuthor.ForeColor = Color.Black;
            btnFilterGenre.ForeColor = Color.Black;
            homeStudent.HomeStudent_Load(sender, e);
        }

        private void btnBookself_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = true;
            bookselfStudent.Visible = true;
            contactStudent.Visible = false;
            homeStudent.Visible = false;
            search_bar = "";
            search_tab = "ALL";
            btnFilterAll.ForeColor = Color.Firebrick;
            btnFilterAuthor.ForeColor = Color.Black;
            btnFilterGenre.ForeColor = Color.Black;
            bookselfStudent.BookselfStudent_Load(sender, e);
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = false;
            bookselfStudent.Visible = false;
            contactStudent.Visible = true;
            homeStudent.Visible = false;
            search_bar = "";
            search_tab = "ALL";
            btnFilterAll.ForeColor = Color.Black;
            btnFilterAuthor.ForeColor = Color.Black;
            btnFilterGenre.ForeColor = Color.Black;
        }

        private void MainStudents_Load(object sender, EventArgs e)
        {
            search_bar = "";
            search_tab = "ALL";
            btnFilterAll.ForeColor = Color.Firebrick;
            btnFilterAuthor.ForeColor = Color.Black;
            btnFilterGenre.ForeColor = Color.Black;
            panelFilter.Visible = true;
            bookselfStudent.Visible = false;
            contactStudent.Visible = false;
            homeStudent.Visible = true;
            homeStudent.HomeStudent_Load(sender, e);
        }

        private void btnFilterAll_Click(object sender, EventArgs e)
        {
            search_tab = "ALL";
            btnFilterAll.ForeColor = Color.Firebrick;
            btnFilterAuthor.ForeColor = Color.Black;
            btnFilterGenre.ForeColor = Color.Black;
            if (homeStudent.Visible == true) {
                homeStudent.HomeStudent_Load(sender, e);
            } else if (bookselfStudent.Visible == true) {
                bookselfStudent.BookselfStudent_Load(sender, e);
            }
            else
            {
                search_tab = "ALL";
                search_bar = "";
                btnFilterAll.ForeColor = Color.Black;
                btnFilterAuthor.ForeColor = Color.Black;
                btnFilterGenre.ForeColor = Color.Black;
            }

        }

        private void btnFilterAuthor_Click(object sender, EventArgs e)
        {
            search_tab = "AUTHOR";
            btnFilterAll.ForeColor = Color.Black;
            btnFilterAuthor.ForeColor = Color.Firebrick;
            btnFilterGenre.ForeColor = Color.Black;
            if (homeStudent.Visible == true)
            {
                homeStudent.HomeStudent_Load(sender, e);
            }
            else if (bookselfStudent.Visible == true)
            {
                bookselfStudent.BookselfStudent_Load(sender, e);
            }
            else
            {
                search_tab = "ALL";
                search_bar = "";
                btnFilterAll.ForeColor = Color.Black;
                btnFilterAuthor.ForeColor = Color.Black;
                btnFilterGenre.ForeColor = Color.Black;
            }
        }

        private void btnFilterGenre_Click(object sender, EventArgs e)
        {
            search_tab = "GENRE";
            btnFilterAll.ForeColor = Color.Black;
            btnFilterAuthor.ForeColor = Color.Black;
            btnFilterGenre.ForeColor = Color.Firebrick;
            if (homeStudent.Visible == true)
            {
                homeStudent.HomeStudent_Load(sender, e);
            }
            else if (bookselfStudent.Visible == true)
            {
                bookselfStudent.BookselfStudent_Load(sender, e);
            }
            else
            {
                search_tab = "ALL";
                search_bar = "";
                btnFilterAll.ForeColor = Color.Black;
                btnFilterAuthor.ForeColor = Color.Black;
                btnFilterGenre.ForeColor = Color.Black;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            search_bar = txtStudentHomeSearchBox.Text;
            if (homeStudent.Visible == true)
            {
                homeStudent.HomeStudent_Load(sender, e);
            }
            else if (bookselfStudent.Visible == true)
            {
                bookselfStudent.BookselfStudent_Load(sender, e);
            }
            else
            {
                search_tab = "ALL";
                search_bar = "";
                btnFilterAll.ForeColor = Color.Black;
                btnFilterAuthor.ForeColor = Color.Black;
                btnFilterGenre.ForeColor = Color.Black;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileStudent new_form = new ProfileStudent();
            new_form.Show();
        }
    }
}
