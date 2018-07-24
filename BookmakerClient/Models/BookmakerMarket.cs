using BookmakerClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmakerClient.Models
{
    public class BookmakerMarket
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public MarketType OddsType { get; set; }
        public string SpecialBet { get; set; }
        
        public List<BookmakerOutcome> Outcomes { get; set; }

        public BookmakerMarket()
        {
            if (this.Outcomes == null)
                this.Outcomes = new List<BookmakerOutcome>();
        }
    }
}
