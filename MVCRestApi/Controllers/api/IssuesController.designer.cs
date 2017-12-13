using MorseCodeSDK.Lib.SqlDataManagement;
using MorseCodeSDK.Lib.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;

namespace WebApplication1.Areas.RESTApi.Controllers
{
    public partial class IssuesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Issue> Issues);
        partial void OnAfterGetById(Issue Issues, Guid issueId);
        partial void OnBeforePost(Issue issue);
        partial void OnAfterPost(Issue issue);
        partial void OnBeforePut(Issue issue);
        partial void OnAfterPut(Issue issue);
        partial void OnBeforeDelete(Issue issue);
        partial void OnAfterDelete(Issue issue);
        

        public IssuesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Issue
        public IEnumerable<Issue> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllIssues<Issue>();
            Issue.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Issues/{issue-guid}
        public Issue Get(Guid issueId)
        {
            var IssuesWhere = String.Format("IssueId = '{0}'", issueId);
            var result = this.SDM.GetAllIssues<Issue>(IssuesWhere).FirstOrDefault();
            this.OnAfterGetById(result, issueId);
            return result;
        }

        // POST api/Issues/{issue-guid}
        public Issue Post([FromBody]Issue issue)
        {
            if (issue.IssueId == Guid.Empty) issue.IssueId = Guid.NewGuid();
            this.OnBeforePost(issue);
            this.SDM.Upsert(issue);
            this.OnAfterPost(issue);
            return issue;
        }

        // POST api/Issues/{issue-guid}
        public Issue Put([FromBody]Issue issue)
        {
            if (issue.IssueId == Guid.Empty) issue.IssueId = Guid.NewGuid();
            this.OnBeforePut(issue);
            this.SDM.Upsert(issue);
            this.OnAfterPut(issue);
            return issue;
        }

        // POST api/Issues/{issue-guid}
        public void Delete(Guid issueId)
        {
            var issueWhere = String.Format("IssueId = '{0}'", issueId);
            var issue = this.SDM.GetAllIssues<Issue>(issueWhere).FirstOrDefault();
            this.OnBeforeDelete(issue);
            this.SDM.Delete(issue);
            this.OnAfterDelete(issue);
        }
    }
}
