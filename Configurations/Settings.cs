namespace HappyTravel.LogEventsScraper.Configurations
{
    public class Settings
    {
        /// <summary>
        /// Name of the file to search for
        /// </summary>
        public string SearchFile { get; set; }
        
        /// <summary>
        /// Search inside organization
        /// </summary>
        public string GitHubOrganization { get; set; }
        
        /// <summary>
        /// Acts like useragent in queries. Can be anything
        /// </summary>
        public string GitHubAgentName { get; set; }
        
        /// <summary>
        /// Token with appropriate permissions
        /// </summary>
        public string GitHubToken { get; set; }
        
        /// <summary>
        /// Organization or user to upload resulting file
        /// </summary>
        public string UploadToOwner { get; set; }
        
        /// <summary>
        /// Repository to upload
        /// </summary>
        public string UploadToRepository { get; set; }
        
        /// <summary>
        /// Filename to upload
        /// </summary>
        public string UploadToFile { get; set; }
    }
}