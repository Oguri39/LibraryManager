using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalLibrary.Utilities
{
    internal class BorrowReciept
    {
        public int BorrowRecieptId { get; set; }
        public string BorrowRecieptBorrowedDate { get; set; }
        public string BorrowRecieptDeadline { get; set; }
        public int BorrowRecieptQuantity { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
    }
}
