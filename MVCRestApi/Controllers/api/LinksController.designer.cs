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
    public partial class LinksController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Link> Links);
        partial void OnAfterGetById(Link Links, Guid linkId);
        partial void OnBeforePost(Link link);
        partial void OnAfterPost(Link link);
        partial void OnBeforePut(Link link);
        partial void OnAfterPut(Link link);
        partial void OnBeforeDelete(Link link);
        partial void OnAfterDelete(Link link);
        

        public LinksController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Link
        public IEnumerable<Link> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllLinks<Link>();
            Link.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Links/{link-guid}
        public Link Get(Guid linkId)
        {
            var LinksWhere = String.Format("LinkId = '{0}'", linkId);
            var result = this.SDM.GetAllLinks<Link>(LinksWhere).FirstOrDefault();
            this.OnAfterGetById(result, linkId);
            return result;
        }

        // POST api/Links/{link-guid}
        public Link Post([FromBody]Link link)
        {
            if (link.LinkId == Guid.Empty) link.LinkId = Guid.NewGuid();
            this.OnBeforePost(link);
            this.SDM.Upsert(link);
            this.OnAfterPost(link);
            return link;
        }

        // POST api/Links/{link-guid}
        public Link Put([FromBody]Link link)
        {
            if (link.LinkId == Guid.Empty) link.LinkId = Guid.NewGuid();
            this.OnBeforePut(link);
            this.SDM.Upsert(link);
            this.OnAfterPut(link);
            return link;
        }

        // POST api/Links/{link-guid}
        public void Delete(Guid linkId)
        {
            var linkWhere = String.Format("LinkId = '{0}'", linkId);
            var link = this.SDM.GetAllLinks<Link>(linkWhere).FirstOrDefault();
            this.OnBeforeDelete(link);
            this.SDM.Delete(link);
            this.OnAfterDelete(link);
        }
    }
}
