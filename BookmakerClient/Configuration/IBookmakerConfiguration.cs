using BookmakerClient.Enums;
using System.Collections.Generic;

namespace BookmakerClient.Configuration
{
    public interface IBookmakerConfiguration
    {
        BookmakerType Bookmaker { get; set; }
        List<SportConfiguration> Sports { get; set; }
        bool IsOneUrl { get; set; }
        string BookmakerUrl { get; set; }


    }
}
