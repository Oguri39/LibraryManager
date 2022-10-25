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
    public partial class MainStudents : Form
    {
        public MainStudents()
        {
            InitializeComponent();
            if (Program.screenSize == 1)
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
            if (Program.screenSize == 0)
            {
                Program.screenSize = 1;
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                Program.screenSize = 0;
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
                Program.ReleaseCapture();
                Program.SendMessage(Handle, Program.WM_NCLBUTTONDOWN, Program.HT_CAPTION, 0);
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
        }

        private void btnBookself_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = true;
            bookselfStudent.Visible = true;
            contactStudent.Visible = false;
            homeStudent.Visible = false;
            
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = false;
            bookselfStudent.Visible = false;
            contactStudent.Visible = true;
            homeStudent.Visible = false;
        }

        private void MainStudents_Load(object sender, EventArgs e)
        {
            panelFilter.Visible = true;
            bookselfStudent.Visible = false;
            contactStudent.Visible = false;
            homeStudent.Visible = true;
        }
    }
}
