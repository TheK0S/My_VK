using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_VK
{
    internal class DataBase
    {
        public static string condMail = @"^[a-zA-Z\.\-_]+@([a-zA-Z\.\-_]+\.)+[a-zA-Z]{2,4}$";
        public static string condPhoneNumber = @"^\+\d{12}$";
        public static FormAuthorization? formAuthorization;
        public static FormRegistration? formRegistration;
    }
}
