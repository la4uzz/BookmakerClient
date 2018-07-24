using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmakerClient.Enums
{
    public enum MarketType
    {
        OOOO, // Default
        MTRS, // Match result
        OVUN, // OverUnder
        HTRS, // Half-Time result
        HTFT, // Half-time/Full-time
        FTSC, // First team to Score
        BTSC, // Both teams to score
        HABN, // Handicap
        CRSC, // Correct Score
        FGSC, // First goalscorer

        //horses
        WINN,
        PLAC
    }
}
