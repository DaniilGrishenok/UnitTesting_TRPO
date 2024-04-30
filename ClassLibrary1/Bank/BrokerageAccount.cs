using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Bank
{
    public class BrokerageAccount : BankAccount
    {
        private List<Investment> investments;

        public BrokerageAccount(string accountNumber) : base(accountNumber)
        {
            investments = new List<Investment>();
        }

        public void BuyStock(string stockName, decimal price, int quantity)
        {
            decimal totalCost = price * quantity;
            if (totalCost <= balance)
            {
                investments.Add(new Investment { Name = stockName, Value = totalCost });
                balance -= totalCost;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
            }
        }

        public void SellStock(string stockName, decimal price, int quantity)
        {
            var investment = investments.FirstOrDefault(i => i.Name == stockName);
            if (investment != null && quantity <= investment.Value / price)
            {
                investment.Value -= price * quantity;
                balance += price * quantity;
            }
            else
            {
                Console.WriteLine("У вас недостаточно акций для продажи");
            }
        }
    }

}
