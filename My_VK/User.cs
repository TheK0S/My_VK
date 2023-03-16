using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_VK
{
    internal class User
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public User(string firstName, string secondName, string lastName, string login, string password, int age = 0)
        {
            FirstName = firstName;
            SecondName = secondName;
            LastName = lastName;
            Login = login;
            Password = password;
            Age = age;
        }
    }
}
