using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Assignment.Model;
using Assignment.Factory;

namespace Assignment.Repository
{
    public class RepositoryUser
    {
        static DatabaseTokobediaEntities1 db = new DatabaseTokobediaEntities1();

        public static List<User> GetAll()
        {
            return (from x
                    in db.Users
                    select x).ToList();
        }

        public static User Email(String email)
        {
            return (from x
                    in db.Users
                    where x.Email == email
                    select x).FirstOrDefault();
        }

        public static bool cekEmail(String email)
        {
            User _email = Email(email);
            if (_email == null)
                return true;
            return false;
        }

        public static User Password(String oldpass)
        {
            return (from x
                    in db.Users
                    where x.Password == oldpass
                    select x).FirstOrDefault();
        }

        public static bool cekPass(String oldpass)
        {
            User _pass = Password(oldpass);
            if (_pass != null)
                return true;
            return false;
        }

        public static User FindUser(String email, String password)
        {
            return (from x
                    in db.Users
                    where x.Email == email && x.Password == password 
                    select x).FirstOrDefault();
        }
        
        public static String getName(String email, String password)
        {
            User _user = FindUser(email, password);
            if (_user == null)
                return "";
            return _user.UserName.ToString();
        }
        
        public static void InsertUser(Int32 roleid, String username, String password, String email, String gender, String status)
        {
            db.Users.Add(FactoryUser.InsUser(roleid, username, password, email, gender, status));
            db.SaveChanges();
        }

        public static void InsertNewPassword(String oldpassword, String newpass)
        {
            User _user = Password(oldpassword);
            _user.Password = newpass;
            db.SaveChanges();
        }

        public static void UpdateProfile(String oldemail, String email, String name, String gender)
        {
            User _user = Email(oldemail);
            _user.Email = email;
            _user.UserName = name;
            _user.Gender = gender;
            db.SaveChanges();
        }

        public static User FindID(Int32 id)
        {
            return (from x
                    in db.Users
                    where x.UserID == id
                    select x).FirstOrDefault();
        }

        public static bool cekID(Int32 id)
        {
            User _user = FindID(id);
            if (_user != null)
                return true;
            return false;
        }

        public static void ChangeToBlocked(String email)
        {
            User _user = Email(email);
            _user.Status = "Blocked";
            db.SaveChanges();
        }

        public static void ChangeToActive(String email)
        {
            User _user = Email(email);
            _user.Status = "Active";
            db.SaveChanges();
        }

        public static void ChangeToAdmin(Int32 id)
        {
            User _user = FindID(id);
            _user.RoleID = 1;
            db.SaveChanges();
        }

        public static void ChangeToMember(Int32 id)
        {
            User _user = FindID(id);
            _user.RoleID = 2;
            db.SaveChanges();
        }

        public static String checkStatus(String email, String password)
        {
            return (from x
                    in db.Users
                    where x.Email == email && x.Password == password
                    select x.Status).FirstOrDefault();
        }

        public static List<User> GetProfile(String username)
        {
            var profile = (from x
                           in db.Users
                           where x.UserName == username
                           select x).ToList();
            return profile;
        }
    }
}