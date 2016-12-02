using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class AppointmentALL
    {
        public int AppointmentID { get; set; }

        public string DoctorFullName { get; set; }

        public DateTime AppointmentDate { get; set; }
        public bool AppointmentStatus { get; set; }
        public DateTime AppointmentTime { get; set; }

        public string HospitalName { get; set; }
        public string ClinicBranch { get; set; }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}{4}{5}", DoctorFullName, AppointmentDate, AppointmentStatus, AppointmentTime, HospitalName, ClinicBranch);
        }
    }
}
