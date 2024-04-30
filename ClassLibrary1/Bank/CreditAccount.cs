using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Bank
{
    public class CreditAccount : BankAccount
    {
        private decimal creditLimit;
        private decimal interestRate;

        public CreditAccount(string accountNumber, decimal creditLimit, decimal interestRate) : base(accountNumber)
        {
            this.creditLimit = creditLimit;
            this.interestRate = interestRate;
        }

        public override void Withdraw(decimal amount)
        {
            if (balance + creditLimit >= amount)
                balance -= amount;
            else
                Console.WriteLine("Превышен кредитный лимит");
        }

        public void AccrueInterest()
        {
            if (balance < 0)
            {
                decimal interest = Math.Abs(balance) * interestRate;
                balance -= interest;
            }
        }
    }

}
