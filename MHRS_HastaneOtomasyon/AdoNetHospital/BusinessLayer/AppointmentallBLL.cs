using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data_Access_Layer;

namespace BusinessLayer
{
    public class AppointmentAllBLL 
    {

        AppointmentAllDAL _appoDaLall = new AppointmentAllDAL();

        public List<AppointmentALL> GetAppointmentAll(int userid)
        {
            List<AppointmentALL> getAppointmentAll = _appoDaLall.AppointAllList(userid);
            return getAppointmentAll;
        }

    }
}
