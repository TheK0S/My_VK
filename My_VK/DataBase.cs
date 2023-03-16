using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace My_VK
{
    internal class DataBase
    {
        public static List<User> users = new List<User>();
        public static FormAuthorization? formAuthorization;
        public static FormRegistration? formRegistration;
        public static HomePage? homePage;

        public static bool IsPhoneNumberValidated(string phoneNumber)
        {
            string condPhoneNumber = @"^\+\d{12}$";
            return Regex.IsMatch(phoneNumber, condPhoneNumber);
        }

        public static bool IsMailAdressValidated(string mailAdress)
        {
            string condMail = @"^[a-zA-Z\.\-_]+@([a-zA-Z\.\-_]+\.)+[a-zA-Z]{2,4}$";
            return Regex.IsMatch(mailAdress, condMail);
        }

        public static bool IsUserVrified(string login, string password)
        {
            foreach (var item in users)
                if (login == item.Login && password == item.Password)
                    return true;

            return false;
        }
    }
}
