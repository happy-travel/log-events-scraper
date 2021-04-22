using System.Threading.Tasks;
using HappyTravel.Funai.Configurations;
using HappyTravel.Funai.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace HappyTravel.Funai.Controllers
{
    [ApiController, Route("[controller]")]
    public class GitHubController : ControllerBase
    {
        public GitHubController(ILogEventsService logEventsService, IOptions<FunaiSettings> settings)
        {
            _settings = settings.Value;
            _logEventsService = logEventsService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _logEventsService.RefreshEventIds();
            var fileUrl =
                $"https://github.com/{_settings.UploadToOwner}/{_settings.UploadToRepository}/blob/main/{_settings.UploadToFile}";
            return Ok(fileUrl);
        }

        private readonly ILogEventsService _logEventsService;
        private readonly FunaiSettings _settings;
    }
}