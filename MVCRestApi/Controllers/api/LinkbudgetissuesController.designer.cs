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
    public partial class LinkbudgetissuesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Linkbudgetissue> Linkbudgetissues);
        partial void OnAfterGetById(Linkbudgetissue Linkbudgetissues, Guid linkbudgetissueId);
        partial void OnBeforePost(Linkbudgetissue linkbudgetissue);
        partial void OnAfterPost(Linkbudgetissue linkbudgetissue);
        partial void OnBeforePut(Linkbudgetissue linkbudgetissue);
        partial void OnAfterPut(Linkbudgetissue linkbudgetissue);
        partial void OnBeforeDelete(Linkbudgetissue linkbudgetissue);
        partial void OnAfterDelete(Linkbudgetissue linkbudgetissue);
        

        public LinkbudgetissuesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Linkbudgetissue
        public IEnumerable<Linkbudgetissue> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllLinkbudgetissues<Linkbudgetissue>();
            Linkbudgetissue.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Linkbudgetissues/{linkbudgetissue-guid}
        public Linkbudgetissue Get(Guid linkbudgetissueId)
        {
            var LinkbudgetissuesWhere = String.Format("LinkbudgetissueId = '{0}'", linkbudgetissueId);
            var result = this.SDM.GetAllLinkbudgetissues<Linkbudgetissue>(LinkbudgetissuesWhere).FirstOrDefault();
            this.OnAfterGetById(result, linkbudgetissueId);
            return result;
        }

        // POST api/Linkbudgetissues/{linkbudgetissue-guid}
        public Linkbudgetissue Post([FromBody]Linkbudgetissue linkbudgetissue)
        {
            if (linkbudgetissue.LinkbudgetissueId == Guid.Empty) linkbudgetissue.LinkbudgetissueId = Guid.NewGuid();
            this.OnBeforePost(linkbudgetissue);
            this.SDM.Upsert(linkbudgetissue);
            this.OnAfterPost(linkbudgetissue);
            return linkbudgetissue;
        }

        // POST api/Linkbudgetissues/{linkbudgetissue-guid}
        public Linkbudgetissue Put([FromBody]Linkbudgetissue linkbudgetissue)
        {
            if (linkbudgetissue.LinkbudgetissueId == Guid.Empty) linkbudgetissue.LinkbudgetissueId = Guid.NewGuid();
            this.OnBeforePut(linkbudgetissue);
            this.SDM.Upsert(linkbudgetissue);
            this.OnAfterPut(linkbudgetissue);
            return linkbudgetissue;
        }

        // POST api/Linkbudgetissues/{linkbudgetissue-guid}
        public void Delete(Guid linkbudgetissueId)
        {
            var linkbudgetissueWhere = String.Format("LinkbudgetissueId = '{0}'", linkbudgetissueId);
            var linkbudgetissue = this.SDM.GetAllLinkbudgetissues<Linkbudgetissue>(linkbudgetissueWhere).FirstOrDefault();
            this.OnBeforeDelete(linkbudgetissue);
            this.SDM.Delete(linkbudgetissue);
            this.OnAfterDelete(linkbudgetissue);
        }
    }
}
