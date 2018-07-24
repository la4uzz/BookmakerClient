using BookmakerClient.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BookmakerClient.Configuration
{
    public class BookmakerConfiguration : IBookmakerConfiguration
    {
        public BookmakerType Bookmaker { get ; set; }
        public List<SportConfiguration> Sports { get; set; }
        public bool IsOneUrl { get; set; }
        public string BookmakerUrl { get; set; }
    }

    public class SportConfiguration
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public SportType Sport { get; set; }
        public Dictionary<MarketType, List<string>> Markets { get; set; }
        public List<string> SportUrls { get; set; }

        public List<string> GetAllMarketTypesList()
        {
            List<string> ret = new List<string>();
            foreach (var dict in Markets)
            {
                ret.AddRange(dict.Value);
            }
            return ret;
        }

        public MarketType GetOddsType(string marketName)
        {
            MarketType ret = MarketType.OOOO;
            foreach (var dict in Markets)
            {

                if (marketName.ToLower().StartsWith("both teams to score"))
                {
                    if (marketName.ToLower() == "both teams to score")    //Reject Both Teams to Score that are conditional (1st/2nd quarter, over ect)
                    {
                        var temp = dict.Value.FirstOrDefault(mr => marketName.Equals(mr));
                        if (!String.IsNullOrEmpty(temp))
                        {
                            ret = dict.Key;
                            break;
                        }
                    }
                }
                else
                {
                    var temp = dict.Value.FirstOrDefault(mr => marketName.StartsWith(mr));
                    if (!String.IsNullOrEmpty(temp))
                    {
                        ret = dict.Key;
                        break;
                    }
                }
            }

            return ret;
        }

    }

}
