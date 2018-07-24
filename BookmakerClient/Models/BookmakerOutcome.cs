using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmakerClient.Models
{
    public class BookmakerOutcome
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Odds { get; set; }
        public string Uri { get; set; }
    }
}
