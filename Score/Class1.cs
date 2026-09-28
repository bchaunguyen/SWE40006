using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Score
{
    public class ScoreCalculator
    {
        // caculate score
        public int CalculateScore(decimal totalIncome, decimal totalExpense)
        {
            if (totalIncome <= 0) return 0;

            decimal ratio = totalExpense / totalIncome;

            if (ratio <= (decimal)0.5) return 100; // under 50-> very good
            if (ratio <= (decimal)0.7) return 80;  // 50-70 -> good
            if (ratio <= (decimal)0.9) return 60;  // 70-90 -> bad
            if (ratio <= (decimal)1.0) return 40;  // 90-100 -> very bad
            return 20;                             //exceed -> extremely bad
        }

        // alert
        public string GetSpendingWarning(decimal totalIncome, decimal totalExpense)
        {
            if (totalIncome <= 0)
                return "WARNING: Please enter your income first!";

            if (totalExpense > totalIncome)
                return "CRITICAL WARNING: Your expenses exceed your total income!";

            decimal ratio = totalExpense / totalIncome;

            if (ratio > (decimal)0.8)
                return "WARNING: You have spent over 80% of your income!";

            return "Spending is within a healthy range.";
        }
    }
}
