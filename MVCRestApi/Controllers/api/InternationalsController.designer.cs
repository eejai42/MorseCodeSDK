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
    public partial class InternationalsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<International> Internationals);
        partial void OnAfterGetById(International Internationals, Guid internationalId);
        partial void OnBeforePost(International international);
        partial void OnAfterPost(International international);
        partial void OnBeforePut(International international);
        partial void OnAfterPut(International international);
        partial void OnBeforeDelete(International international);
        partial void OnAfterDelete(International international);
        

        public InternationalsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/International
        public IEnumerable<International> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllInternationals<International>();
            International.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Internationals/{international-guid}
        public International Get(Guid internationalId)
        {
            var InternationalsWhere = String.Format("InternationalId = '{0}'", internationalId);
            var result = this.SDM.GetAllInternationals<International>(InternationalsWhere).FirstOrDefault();
            this.OnAfterGetById(result, internationalId);
            return result;
        }

        // POST api/Internationals/{international-guid}
        public International Post([FromBody]International international)
        {
            if (international.InternationalId == Guid.Empty) international.InternationalId = Guid.NewGuid();
            this.OnBeforePost(international);
            this.SDM.Upsert(international);
            this.OnAfterPost(international);
            return international;
        }

        // POST api/Internationals/{international-guid}
        public International Put([FromBody]International international)
        {
            if (international.InternationalId == Guid.Empty) international.InternationalId = Guid.NewGuid();
            this.OnBeforePut(international);
            this.SDM.Upsert(international);
            this.OnAfterPut(international);
            return international;
        }

        // POST api/Internationals/{international-guid}
        public void Delete(Guid internationalId)
        {
            var internationalWhere = String.Format("InternationalId = '{0}'", internationalId);
            var international = this.SDM.GetAllInternationals<International>(internationalWhere).FirstOrDefault();
            this.OnBeforeDelete(international);
            this.SDM.Delete(international);
            this.OnAfterDelete(international);
        }
    }
}
