using System.Collections.Generic;
using System.Threading.Tasks;
using HappyTravel.LogEventsScraper.Classes;
using Octokit;

namespace HappyTravel.LogEventsScraper.Services
{
    public interface IGitHubService
    {
        Task<IEnumerable<SearchItem>> SearchFile(string filename);
        Task<string> DownloadFile(string repository, string path);
        Task<string> CreateFileOrUpdate(string content, string user, string repository, string path);
    } 
}