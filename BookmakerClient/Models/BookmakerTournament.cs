using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmakerClient.Models
{
    public class BookmakerTournament
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public List<BookmakerEvent> Events { get; set; }

        public BookmakerTournament()
        {
            if (this.Events == null)
                this.Events = new List<BookmakerEvent>();
        }
    }
}
