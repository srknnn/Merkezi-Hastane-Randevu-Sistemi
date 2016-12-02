using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class UserLogin
    {
        private int _userID;
        private long _identityNumber;
        private string _password;


        public int UserID { get { return _userID; } set { _userID = value; } }

        public long IdentityNumber { get { return _identityNumber; } set { _identityNumber = value; } }

        public string Password { get { return _password; } set { _password = value; } }

        public string Email { get; set; }

    }
}
