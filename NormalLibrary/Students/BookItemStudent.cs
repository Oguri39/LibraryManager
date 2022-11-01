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
    public partial class BookItemStudent : UserControl
    {

        public BookItemStudent()
        {
            InitializeComponent();
        }
        #region Properties
        private int _id;
        private string _name;
        private string _author;
        private string _publisher;
        private string _genre;
        private string _image;
        private double _price;
        private int _isnew;
        [Category("Custom Props")]
        public int ID { get { return _id; } set { _id = value; } }
        [Category("Custom Props")]
        public string NAME { get { return _name; } set { _name = value; labelName.Text = value; } }
        [Category("Custom Props")]
        public string PUBLISHER { get { return _publisher; } set { _publisher = value; labelPublisher.Text = value; } }
        [Category("Custom Props")]
        public string AUTHOR { get { return _author; } set { _author = value; labelAuthor.Text = value; } }
        [Category("Custom Props")]

        public string GENRE { get { return _genre; } set { _genre = value; labelGenre.Text = value; } }
        [Category("Custom Props")]

        public string IMAGE { get { return _image; } set { _image = value; pictureBoxBookItemStudent.ImageLocation = value; } }
        [Category("Custom Props")]
        public double PRICE { get { return _price; } set { _price = value; labelPrice.Text = value.ToString(); } }
        [Category("Custom Props")]
        public int ISNEW { get { return _isnew; } set { _isnew = value; if (_isnew == 1) { this.BackColor = Color.LightCyan; } } }
        #endregion
        public bool IsContain(String search_string, String condition)
        {
            if (condition == "ALL" && (_name.ToLower().Contains(search_string.ToLower()) || _author.ToLower().Contains(search_string.ToLower()) || _genre.ToLower().Contains(search_string.ToLower())))
            {
                return true;
            }
            if (condition == "AUTHOR" && (_name.ToLower().Contains(search_string.ToLower()) || _author.ToLower().Contains(search_string.ToLower())))
            {
                return true;

            }
            if (condition == "GENRE" && (_name.ToLower().Contains(search_string.ToLower()) || _author.ToLower().Contains(search_string.ToLower())))
            {
                return true;
            }
            return false;
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            BookItemDetailStudent new_form = new BookItemDetailStudent(_id);
            new_form.Show();
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            pictureBoxBookItemStudent.BackColor = Color.PeachPuff;
            panel2.BackColor = Color.PeachPuff;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBookItemStudent.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
        }
    }
}
