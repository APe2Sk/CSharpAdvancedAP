using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class UsersDB
    {
        public static List<User> Users = new List<User>
        {
            new User() { UserName = "apesov", LastName = "Pesov", FirstName = "Aleksandar", Age = 24, Password = "123Aleksandar" },
            new User() { UserName = "amitrov", LastName = "Mitrov", FirstName = "Angel", Age = 21, Password = "123Mitrov" },
            new User() { UserName = "aAleksandar", LastName = "Milevski", FirstName = "Aleksandar", Age = 25, Password = "amile" },
        };


    }
}
