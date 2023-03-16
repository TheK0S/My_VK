using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_VK
{
    internal class DataBase
    {
        public static List<User> users = new List<User>();
        public static string condMail = @"^[a-zA-Z\.\-_]+@([a-zA-Z\.\-_]+\.)+[a-zA-Z]{2,4}$";
        public static string condPhoneNumber = @"^\+\d{12}$";
        public static FormAuthorization? formAuthorization;
        public static FormRegistration? formRegistration;
        public static HomePage? homePage;

        public static bool isUniqueLogin(string login)
        {
            foreach (var item in users)
                if (login == item.Login)
                    return false;

            return true;
        }

        public static bool isUserVrified(string login, string password)
        {
            foreach (var item in users)
                if (login == item.Login && password == item.Password)
                    return true;

            return false;
        }
    }
}
