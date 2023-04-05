using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Bank
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }

        public Bank(string name)
        {
            Name = name;
            Users = new List<User>();
        }

        public void AddUser(User user)
        {
            Users.Add(user);
        }

        public User FindUser(string firstname, string lastName)
        {
            return Users.FirstOrDefault(x => x.FirstName == firstname && x.LastName == lastName);
        }
    }
}
