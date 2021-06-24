using System.Threading.Tasks;

namespace HappyTravel.LogEventsScraper.Services
{
    public interface ILogEventsService
    {
        Task<string> RefreshEventIds();
    }
}