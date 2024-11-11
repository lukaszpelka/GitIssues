using IssuesManagerAbstract;
using Microsoft.AspNetCore.Mvc;

namespace GitIssues.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IssuesController : ControllerBase
    {
        private IIssuesManager _issuesManager;

        public IssuesController(IIssuesManager issuesManager)
        {
            _issuesManager = issuesManager;
        }

        [HttpGet]
        public async Task<ActionResult<string>> GetAllIssues()
        {
            using (HttpResponseMessage response = await _issuesManager.GetAllIssuesAsync())
            {
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


        [HttpPost]
        public async Task<ActionResult<string>> AddIssue(string name, string description)
        {
            using (HttpResponseMessage response = await _issuesManager.AddIssueAsync(name, description))
            {
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

        [HttpPatch]
        public async Task<ActionResult<string>> ModifyIssue(string name, string description, int issueNumber)
        {
            using (HttpResponseMessage response = await _issuesManager.ModifyIssueAsync(name, description, issueNumber))
            {
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

        [HttpPatch]
        [Route("CloseIssue")]
        public async Task<ActionResult<string>> CloseIssue(int issueNumber)
        {
            using (HttpResponseMessage response = await _issuesManager.CloseIssueAsync(issueNumber))
            {
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
}
