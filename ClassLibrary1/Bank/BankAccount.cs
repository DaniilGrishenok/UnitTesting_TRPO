using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Bank
{
    public class BankAccount
    {
        protected string accountNumber;
        protected decimal balance;

        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            balance = 0;
        }

        public decimal Balance => balance;

        public virtual void Deposit(decimal amount)
        {
            balance += amount;
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Недостаточно средств");
        }
    }
}
