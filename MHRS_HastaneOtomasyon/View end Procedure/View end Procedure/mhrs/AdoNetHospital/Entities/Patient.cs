using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Patient
    {
        public int ID { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } }

        private long _identityNumber;

        public long IdentityNumber { get { return _identityNumber; } set { _identityNumber = value; } }


       public enum Gender 
        {
            None = 0,
            Male,
            Female
        }

        public Gender gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        private string _eMail;
        public string EMail { get { return _eMail; } set { _eMail = value; } }

        private string _password;

        public string Password { get { return _password; } set { _password = value; } }

        private long _cellPhone;
        public long CellPhone { get { return _cellPhone; } set { _cellPhone = value; } }

        private long _homePhone;

        public long HomePhone { get { return _homePhone; } set { _homePhone = value; } }


        public string SecurityQuestion { get; set; }

        private string _answer;

        public string Answer { get { return _answer; } set { _answer = value; } }

        public string PlaceOfBirth { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public bool IsDeleted { get; set; }

        public string SecurityPicture { get; set; }

    }
}
