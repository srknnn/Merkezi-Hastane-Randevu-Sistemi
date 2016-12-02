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


        public long IdentityNumber { get; set; }


       

        public string gender { get; set; }

        public DateTime DateOfBirth { get; set; }


        public string EMail { get; set; }


        public string Password { get; set; }


        public string CellPhone { get; set; }



        public string HomePhone { get; set; }


        public string SecurityQuestion { get; set; }

  

        public string Answer { get; set; }

        public string PlaceOfBirth { get; set; }
        public string MotherName { get; set; }
        public string FatherName { get; set; }
        public bool IsDeleted { get; set; }

        public string SecurityPicture { get; set; }

    }
}
