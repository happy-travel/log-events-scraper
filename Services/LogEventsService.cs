using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HappyTravel.Funai.Services
{
    public class LogEventsService : ILogEventsService
    {
        public LogEventsService(IGitHubService gitHubService)
        {
            _gitHubService = gitHubService;
        }


        public async Task<string> GenerateMarkdown()
        {
            var files = await _gitHubService.SearchFile("LogEvents.json");
            var downloaded = new HashSet<string>();
            var markdown = string.Empty;
            foreach (var file in files)
            {
                if (downloaded.Contains(file.RepositoryName))
                    continue;

                downloaded.Add(file.RepositoryName);
                
                markdown += $"## {file.RepositoryName}\n\n";
                markdown += "```json\n";
                markdown += await _gitHubService.DownloadFile(file.RepositoryName, file.FilePath);
                markdown += "\n";
                markdown += "```";
                markdown += "\n\n";
            }

            markdown += $"**Updated on: {DateTime.UtcNow}**";
            return markdown;
        }


        public async Task CreateFileOrUpdate(string content)
        {
            await _gitHubService.CreateFileOrUpdate(content);
        }


        public async Task RefreshEventIds()
        {
            var markdown = await GenerateMarkdown();
            await _gitHubService.CreateFileOrUpdate(markdown);
        }

        private readonly IGitHubService _gitHubService;
    }
}