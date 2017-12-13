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
    public partial class HeadsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Head> Heads);
        partial void OnAfterGetById(Head Heads, Guid headId);
        partial void OnBeforePost(Head head);
        partial void OnAfterPost(Head head);
        partial void OnBeforePut(Head head);
        partial void OnAfterPut(Head head);
        partial void OnBeforeDelete(Head head);
        partial void OnAfterDelete(Head head);
        

        public HeadsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Head
        public IEnumerable<Head> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllHeads<Head>();
            Head.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Heads/{head-guid}
        public Head Get(Guid headId)
        {
            var HeadsWhere = String.Format("HeadId = '{0}'", headId);
            var result = this.SDM.GetAllHeads<Head>(HeadsWhere).FirstOrDefault();
            this.OnAfterGetById(result, headId);
            return result;
        }

        // POST api/Heads/{head-guid}
        public Head Post([FromBody]Head head)
        {
            if (head.HeadId == Guid.Empty) head.HeadId = Guid.NewGuid();
            this.OnBeforePost(head);
            this.SDM.Upsert(head);
            this.OnAfterPost(head);
            return head;
        }

        // POST api/Heads/{head-guid}
        public Head Put([FromBody]Head head)
        {
            if (head.HeadId == Guid.Empty) head.HeadId = Guid.NewGuid();
            this.OnBeforePut(head);
            this.SDM.Upsert(head);
            this.OnAfterPut(head);
            return head;
        }

        // POST api/Heads/{head-guid}
        public void Delete(Guid headId)
        {
            var headWhere = String.Format("HeadId = '{0}'", headId);
            var head = this.SDM.GetAllHeads<Head>(headWhere).FirstOrDefault();
            this.OnBeforeDelete(head);
            this.SDM.Delete(head);
            this.OnAfterDelete(head);
        }
    }
}
