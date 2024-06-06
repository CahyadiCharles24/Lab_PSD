using GymMe.Factory;
using GymMe.Model;
using GymMe.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;

namespace GymMe.Handler
{
    public class UserHandler
    {
        public static String registUser(String username, String email, String password,
            String gender, DateTime DOB, String role)
        {
            MsUser user = UserRepository.getUserByUsername(username);

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

            if (user == null)
            {
                return "Username or Password is invalid";
            }

            return "";
        }

        public static string UpdateUser(int userID, string Email, string Username, DateTime DOB, string Gender, string newPassword)
        {
    
            UserRepository.UpdateUser(userID, Email, Username, DOB, Gender, newPassword);

            return ("");
        }

        public static string OldPassword(int userID, string Password)
        {
            MsUser user = UserRepository.OldPassword(userID, Password);

            if (user == null)
            {
                return "User not found";
            }

            if (user.UserPassword != Password)
            {
                return "Old password is incorrect";
            }

            return "";

        }
        
    }
}