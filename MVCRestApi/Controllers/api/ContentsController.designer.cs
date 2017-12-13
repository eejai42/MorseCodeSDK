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
    public partial class ContentsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Content> Contents);
        partial void OnAfterGetById(Content Contents, Guid contentId);
        partial void OnBeforePost(Content content);
        partial void OnAfterPost(Content content);
        partial void OnBeforePut(Content content);
        partial void OnAfterPut(Content content);
        partial void OnBeforeDelete(Content content);
        partial void OnAfterDelete(Content content);
        

        public ContentsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Content
        public IEnumerable<Content> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllContents<Content>();
            Content.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Contents/{content-guid}
        public Content Get(Guid contentId)
        {
            var ContentsWhere = String.Format("ContentId = '{0}'", contentId);
            var result = this.SDM.GetAllContents<Content>(ContentsWhere).FirstOrDefault();
            this.OnAfterGetById(result, contentId);
            return result;
        }

        // POST api/Contents/{content-guid}
        public Content Post([FromBody]Content content)
        {
            if (content.ContentId == Guid.Empty) content.ContentId = Guid.NewGuid();
            this.OnBeforePost(content);
            this.SDM.Upsert(content);
            this.OnAfterPost(content);
            return content;
        }

        // POST api/Contents/{content-guid}
        public Content Put([FromBody]Content content)
        {
            if (content.ContentId == Guid.Empty) content.ContentId = Guid.NewGuid();
            this.OnBeforePut(content);
            this.SDM.Upsert(content);
            this.OnAfterPut(content);
            return content;
        }

        // POST api/Contents/{content-guid}
        public void Delete(Guid contentId)
        {
            var contentWhere = String.Format("ContentId = '{0}'", contentId);
            var content = this.SDM.GetAllContents<Content>(contentWhere).FirstOrDefault();
            this.OnBeforeDelete(content);
            this.SDM.Delete(content);
            this.OnAfterDelete(content);
        }
    }
}
