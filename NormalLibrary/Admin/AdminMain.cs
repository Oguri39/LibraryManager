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
        private int user_cell_click_id = -1;
        private int user_unactive_cell_click_id = -1;
        private int bills_cell_click_id = -1;
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
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            AdminProfile new_form = new AdminProfile(this);
            new_form.Show();
        }

        private void btnLibarian_Click(object sender, EventArgs e)
        {
            LibarianMain new_form = new LibarianMain();
            new_form.Show();
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            UserList_load();
            UserUnactive_load();
            BillsList_load();
        }
        private void UserList_load() {
            dgvUser.DataSource = DatabaseConnection.GetUserList("SELECT [User].UserId, [User].UserName, [User].UserRoles, [User].ProfileId, [User].UserApproved FROM [User]");

        }
        private void UserUnactive_load() {

            dgvUser.DataSource = DatabaseConnection.GetUserList("SELECT [User].UserId, [User].UserName, [User].UserRoles, [User].ProfileId, [User].UserApproved FROM [User] WHERE [User].UserApproved = 0");

        }
        private void BillsList_load() { 
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUser.Rows[e.RowIndex];
                if (row.Cells[0].Value.ToString() != "")
                {
                    user_cell_click_id = Int32.Parse(row.Cells[0].Value.ToString());
                }
            }
        }

        private void dgvUnactive_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUnactive.Rows[e.RowIndex];
                if (row.Cells[0].Value.ToString() != "")
                {
                    user_unactive_cell_click_id = Int32.Parse(row.Cells[0].Value.ToString());
                }
            }
        }

        private void dgvBillsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBillsList.Rows[e.RowIndex];
                if (row.Cells[0].Value.ToString() != "")
                {
                    bills_cell_click_id = Int32.Parse(row.Cells[0].Value.ToString());
                }
            }
        }
    }

}
