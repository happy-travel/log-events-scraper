using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HappyTravel.Funai.Configurations;
using Microsoft.Extensions.Options;

namespace HappyTravel.Funai.Services
{
    public class LogEventsService : ILogEventsService
    {
        public LogEventsService(IGitHubService gitHubService, IOptions<Settings> settings)
        {
            _gitHubService = gitHubService;
            _settings = settings.Value;
        }


        private async Task<string> GenerateMarkdown(string searchFile)
        {
            // disallow search of short named files
            // if the term will be an empty string, github api will return every file
            if (searchFile.Length < 5)
                throw new ArgumentException("Search file name cannot be shorter than 5 letters");
            
            var files = await _gitHubService.SearchFile(searchFile);
            var filesByRepository = new Dictionary<string, StringBuilder>();
            foreach (var file in files)
            {
                var (repository, path) = (file.RepositoryName, file.FilePath);
                if (!filesByRepository.ContainsKey(repository))
                    filesByRepository.Add(repository, new StringBuilder());

                filesByRepository[repository].AppendLine($"### {path}"); 
                filesByRepository[repository].AppendLine("```json");
                filesByRepository[repository].AppendLine(await _gitHubService.DownloadFile(repository, path));
                filesByRepository[repository].AppendLine("```");
                filesByRepository[repository].AppendLine();
            }

            var final = new StringBuilder();
            foreach (var (repository, content) in filesByRepository)
            {
                final.AppendLine($"## {repository}");
                final.AppendLine();
                final.Append(content);
            }

            final.AppendLine($"**Updated on: {DateTime.UtcNow}**");
            return final.ToString();
        }

        public async Task<string> RefreshEventIds()
        {
            var markdown = await GenerateMarkdown(_settings.SearchFile);
            var fileUrl = await _gitHubService.CreateFileOrUpdate(markdown, _settings.UploadToOwner,
                _settings.UploadToRepository, _settings.UploadToFile);
            return fileUrl;
        }

        private readonly IGitHubService _gitHubService;
        private readonly Settings _settings;
    }
}