using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Bank
{
    public class SavingsAccount : BankAccount
    {
        private decimal interestRate;

        public SavingsAccount(string accountNumber, decimal interestRate) : base(accountNumber)
        {
            this.interestRate = interestRate;
        }

        public void AccrueInterest()
        {
            decimal interest = balance * interestRate;
            balance += interest;
        }
    }

}
