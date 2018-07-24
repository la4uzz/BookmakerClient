using BookmakerClient.Configuration;

namespace BookmakerClient.Client
{
    public interface IBookmakerClient
    {
        IBookmakerConfiguration Configuration { get; }
    }
}
