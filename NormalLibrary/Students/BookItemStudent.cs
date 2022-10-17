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
        private string _description;
        private string _author;
        private string _publisher;
        private string _genre;
        private string _image;
        [Category("Custom Props")]
        public int ID { get { return _id; } set { _id = value; } }
        [Category("Custom Props")]
        public string NAME { get { return _name; } set { _name = value; labelName.Text = value; } }
        [Category("Custom Props")]

        public string DESCRIPTION { get { return _description; } set { _description = value; } }
        [Category("Custom Props")]
        public string PUBLISHER { get { return _publisher; } set { _publisher = value; labelPublisher.Text = value; } }
        [Category("Custom Props")]
        public string AUTHOR { get { return _author; } set { _author = value; labelAuthor.Text = value; } }
        [Category("Custom Props")]

        public string GENRE { get { return _genre; } set { _genre = value; labelGenre.Text = value; } }
        [Category("Custom Props")]

        public string IMAGE { get { return _image; } set { _image = value; pictureBoxBookItemStudent.ImageLocation = value; } }

        #endregion

    }
}
