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
    public partial class NewBookItemStudent : UserControl
    {
        private int _id;
        private string _name;
        private string _author;
        private string _image;
        public NewBookItemStudent()
        {
            InitializeComponent();
        }
        [Category("Custom Props")]
        public int ID { get { return _id; } set { _id = value; } }
        [Category("Custom Props")]
        public string NAME { get { return _name; } set { _name = value; labelName.Text = value; } }
        [Category("Custom Props")]
        public string AUTHOR { get { return _author; } set { _author = value; labelAuthor.Text = value; } }
        [Category("Custom Props")]
        public string IMAGE { get { return _image; } set { _image = value; pictureBox.ImageLocation = value; } }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            BookItemDetailStudent new_form = new BookItemDetailStudent(_id);
            new_form.Show();
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.PeachPuff;
            panel2.BackColor = Color.PeachPuff;
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
        }
    }
}
