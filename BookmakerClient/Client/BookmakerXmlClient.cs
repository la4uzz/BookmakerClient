using BookmakerClient.Configuration;
using BookmakerClient.Core;
using BookmakerClient.Enums;
using BookmakerClient.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace BookmakerClient.Client
{
    public abstract class BookmakerXmlClient : IBookmakerClient
    {
        public IBookmakerConfiguration Configuration { get; private set; }

        protected BookmakerXmlClient(IBookmakerConfiguration configuration)
        {
            Configuration = configuration;
        }

        public abstract BookmakerFeed GetBookmakerFeed(List<SportType> sports);

        protected static string Get(Uri uri)
        {

            using (var client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(200);
                using (var response = client.GetAsync
                    (uri).Result)
                {
                    response.EnsureSuccessStatusCode();
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
        }
    }
}
