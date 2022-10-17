using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormalLibrary
{
    internal class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int UserRoles { get; set; }
        public string UserPassword { get; set; }
        public int ProfileId { get; set; }
        public int UserApproved { get; set; }
    }
}
