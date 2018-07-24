using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmakerClient.Models
{
    public class BookmakerFeed
    {
        public long TimestampReceived { get; private set; }
        public DateTime DateTimeRecieved { get; private set; }
        public List<BookmakerSport> Sports { get; private set; }

        public BookmakerFeed()
        {
            if (this.Sports == null)
                this.Sports = new List<BookmakerSport>();
        }
    }
}
