[**=> Log Events List**](https://github.com/happy-travel/log-events-scraper/blob/main/LogEvents.md)

# Log Events Scraper

The service makes search request to the GitHub API to find every LogEvents.json file. It also searches inside private repositories.
Then it downloads each file, converts them to a single markdown document and upload the document to the specified repository.
If the document already exists, it will be updated by the new one.

## How To Use

1. Specify github token in appsetting.json 
   
   or
   in the environment variable **GITHUB_TOKEN**
2. Run the project
3. Scraping of the files will start immediately   
3. If everything's fine the message "The file has been updated" and the link to file should be displayed
4. Open the link to the file displayed in the console. 

Default is: https://github.com/happy-travel/log-events-scraper/blob/main/LogEvents.md

## Token

The personal happy travel token should work. But you can also generate a separate token here https://github.com/settings/tokens

It should have the following permissions:

- [x] repo
  - [x] repo Full control of private repositories
  - [x] repo:status Access commit status
  - [x] repo_deployment Access deployment status
  - [x] public_repo Access public repositories
  - [x] repo:invite Access repository invitations
  - [x] security_events Read and write security events