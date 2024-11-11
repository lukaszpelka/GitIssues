using IssuesManagerAbstract;

namespace GitHubIssuesManager
{
    public class GitHubIssuesManager : IIssuesManager
    {
        public async Task<HttpResponseMessage> AddIssueAsync(string repositoryApiURL, string name, string description)
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Post, $"{repositoryApiURL}/issues");
            FillRequestHeaders(request);

            var contentJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { body = description, title = name });

            using var content = new StringContent(contentJson, null, "application/json");
            request.Content = content;

            HttpResponseMessage response = await client.SendAsync(request);
            return response;
        }

        public async Task<HttpResponseMessage> CloseIssueAsync(string repositoryApiURL, int issueNumber)
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Patch, $"{repositoryApiURL}/issues/{issueNumber}");
            FillRequestHeaders(request);

            var contentJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { state = "closed", state_reason = "completed" });

            using var content = new StringContent(contentJson, null, "application/json");
            request.Content = content;

            HttpResponseMessage response = await client.SendAsync(request);
            return response;
        }

        public async Task<HttpResponseMessage> GetAllIssuesAsync(string repositoryApiURL)
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Get, $"{repositoryApiURL}/issues");
            FillRequestHeaders(request);

            HttpResponseMessage response = await client.SendAsync(request);
            return response;
        }

        public async Task<HttpResponseMessage> ModifyIssueAsync(string repositoryApiURL, string name, string description, int issueNumber)
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Patch, $"{repositoryApiURL}/issues/{issueNumber}");
            FillRequestHeaders(request);

            var contentJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { body = description, title = name });

            using var content = new StringContent(contentJson, null, "application/json");
            request.Content = content;

            HttpResponseMessage response = await client.SendAsync(request);
            return response;
        }

        private static void FillRequestHeaders(HttpRequestMessage request)
        {
            request.Headers.Add("X-GitHub-Api-Version", "2022-11-28");
            request.Headers.Add("Accept", "application/vnd.github+json");
            request.Headers.Add("User-Agent", "xxxxxxxx");
            request.Headers.Add("Authorization", "Bearer github_pat_xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        }
    }
}
