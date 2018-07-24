using BookmakerClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmakerClient.Models
{
    public class BookmakerSport
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public SportType TypeSp { get; set; }
        public List<BookmakerTournament> Tournaments { get; set; }

        public BookmakerSport()
        {
            if (this.Tournaments == null)
                this.Tournaments = new List<BookmakerTournament>();
        }
    }
}
