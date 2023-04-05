using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Account
    {
        public Bank Bank { get; set; }
        public User User { get; set; }
        public decimal Balance { get; set; }

        public Account(Bank bank, User user)
        {
            Bank = bank;
            User = user;
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds");
            }
        }

        public decimal CheckBalance()
        {
            return Balance;
        }
    }

}
