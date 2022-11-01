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
    public partial class BookBorrowedItemStudent : UserControl
    {
        public BookBorrowedItemStudent()
        {
            InitializeComponent();
        }
        #region Properties
        private int _id;
        private int _borrowed_id;
        private string _name;
        private string _author;
        private string _genre;
        private string _borrowed_date;
        private string _return_date;
        private double _payment;
        private double _total_day;
        private int _late_days;
        private string _image;
        private bool _is_asking_for_check;
        [Category("Custom Props")]
        public int ID { get { return _id; } set { _id = value; } }
        [Category("Custom Props")]
        public string NAME { get { return _name; } set { _name = value; labelName.Text = value; } }
        [Category("Custom Props")]
        public string AUTHOR { get { return _author; } set { _author = value; labelAuthor.Text = value; } }
        [Category("Custom Props")]

        public string GENRE { get { return _genre; } set { _genre = value; labelGenre.Text = value; } }
        [Category("Custom Props")]

        public string RETURN_DATE { get { return _return_date; } set { _return_date = value; labelReturnDate.Text = value; } }
        [Category("Custom Props")]
        public double PAYMENT { get { return _payment; } set { _payment = value; labelPayment.Text = value.ToString(); } }
        [Category("Custom Props")]

        public string IMAGE { get { return _image; } set { _image = value; pictureBoxBookBorrowedItemStudent.ImageLocation = value; } }
        [Category("Custom Props")]
        public int LATEDAYS { get { return _late_days; } set { _late_days = value; labelLateDays.Text = value.ToString(); } }
        [Category("Custom Props")]

        public string BORROWEDDATE { get { return _borrowed_date; } set { _borrowed_date = value; } }
        [Category("Custom Props")]
        public double TOTALDAYS { get { return _total_day; } set { _total_day = value; } }
        [Category("Custom Props")]
        public int BORROWEDID { get { return _borrowed_id; } set { _borrowed_id = value; } }
        [Category("Custom Props")]
        public bool ISASKINGFORCHECK { get { return _is_asking_for_check; } set { _is_asking_for_check = value; if (_is_asking_for_check) { this.BackColor = Color.LightCyan; } } }
        #endregion


        public bool IsContain(String search_string, String condition)
        {
            if (condition == "ALL" && (_name.ToLower().Contains(search_string.ToLower()) || _author.ToLower().Contains(search_string.ToLower()) || _genre.Contains(search_string)))
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
            BookBorrowedItemDetailStudent new_form = new BookBorrowedItemDetailStudent( _id,  _borrowed_date,  _return_date,  _payment,  _total_day, _late_days, _borrowed_id);
            new_form.Show();
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            pictureBoxBookBorrowedItemStudent.BackColor = Color.PeachPuff;
            panel2.BackColor = Color.PeachPuff;
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            pictureBoxBookBorrowedItemStudent.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
        }
    }
}
