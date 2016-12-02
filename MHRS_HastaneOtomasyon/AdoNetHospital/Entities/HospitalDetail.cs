using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class HospitalDetail
    {
        public int CityID { get; set; }
        public string CityName { get; set; }


        public int TownID { get; set; }
        public string TownName { get; set; }

        public int ClinicID { get; set; }
        public string ClinicBranch { get; set; }

        public DateTime ClinicStartTime { get; set; }

        public int ClinicRangeTime { get; set; }

        public DateTime ClinicEndTime { get; set; }

        public int HospitalID { get; set; }
        public string HospitalName { get; set; }

        public int DoctorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName { get { return FirstName + " " + LastName; } set { FirstName = value; } }

        public int TittleID { get; set; }

        public string TittleName { get; set; }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}{4}{5}", CityName, TownName, ClinicBranch, HospitalName, FullName, TittleName);
        }



    }
}
