using IssuesManagerAbstract;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Xml.Linq;

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
        public async Task<ActionResult<IssuesManagerAbstract.Issue[]>> GetAllIssues()
        {
            using (HttpResponseMessage response = await _issuesManager.GetAllIssues())
            {
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<Issue[]>(await response.Content.ReadAsStringAsync()) ?? Array.Empty<Issue>();
                }
                else
                {
                    return Problem(await response.Content.ReadAsStringAsync(), await response.RequestMessage.Content.ReadAsStringAsync(), ((int)response.StatusCode));
                }
            }
        }


        [HttpPost]
        public async Task<ActionResult<IssuesManagerAbstract.Issue>> AddIssue(string name, string description)
        {
            using (HttpResponseMessage response = await _issuesManager.AddIssue(name, description))
            {
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<Issue>(await response.Content.ReadAsStringAsync()) ?? new Issue();
                }
                else
                {
                    return Problem(await response.Content.ReadAsStringAsync(), await response.RequestMessage.Content.ReadAsStringAsync(), ((int)response.StatusCode));
                }
            }
        }

        [HttpPatch]
        public async Task<ActionResult<IssuesManagerAbstract.Issue>> ModifyIssue(string name, string description, int issueNumber)
        {
            using (HttpResponseMessage response = await _issuesManager.ModifyIssue(name, description, issueNumber))
            {
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<Issue>(await response.Content.ReadAsStringAsync()) ?? new Issue();
                }
                else
                {
                    return Problem(await response.Content.ReadAsStringAsync(), await response.RequestMessage.Content.ReadAsStringAsync(), ((int)response.StatusCode));
                }
            }
        }

        [HttpPatch]
        [Route("CloseIssue")]
        public async Task<ActionResult<IssuesManagerAbstract.Issue>> CloseIssue(int issueNumber)
        {
            using (HttpResponseMessage response = await _issuesManager.CloseIssue(issueNumber))
            {
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<Issue>(await response.Content.ReadAsStringAsync()) ?? new Issue();
                }
                else
                {
                    return Problem(await response.Content.ReadAsStringAsync(), await response.RequestMessage.Content.ReadAsStringAsync(), ((int)response.StatusCode));
                }
            }
        }
    }
}
