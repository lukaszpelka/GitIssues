using IssuesManagerAbstract;

namespace GitLabIssuesManager
{
    public class GitLabIssuesManager : IIssuesManager
    {
        public async Task<HttpResponseMessage> AddIssueAsync(string name, string description)
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Post, "https://gitlab.com/api/v4/projects/64400124/issues");
            FillRequestHeaders(request);

            var contentJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { description = description, title = name });

            using var content = new StringContent(contentJson, null, "application/json");
            request.Content = content;

            HttpResponseMessage response = await client.SendAsync(request);
            return response;
        }

        public async Task<HttpResponseMessage> CloseIssueAsync(int issueNumber)
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Put, $"https://gitlab.com/api/v4/projects/64400124/issues/{issueNumber}");
            FillRequestHeaders(request);

            var contentJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { state_event = "close" });

            using var content = new StringContent(contentJson, null, "application/json");
            request.Content = content;

            HttpResponseMessage response = await client.SendAsync(request);
            return response;
        }

        public async Task<HttpResponseMessage> GetAllIssuesAsync()
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Get, "https://gitlab.com/api/v4/projects/64400124/issues");
            FillRequestHeaders(request);

            HttpResponseMessage response = await client.SendAsync(request);
            return response;
        }

        public async Task<HttpResponseMessage> ModifyIssueAsync(string name, string description, int issueNumber)
        {
            using var client = new HttpClient();
            using var request = new HttpRequestMessage(HttpMethod.Put, $"https://gitlab.com/api/v4/projects/64400124/issues/{issueNumber}");
            FillRequestHeaders(request);

            var contentJson = Newtonsoft.Json.JsonConvert.SerializeObject(new { description = description, title = name });

            using var content = new StringContent(contentJson, null, "application/json");
            request.Content = content;

            HttpResponseMessage response = await client.SendAsync(request);
            return response;
        }

        private static void FillRequestHeaders(HttpRequestMessage request)
        {
            request.Headers.Add("PRIVATE-TOKEN", "glpat-xxxxxxxxxxxxxxxxxxxxxxxx");
        }
    }
}