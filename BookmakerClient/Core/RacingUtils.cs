using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmakerClient.Core
{
    public class RacingUtils
    {
        public static decimal CalculatePlaceOdds(int division, decimal win_price)
        {
            decimal ret = 0.00M;
            if (division > 0)
            {
                decimal ewReduction = 1.00M / (decimal)division;
                ret = Decimal.Round(((win_price - 1) * ewReduction + 1), 2);
            }
            return ret;
        }

        public static string CalculateEwReduction(int division)
        {
            decimal ewReduction = 0.00M;
            if (division > 0)
            {
                ewReduction = 1.00M / (decimal)division;
            }
            return ewReduction.ToString();
        }
    }
}
