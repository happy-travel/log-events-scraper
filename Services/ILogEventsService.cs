using System.Threading.Tasks;

namespace HappyTravel.Funai.Services
{
    public interface ILogEventsService
    {
        Task<string> GenerateMarkdown();
        Task CreateFileOrUpdate(string content);
        Task RefreshEventIds();
    }
}