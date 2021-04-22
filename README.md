# Log Events Gatherer

The service makes search request to the GitHub API to find every LogEvents.json file. It also searches inside private repositories.
Then it downloads each file, converts them to a single markdown document and upload the document to the specified repository.
If the document already exists, it will be updated by the new one.

Requirements:

