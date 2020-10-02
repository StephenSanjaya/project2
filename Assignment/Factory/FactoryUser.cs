using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment.Model;

namespace Assignment.Factory
{
    public class FactoryUser
    {
        public static User InsUser(Int32 roleid, String username, String password, String email, String gender, String status)
        {
            User _user = new User();
            _user.RoleID = roleid;
            _user.UserName = username;
            _user.Password = password;
            _user.Email = email;
            _user.Gender = gender;
            _user.Status = status;
            return _user;
        }
        
    }
}