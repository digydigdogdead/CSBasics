using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankAccount
    {
        public int AccountNumber;
        public int Balance;
        public string OwnerName;
        public int AgreedOverdraft;

        public void Depositing(int depositAmount)
        {
            Balance += depositAmount;
        }

        public void Withdrawing(int withdrawAmount)
        {
            if (Balance - withdrawAmount < -AgreedOverdraft)
            {
                Console.WriteLine("Cannot withdraw this amount.");
            } else
            {
                Balance -= withdrawAmount;
            }
        }

        public BankAccount(int accountNumber, int balance, string ownerName, int agreedOverdraft)
        { 
            AccountNumber = accountNumber;
            Balance = balance;
            OwnerName = ownerName;
            AgreedOverdraft = agreedOverdraft;
        }
    }
}
