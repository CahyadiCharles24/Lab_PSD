using GymMe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace GymMe.Repository
{
    public class UserRepository
    {
        private static myDatabaseEntities1 db = DBInstance.getInstance();
        public static MsUser getUserByUsername(String username)
        {

            return db.MsUsers.Where(u=>u.UserName == username).FirstOrDefault();
        }
        public static MsUser getUserById(String id)
        {

            return db.MsUsers.Where(u => u.UserID.ToString() == id).FirstOrDefault();
        }
        public static void Register(MsUser newUser)
        {
            db.MsUsers.Add(newUser);
            db.SaveChanges();

        }

        public static MsUser checkLogin(String username, String password)
        {

            return db.MsUsers.Where(u=>u.UserName==username 
            && u.UserPassword==password).FirstOrDefault();
        }

    }
}