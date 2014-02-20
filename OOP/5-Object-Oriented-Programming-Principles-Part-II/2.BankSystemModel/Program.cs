using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystemModel
{
    class Program
    {
        static void Main()
        {
            // Create list of bank accounts.
            List<Account> bankAccounts = new List<Account>()
            {
                new LoanAccount(new Customer("Gosho", CustomerType.Individual), 267M, 0.02M),
                new DepositAccount(new Customer("Dreamworld Ltd.", CustomerType.Company), 5438.32M, 0.028M),
                new MortgageAccount(new Customer("Pesho", CustomerType.Individual), 15345.23M, 0.01M),
            };

            // Calculate interest of the accounts
            foreach (var account in bankAccounts)
            {
                Console.WriteLine("Bank account with owner {0} has yearly interest of {1:C}", account.Customer.Name, account.CalculateInterest(12));
            }
        }
    }
}
