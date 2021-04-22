using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HappyTravel.Funai.Classes;
using HappyTravel.Funai.Configurations;
using Microsoft.Extensions.Options;
using Octokit;

namespace HappyTravel.Funai.Services
{
    public class GitHubService : IGitHubService
    {
        public GitHubService(IOptions<FunaiSettings> settings)
        {
            _settings = settings.Value;
            _client = new GitHubClient(new ProductHeaderValue(_settings.GitHubAgentName))
            {
                Credentials = new Credentials(_settings.GitHubToken)
            };
        }
        
        
        public async Task<IEnumerable<SearchItem>> SearchFile(string filename)
        {
            var searchRequest = new SearchCodeRequest
            {
                FileName = filename,
                Users = new []{_settings.GitHubOrganization}
            };
            
            var results = await _client.Search.SearchCode(searchRequest);
            return results.Items.Select(x => new SearchItem
            {
                FilePath = x.Path,
                RepositoryName = x.Repository.Name
            });
        }

        
        public async Task<string> DownloadFile(string repository, string path)
        {
            var files = await _client
                .Repository
                .Content
                .GetAllContents(_settings.GitHubOrganization, repository, path);
            
            return files[0].Content;
        }


        public async Task CreateFileOrUpdate(string content)
        {
            var sha = string.Empty;
            try
            {
                var files = await _client.Repository.Content.GetAllContents(_settings.UploadToOwner, _settings.UploadToRepository, _settings.UploadToFile);
                sha = files[0].Sha;
            }
            catch (NotFoundException)
            {
                // if the file is not found Octokit throws NotFoundException
            }

            if (sha == string.Empty)
            {
                var request = new CreateFileRequest("Create file", content);
                await _client.Repository.Content.CreateFile(_settings.UploadToOwner, _settings.UploadToRepository, _settings.UploadToFile, request);
            }
            else
            {
                var request = new UpdateFileRequest("Update file", content, sha);
                await _client.Repository.Content.UpdateFile(_settings.UploadToOwner, _settings.UploadToRepository, _settings.UploadToFile, request);
            }
        }

        private readonly FunaiSettings _settings;
        private readonly GitHubClient _client;
    }
}