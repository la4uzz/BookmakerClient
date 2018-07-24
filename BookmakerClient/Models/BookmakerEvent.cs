using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmakerClient.Models
{
    public class BookmakerEvent
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public string Uri { get; set; }
        public string RaceName { get; set; }
        public int RoundId { get; set; }
        public long TournamentId { get; set; }
        public string TournamentName { get; set; }
        public string Places { get; set; }
        public string EwReduction { get; set; }

        public List<BookmakerMarket> Markets { get; set; }

        public BookmakerEvent()
        {
            if (this.Markets == null)
            {
                Markets = new List<BookmakerMarket>();
            }
        }
    }
}
