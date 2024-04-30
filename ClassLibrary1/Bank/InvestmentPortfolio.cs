using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Bank
{
    public class InvestmentPortfolio
    {
        private List<Investment> investments;

        public InvestmentPortfolio()
        {
            investments = new List<Investment>();
        }

        public void AddInvestment(Investment investment)
        {
            investments.Add(investment);
        }

        public void RemoveInvestment(Investment investment)
        {
            investments.Remove(investment);
        }
    }

}
