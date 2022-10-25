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
        private string _name;
        private string _description;
        private string _author;
        private string _returndate;
        private double _payment;
        private double _price;
        private int _latedays;
        private int _totaldaysborrowed;
        private int _rentingdays;
        private string _image;
        [Category("Custom Props")]
        public int ID { get { return _id; } set { _id = value; } }
        [Category("Custom Props")]
        public string NAME { get { return _name; } set { _name = value; labelName.Text = value; } }
        [Category("Custom Props")]
        public string AUTHOR { get { return _author; } set { _author = value; labelAuthor.Text = value; } }
        [Category("Custom Props")]
        public string DESCRIPTION { get { return _description; } set { _description = value; } }
        [Category("Custom Props")]
        public string RETURNDATE { get { return _returndate; } set { _returndate = value; labelReturnDate.Text = value; } }
        [Category("Custom Props")]
        public double PAYMENT { get { return _payment; } set { _payment = value; labelPayment.Text = value.ToString(); } }
        [Category("Custom Props")]
        public double PRICE { get { return _price; } set { _price = value; } }
        [Category("Custom Props")]
        public int LATEDAYS { get { return _latedays; } set { _latedays = value; labelLateDays.Text = value.ToString(); } }
        [Category("Custom Props")]
        public int TOTALDAYSBORROWED { get { return _totaldaysborrowed; } set { _totaldaysborrowed = value;} }
        [Category("Custom Props")]
        public int RENTINGDAYS { get { return _rentingdays; } set { _rentingdays = value; } }
        [Category("Custom Props")]
        public string IMAGE { get { return _image; } set { _image = value; pictureBoxBookBorrowedItemStudent.ImageLocation = value; } }
        #endregion
    }
}
