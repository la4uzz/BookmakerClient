using BookmakerClient.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookmakerClient.Core
{
    public static class EventsUtils
    {
        public static void ExtractHomeAwayTeamsFromEventName(BookmakerEvent eventObj)
        {
            eventObj.HomeTeam = eventObj.Name.Split(new[] { " v " }, StringSplitOptions.None)[0];
            eventObj.AwayTeam = eventObj.Name.Split(new[] { " v " }, StringSplitOptions.None)[1];
        }

        public static Tuple<string, string> ExtractHomeAwayTeamsFromEventName(string eventName, string delimiter = " v ")
        {
            var homeTeam = eventName.Split(new[] { delimiter }, StringSplitOptions.None)[0];
            var awayTeam = eventName.Split(new[] { delimiter }, StringSplitOptions.None)[1];

            return new Tuple<string, string>(homeTeam, awayTeam);
        }

        public static Tuple<string, string> ExtractPitcherNameFromTeam(string name, char delimiter = '(')
        {
            string team = name;
            string pitcher = "";
            if (name.Contains(delimiter))
            {
                var spl = name.Split(delimiter);
                team = spl[0].Trim();
                pitcher = spl[1].Replace("(", "").Replace(")", "").Replace("[", "").Replace("]", "").Trim();
            }
            return new Tuple<string, string>(team, pitcher);
        }
    }
}
