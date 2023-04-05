using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class Program
    {
        

        static void Main()
        {
            Bank myBank = new Bank("My Bank");
            


            bool i = true;

            do
            {
                Console.WriteLine($"Welcome to the {myBank.Name}\nSelect by a number: \n1. Add user\n2. Deposit money\n3. Withdraw money\n4. Deposit money into another person's account\n5. check Balance\n6. Quit");
                int option = int.Parse(Console.ReadLine());

                if(option == 1)
                {
                    Console.WriteLine("Write your Firstname: ");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Write your Lastname: ");
                    string lastName = Console.ReadLine();

                    User user = null; 
                    user = new User(firstName, lastName, myBank, new Account(myBank, user: user));
                    myBank.AddUser(user);
                }
                if (option == 2)
                {
                    Console.WriteLine("Write your Firstname: ");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Write your Lastname: ");
                    string lastName = Console.ReadLine();

                    User user = myBank.FindUser(firstName, lastName);
                    if(user != null)
                    {
                        Console.WriteLine("How much do you want to deposit: ");
                        int amount = int.Parse(Console.ReadLine());
                        user.Account.Deposit(amount);
                    }
                    else
                    {
                        Console.WriteLine("User not found.");
                    }

                }
                if (option == 3)
                {
                    Console.WriteLine("Write your Firstname: ");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Write your Lastname: ");
                    string lastName = Console.ReadLine();

                    User user = myBank.FindUser(firstName, lastName);
                    if (user != null)
                    {
                        Console.WriteLine("How much do you want to Withdraw: ");
                        int amount = int.Parse(Console.ReadLine());
                        user.Account.Withdraw(amount);
                    }
                    else
                    {
                        Console.WriteLine("User not found.");
                    }

                }
                if (option == 4)
                {
                    Console.WriteLine("Write the person's First name: ");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Write the person's Lirst name: ");
                    string lastName = Console.ReadLine();

                    User user = myBank.FindUser(firstName, lastName);
                    if (user != null)
                    {
                        Console.WriteLine("How much do you want to deposit: ");
                        int amount = int.Parse(Console.ReadLine());
                        user.Account.Deposit(amount);
                    }
                    else
                    {
                        Console.WriteLine("User not found.");

                    }
                }
                if(option == 5)
                {
                    Console.WriteLine("Write your Firstname: ");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Write your Lastname: ");
                    string lastName = Console.ReadLine();

                    User user = myBank.FindUser(firstName, lastName);
                    if (user != null)
                    {
                        Console.WriteLine($"Youre Balance is: {user.Account.CheckBalance()}");
                    }
                    else
                    {
                        Console.WriteLine("User not found.");
                    }

                }
                if(option == 6)
                {
                    Console.WriteLine("Thank you for using our bank!\nWelcome Back!");
                    i = false;
                }

            } while (i != false); 

        }
    }
}
