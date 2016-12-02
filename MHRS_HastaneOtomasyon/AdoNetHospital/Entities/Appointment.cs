using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Appointment
    {
        public int AppointmentID { get; set; }

        public int PatientID { get; set; }

        public int DoctorID { get; set; }

        public DateTime AppointmenDate { get; set; }

        public DateTime AppointTime { get; set; }

        public bool AppointStatus { get; set; }

        

    }
}
