using BookmakerClient.Configuration;
using BookmakerClient.Client.WilliamhillClient;
using BookmakerClient.Models;
using BookmakerClient.Enums;
using System.Collections.Generic;

namespace BookmakerClient.Example
{
    class Program
    {
        static void Main(string[] args)
        {
            BookmakerConfiguration config = new BookmakerConfiguration
            {
                Bookmaker = BookmakerType.Williamhill,
                BookmakerUrl = null,
                IsOneUrl = false,
                Sports = new List<SportConfiguration>{ new SportConfiguration
                {
                    Id=1,
                    Sport = SportType.Football,
                    Name = "Football",
                    Markets = new Dictionary<MarketType, List<string>>
                    {
                        { MarketType.MTRS, new List<string> { "90 Minutes" } },
                        { MarketType.OVUN, new List<string> { "Total Match Goals Over/Under" } },
                        { MarketType.HTFT, new List<string> { "Double Result" } },
                        { MarketType.BTSC, new List<string> { "Both Teams To Score" } },
                        { MarketType.HABN, new List<string> { "Match Handicap" } },
                        { MarketType.CRSC, new List<string> { "Correct Score" } },
                        { MarketType.FGSC, new List<string> { "First Goalscorer" } }
                    },
                    SportUrls = new List<string>
                    {
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=1&marketSort=HF&filterBIR=N",
                        /*"http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=1&marketSort=MR&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=1&marketSort=--&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=1&marketSort=FS&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=1&marketSort=CS&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=274&marketSort=HF&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=274&marketSort=MR&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=274&marketSort=--&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=274&marketSort=CS&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=46&marketSort=HF&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=46&marketSort=MR&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=46&marketSort=--&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=46&marketSort=CS&filterBIR=N",
                        "http://pricefeeds.williamhill.com/oxipubserver?action=template&template=getHierarchyByMarketType&classId=46&marketSort=FS&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=36&marketSort=HF&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=36&marketSort=MR&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=36&marketSort=--&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=36&marketSort=CS&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=275&marketSort=HF&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=275&marketSort=MR&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=275&marketSort=--&filterBIR=N",
                        "http://pricefeeds.williamhill.com/openbet_cdn?action=template&template=getHierarchyByMarketType&classId=275&marketSort=CS&filterBIR=N",
                        "http://pricefeeds.williamhill.com/oxipubserver?action=template&template=getHierarchyByMarketType&classId=275&marketSort=FS&filterBIR=N"*/
                    }
                }
            }};

            List<SportType> sports = new List<SportType> { SportType.Football, SportType.AmericanFootball, SportType.AustralianRules, SportType.Baseball, SportType.Basketball,
                SportType.Cricket, SportType.GreyhoundRacing, SportType.HarnessRacing, SportType.HorseRacing, SportType.RugbyLeague, SportType.Tennis };

            WilliamhillClient client = new WilliamhillClient(config);
            var feed = client.GetBookmakerFeed(sports);
            foreach(var sp in feed.Sports)
            {

            }
        }
    }
}
