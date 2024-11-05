using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankingSystem
    {
        public List<BankAccount> AllAcounts = new List<BankAccount>();
        public BankAccount CreateAccount(int accountNumber, int balance, string ownerName, int agreedOverdraft)
        {
            BankAccount newAccount = new BankAccount(accountNumber, balance, ownerName, agreedOverdraft);
            AllAcounts.Add(newAccount);
            return newAccount;
        }

        public void ListAccounts()
        {
            foreach (BankAccount account in AllAcounts)
            {
                Console.WriteLine(account.AccountNumber);
            }
        }
    }
}
