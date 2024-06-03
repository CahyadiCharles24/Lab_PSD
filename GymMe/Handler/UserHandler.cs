using GymMe.Factory;
using GymMe.Model;
using GymMe.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GymMe.Handler
{
    public class UserHandler
    {
        public static String registUser(String username, String email, String password, 
            String gender, DateTime DOB, String role)
        {
            MsUser user = UserRepository.getUserByUsername(email);

            if (user != null)
            {
                return "Username already in used";
            }

            MsUser us = UserFactory.CreateUser(username, email, gender, password, DOB, role);
            UserRepository.Register(us);

            return "";
        }

        public static String loginUser(String username, String password)
        {
            MsUser user = UserRepository.checkLogin(username, password);

            if(user == null)
            {
                return "Username or Password is invalid";
            }

            return "";
        }

    }
}