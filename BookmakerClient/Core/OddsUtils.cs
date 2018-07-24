using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmakerClient.Core
{
    public class OddsUtils
    {
        /// <summary>
		/// Uses the formula from http://www.betsmart.co/odds-conversion-formulas/#americantodecimal
		/// </summary>
		/// <param name="moneyLineOdds"></param>
		/// <returns></returns>
		public static decimal ConvertToDecimalOdds(long moneyLineOdds)
        {
            if (moneyLineOdds > 0)
            {
                return Math.Round(((decimal)moneyLineOdds / 100m) + 1m, 2);
            }
            else if (moneyLineOdds < 0)
            {
                return Math.Round((100m / (decimal)moneyLineOdds * -1) + 1m, 2);
            }

            return 0;
        }

        /// <summary>
        /// Uses the formula from http://www.betsmart.co/odds-conversion-formulas/#fractionaltodecimal
        /// </summary>
        /// <param name="num"></param>
        /// <param name="denom"></param>
        /// <returns></returns>
        public static decimal ConvertToDecimalOdds(long num, long denom)
        {
            return ((decimal)num / (decimal)denom) + 1;
        }

        /// <summary>
        /// Convert special bet into decimal format
        /// </summary>
        /// <param name="specialBet"></param>
        /// <returns></returns>
        public static string ConvertToDecimalOdds(string specialBet)
        {
            if (String.IsNullOrEmpty(specialBet))
            {
                return specialBet;
            }

            specialBet = specialBet.Replace(",", ".");
            if (specialBet.Contains('.'))
            {
                var count = specialBet.Length - specialBet.IndexOf('.') - 1;
                if (count == 1)
                {
                    specialBet = specialBet + "0";
                }
            }
            else
            {
                specialBet = specialBet + ".00";
            }

            return specialBet;
        }
    }
}
