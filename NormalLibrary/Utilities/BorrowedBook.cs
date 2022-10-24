using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalLibrary.Utilities
{
    internal class BorrowedBook
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int BookNumberOfPages { get; set; }
        public string BookProductDate { get; set; }
        public string BookDescription { get; set; }
        public float BookFee { get; set; }
        public string BookImage { get; set; }
        public int BorrowRecieptId { get; set; }
        public string BorrowRecieptBorrowedDate { get; set; }
        public string BorrowRecieptDeadline { get; set; }
        public int BorrowRecieptQuantity { get; set; }
        public int BorrowRecieptIsReturned { get; set; }
    }
}
