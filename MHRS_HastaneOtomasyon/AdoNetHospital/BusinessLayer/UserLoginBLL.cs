using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Data_Access_Layer;

namespace BusinessLayer
{
    public class UserLoginBLL : IBusinessUserLogin<UserLogin, Int32>
    {
        UserLoginDAL _userLoginDAL = new UserLoginDAL();


        public UserLogin GetUserLogin(int id)
        {
             UserLogin userLogin = _userLoginDAL.GetLogin(id);
            return userLogin;
        }


        public UserLogin GetUserIdentity(int id)
        {
            UserLogin userIdent = _userLoginDAL.GetUserIDentity(id);
            return userIdent;
        }


        public List<UserLogin> GetUserALL()
        {
            List<UserLogin> userALL = _userLoginDAL.GetUserALL();

            return userALL;
        }
    }
}
