using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NormalLibrary
{
    public partial class BookItemDetailStudent : Form
    {
        private int screenSize = 0;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public BookItemDetailStudent()
        {
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
                BookItemDetailStudent.ReleaseCapture();
                BookItemDetailStudent.SendMessage(Handle, BookItemDetailStudent.WM_NCLBUTTONDOWN, BookItemDetailStudent.HT_CAPTION, 0);
            }
        }

        private void FormTemplate_Load(object sender, EventArgs e)
        {
            screenSize = 0;
            this.WindowState = FormWindowState.Normal;
        }
    }
}
