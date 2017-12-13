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
    public partial class ExternallinksController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Externallink> Externallinks);
        partial void OnAfterGetById(Externallink Externallinks, Guid externallinkId);
        partial void OnBeforePost(Externallink externallink);
        partial void OnAfterPost(Externallink externallink);
        partial void OnBeforePut(Externallink externallink);
        partial void OnAfterPut(Externallink externallink);
        partial void OnBeforeDelete(Externallink externallink);
        partial void OnAfterDelete(Externallink externallink);
        

        public ExternallinksController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Externallink
        public IEnumerable<Externallink> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllExternallinks<Externallink>();
            Externallink.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Externallinks/{externallink-guid}
        public Externallink Get(Guid externallinkId)
        {
            var ExternallinksWhere = String.Format("ExternallinkId = '{0}'", externallinkId);
            var result = this.SDM.GetAllExternallinks<Externallink>(ExternallinksWhere).FirstOrDefault();
            this.OnAfterGetById(result, externallinkId);
            return result;
        }

        // POST api/Externallinks/{externallink-guid}
        public Externallink Post([FromBody]Externallink externallink)
        {
            if (externallink.ExternallinkId == Guid.Empty) externallink.ExternallinkId = Guid.NewGuid();
            this.OnBeforePost(externallink);
            this.SDM.Upsert(externallink);
            this.OnAfterPost(externallink);
            return externallink;
        }

        // POST api/Externallinks/{externallink-guid}
        public Externallink Put([FromBody]Externallink externallink)
        {
            if (externallink.ExternallinkId == Guid.Empty) externallink.ExternallinkId = Guid.NewGuid();
            this.OnBeforePut(externallink);
            this.SDM.Upsert(externallink);
            this.OnAfterPut(externallink);
            return externallink;
        }

        // POST api/Externallinks/{externallink-guid}
        public void Delete(Guid externallinkId)
        {
            var externallinkWhere = String.Format("ExternallinkId = '{0}'", externallinkId);
            var externallink = this.SDM.GetAllExternallinks<Externallink>(externallinkWhere).FirstOrDefault();
            this.OnBeforeDelete(externallink);
            this.SDM.Delete(externallink);
            this.OnAfterDelete(externallink);
        }
    }
}
