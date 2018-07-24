using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookmakerClient.Configuration;
using BookmakerClient.Core;
using BookmakerClient.Enums;
using BookmakerClient.Models;

namespace BookmakerClient.Client.WilliamhillClient
{
    public class WilliamhillClient : BookmakerXmlClient
    {
        public WilliamhillClient(IBookmakerConfiguration configuration) : base(configuration)
        {
        }

        public override BookmakerFeed GetBookmakerFeed(List<SportType> sports)
        {
            var returnFeed = new BookmakerFeed();
            foreach(var sport in sports)
            {
                var sportConfiguration = Configuration.Sports.FirstOrDefault(sp => sp.Sport == sport);

                if (sportConfiguration == null)
                    continue;

                List<BookmakerTournament> feedTournaments = new List<BookmakerTournament>();

                foreach (var url in sportConfiguration.SportUrls)
                {
                    var turl = url;
                    if (turl.ToLower().Contains("cachepricefeeds"))
                        turl = url.Replace("cachepricefeeds", "pricefeeds");

                    var feed = new XmlClasses.oxip();
                    try
                    {
                        feed = XmlUtils.GetFeedFromXML<XmlClasses.oxip>(Get(new Uri(turl)));
                        if (feed.response.code == 110) throw new System.Exception();
                    }
                    catch (System.Exception e)
                    {
                        turl = url.Replace("pricefeeds", "cachepricefeeds");
                        feed = XmlUtils.GetFeedFromXML<XmlClasses.oxip>(Get(new Uri(turl)));
                        Console.WriteLine("WilliamHill failover used - " + turl);
                    }

                    if (feed.response.code == 114)
                        continue;

                    foreach (var tournament in feed.response.williamhill.@class.type)
                    {
                        var feedEvents = new List<BookmakerEvent>();

                        var markets = tournament.market.Where(mr => sportConfiguration.GetAllMarketTypesList().Any(sp => mr.name.Split(new string[] { " - " }, StringSplitOptions.None)[1].Trim().StartsWith(sp)));

                        foreach (var market in markets)
                        {
                            if (market.name.Contains("- SSBT"))
                                continue;

                            var commands = EventsUtils.ExtractHomeAwayTeamsFromEventName(market.name.Split(new string[] { " - " }, StringSplitOptions.None)[0].Trim());

                            var homeTeam = commands.Item1;
                            var awayTeam = commands.Item2;

                            if (!(sport == SportType.HorseRacing || sport == SportType.GreyhoundRacing))
                            {
                                if ((String.IsNullOrEmpty(homeTeam) && String.IsNullOrEmpty(awayTeam)))
                                    continue;
                            }

                            var eventId = long.Parse(market.url.Replace("http://sports.williamhill.com/bet/en-gb/betting/e/", "").Split('/')[0]);

                            List<BookmakerMarket> feedMarkets = new List<BookmakerMarket>();
                            string places = String.Empty;
                            string ewReduction = String.Empty;


                            if (sport == SportType.AmericanFootball && market.name.Contains("Alternative"))
                            {
                                if (market.participant != null)
                                {
                                    List<IGrouping<string, XmlClasses.oxipResponseWilliamhillClassTypeMarketParticipant>> groupSpecialBet = new
                                         List<IGrouping<string, XmlClasses.oxipResponseWilliamhillClassTypeMarketParticipant>>();
                                    if (market.name.Contains("Handicap"))
                                    {
                                        groupSpecialBet = market.participant.GroupBy(gr => gr.name.Split('(')[1].Replace("points)", "").Replace("+", "").Replace("-", "").Trim()).ToList();
                                    }
                                    else
                                    {
                                        groupSpecialBet = market.participant.GroupBy(gr => gr.name.Split(' ')[1].Replace(" Points", "").Trim()).ToList();
                                    }

                                    foreach (IGrouping<string, XmlClasses.oxipResponseWilliamhillClassTypeMarketParticipant> gr in groupSpecialBet)
                                    {
                                        List<BookmakerOutcome> handOutcomes = new List<BookmakerOutcome>();

                                        foreach (var outcome in gr)
                                        {
                                            string name = String.Empty;
                                            if (outcome.name.Contains("-") || outcome.name.Contains("Under"))
                                                name = "Under";
                                            if (outcome.name.Contains("+") || outcome.name.Contains("Over"))
                                                name = "Over";



                                            decimal oddsDecimal = 0.00M;
                                            bool parsed = Decimal.TryParse(outcome.oddsDecimal, out oddsDecimal);
                                            if (parsed)
                                            {
                                                handOutcomes.Add(new BookmakerOutcome
                                                {
                                                    Name = name,
                                                    Odds = oddsDecimal
                                                });
                                            }
                                        }

                                        feedMarkets.Add(new BookmakerMarket
                                        {
                                            OddsType = sportConfiguration.GetOddsType(market.name.Split(new string[] { " - " }, StringSplitOptions.None)[1].Trim()),
                                            Name = market.name,
                                            SpecialBet = gr.Key,
                                            Outcomes = handOutcomes
                                        });
                                    }

                                }
                            }
                            else
                            {
                                string specialBet = String.Empty;
                                List<BookmakerOutcome> feedOutcomes = new List<BookmakerOutcome>();

                                foreach (var outcome in market.participant)
                                {
                                    if (market.name.Contains("Total Match Goals Over/Under"))
                                    {
                                        if (outcome.name.Contains("Under"))
                                        {
                                            specialBet = OddsUtils.ConvertToDecimalOdds(outcome.name.Split(' ')[1]);
                                            outcome.name = "Under";
                                        }
                                        if (outcome.name.Contains("Over"))
                                            outcome.name = "Over";
                                    }
                                    decimal oddsDecimal = 0.00M;
                                    bool parsed = Decimal.TryParse(outcome.oddsDecimal, out oddsDecimal);
                                    if (parsed)
                                    {
                                        feedOutcomes.Add(new BookmakerOutcome
                                        {
                                            Name = outcome.name,
                                            Odds = oddsDecimal
                                        });
                                    }
                                    if (!String.IsNullOrEmpty(outcome.handicap))
                                    {
                                        specialBet = OddsUtils.ConvertToDecimalOdds(outcome.handicap);
                                    }
                                }

                                feedMarkets.Add(new BookmakerMarket
                                {
                                    Id = market.id,
                                    Name = market.name,
                                    OddsType = sportConfiguration.GetOddsType(market.name.Split(new string[] { " - " }, StringSplitOptions.None)[1].Trim()),
                                    Outcomes = feedOutcomes,
                                    SpecialBet = specialBet
                                });
                                if (sport == SportType.HorseRacing || sport == SportType.GreyhoundRacing)
                                {
                                    places = market.ewPlaces.ToString();
                                    if (!String.IsNullOrEmpty(market.ewReduction))
                                    {
                                        int division = int.Parse(market.ewReduction.Split('/')[1]);
                                        ewReduction = RacingUtils.CalculateEwReduction(division);
                                        var placeOutcomes = new List<BookmakerOutcome>();
                                        foreach (var win_outc in feedOutcomes)
                                        {
                                            placeOutcomes.Add(new BookmakerOutcome { Name = win_outc.Name, Odds = RacingUtils.CalculatePlaceOdds(division, win_outc.Odds) });
                                        }
                                        feedMarkets.Add(new BookmakerMarket
                                        {
                                            OddsType = MarketType.PLAC,
                                            Outcomes = placeOutcomes
                                        });
                                    }
                                }
                            }

                            var datetime = market.date.AddTicks(market.time.Ticks);

                            string race = String.Empty;
                            if (sport == SportType.HorseRacing || sport == SportType.GreyhoundRacing)
                            {
                                race = market.name;
                                homeTeam = String.Empty;
                                awayTeam = String.Empty;
                            }

                            var eve = new BookmakerEvent
                            {
                                Id = eventId,
                                Name = market.name.Split('-')[0].Trim(),
                                Date = datetime,
                                HomeTeam = homeTeam,
                                AwayTeam = awayTeam,
                                Uri = market.url,
                                RaceName = race,
                                Markets = feedMarkets,
                                Places = places,
                                EwReduction = ewReduction
                            };


                            if (feedTournaments.FirstOrDefault(tr => tr.Id == tournament.id) != null)
                            {
                                if (feedTournaments.FirstOrDefault(tr => tr.Id == tournament.id).
                                    Events.FirstOrDefault(ev => ev.Id == eventId) != null)
                                {
                                    feedTournaments.FirstOrDefault(tr => tr.Id == tournament.id).
                                    Events.FirstOrDefault(ev => ev.Id == eventId).Markets.AddRange(feedMarkets);
                                }
                                else
                                {
                                    feedTournaments.FirstOrDefault(tr => tr.Id == tournament.id).Events.Add(eve);
                                }
                            }
                            else
                            {
                                feedTournaments.Add(new BookmakerTournament
                                {
                                    Id = tournament.id,
                                    Name = tournament.name,
                                    Country = "Empty",
                                    Events = new List<BookmakerEvent> { eve }
                                });
                            }
                        }
                    }
                }
                if (sport == SportType.HorseRacing || sport == SportType.GreyhoundRacing)
                {

                    foreach (var tournament in feedTournaments)
                    {
                        List<BookmakerEvent> hr_events = tournament.Events.OrderBy(dt => dt.Date).ToList();
                        int round = 1;
                        foreach (var eve in hr_events)
                        {
                            hr_events.FirstOrDefault(ev => ev.Id == eve.Id).RoundId = round;
                            round++;
                        }
                        feedTournaments.FirstOrDefault(tour => tour.Id == tournament.Id).Events = hr_events;
                    }
                }

                returnFeed.Sports.Add(new BookmakerSport
                {
                    Id = (long)sport,
                    Name = sportConfiguration.Name,
                    TypeSp = sport,
                    Tournaments = feedTournaments
                });
            }
            return returnFeed;
        }
    }
}
