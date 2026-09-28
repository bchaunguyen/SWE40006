using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income
{
    public class IncomeProcessor
    {
        ///calculate net balane
        public decimal CalculateBalance(decimal totalIncome, decimal totalExpense)
        {
            return totalIncome - totalExpense;
        }
    }
}
