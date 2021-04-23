using System.Collections.Generic;
using System.Threading.Tasks;
using HappyTravel.Funai.Classes;
using Octokit;

namespace HappyTravel.Funai.Services
{
    public interface IGitHubService
    {
        Task<IEnumerable<SearchItem>> SearchFile(string filename);
        Task<string> DownloadFile(string repository, string path);
        Task<string> CreateFileOrUpdate(string content, string user, string repository, string path);
    } 
}