using NormalLibrary.Libarian;
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

namespace NormalLibrary.Admin
{
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
        }
        private int screenSize = 0;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private int book_cell_click_id = -1;
        private int author_cell_click_id = -1;
        private int genre_cell_click_id = -1;
        private int publisher_cell_click_id = -1;
        private int askingReturn_cell_click_id = -1;
        private int currentlyBorrowed_cell_click_id = -1;


        private void btnAddBook_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditBook_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDeleteBook_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddGenre_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddPublisher_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddAuthor_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditGenre_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditPublisher_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEditAuthor_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDeleteGenre_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDeletePublisher_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDeleteAuthor_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click_1(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {

        }
    }

}
