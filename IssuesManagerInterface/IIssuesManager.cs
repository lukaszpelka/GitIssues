using Microsoft.AspNetCore.Mvc;

namespace IssuesManagerAbstract
{
    public interface IIssuesManager
    {
        public Task<HttpResponseMessage> GetAllIssues();

        public Task<HttpResponseMessage> AddIssue(string name, string description);

        public Task<HttpResponseMessage> ModifyIssue(string name, string description, int issueNumber);

        public Task<HttpResponseMessage> CloseIssue(int issueNumber);
    }
}
