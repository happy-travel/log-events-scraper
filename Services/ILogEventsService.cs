using System.Threading.Tasks;

namespace HappyTravel.Funai.Services
{
    public interface ILogEventsService
    {
        Task<string> RefreshEventIds();
    }
}