using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class User
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Bank Bank { get; set; }
        public Account Account { get; set; }

        public User(string firstName, string lastName, Bank bank, Account account)
        {
            FirstName = firstName;
            LastName = lastName;
            Bank = bank;
            Account = account;
        }
    }
}
