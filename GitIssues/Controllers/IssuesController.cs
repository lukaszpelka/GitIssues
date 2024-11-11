using IssuesManagerAbstract;
using Microsoft.AspNetCore.Mvc;

namespace GitIssuesManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private readonly IIssuesManager _issuesManager;

        public IssuesController(IIssuesManager issuesManager)
        {
            _issuesManager = issuesManager;
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetAllIssues(string repositoryApiURL)
        {
            using HttpResponseMessage response = await _issuesManager.GetAllIssuesAsync(repositoryApiURL);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return Problem(await response.Content.ReadAsStringAsync(), statusCode: ((int)response.StatusCode));
            }
        }

        [HttpPost]
        public async Task<ActionResult<string>> AddIssue(string repositoryApiURL, string name, string description)
        {
            using HttpResponseMessage response = await _issuesManager.AddIssueAsync(repositoryApiURL, name, description);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return Problem(await response.Content.ReadAsStringAsync(), statusCode: ((int)response.StatusCode));
            }
        }

        [HttpPatch]
        public async Task<ActionResult<string>> ModifyIssue(string repositoryApiURL, string name, string description, int issueNumber)
        {
            using HttpResponseMessage response = await _issuesManager.ModifyIssueAsync(repositoryApiURL, name, description, issueNumber);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return Problem(await response.Content.ReadAsStringAsync(), statusCode: ((int)response.StatusCode));
            }
        }

        [HttpPatch]
        [Route("CloseIssue")]
        public async Task<ActionResult<string>> CloseIssue(string repositoryApiURL, int issueNumber)
        {
            using HttpResponseMessage response = await _issuesManager.CloseIssueAsync(repositoryApiURL, issueNumber);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return Problem(await response.Content.ReadAsStringAsync(), statusCode: ((int)response.StatusCode));
            }
        }
    }
}
