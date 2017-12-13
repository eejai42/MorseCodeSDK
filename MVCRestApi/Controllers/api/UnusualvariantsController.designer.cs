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
    public partial class UnusualvariantsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Unusualvariant> Unusualvariants);
        partial void OnAfterGetById(Unusualvariant Unusualvariants, Guid unusualvariantId);
        partial void OnBeforePost(Unusualvariant unusualvariant);
        partial void OnAfterPost(Unusualvariant unusualvariant);
        partial void OnBeforePut(Unusualvariant unusualvariant);
        partial void OnAfterPut(Unusualvariant unusualvariant);
        partial void OnBeforeDelete(Unusualvariant unusualvariant);
        partial void OnAfterDelete(Unusualvariant unusualvariant);
        

        public UnusualvariantsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Unusualvariant
        public IEnumerable<Unusualvariant> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllUnusualvariants<Unusualvariant>();
            Unusualvariant.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Unusualvariants/{unusualvariant-guid}
        public Unusualvariant Get(Guid unusualvariantId)
        {
            var UnusualvariantsWhere = String.Format("UnusualvariantId = '{0}'", unusualvariantId);
            var result = this.SDM.GetAllUnusualvariants<Unusualvariant>(UnusualvariantsWhere).FirstOrDefault();
            this.OnAfterGetById(result, unusualvariantId);
            return result;
        }

        // POST api/Unusualvariants/{unusualvariant-guid}
        public Unusualvariant Post([FromBody]Unusualvariant unusualvariant)
        {
            if (unusualvariant.UnusualvariantId == Guid.Empty) unusualvariant.UnusualvariantId = Guid.NewGuid();
            this.OnBeforePost(unusualvariant);
            this.SDM.Upsert(unusualvariant);
            this.OnAfterPost(unusualvariant);
            return unusualvariant;
        }

        // POST api/Unusualvariants/{unusualvariant-guid}
        public Unusualvariant Put([FromBody]Unusualvariant unusualvariant)
        {
            if (unusualvariant.UnusualvariantId == Guid.Empty) unusualvariant.UnusualvariantId = Guid.NewGuid();
            this.OnBeforePut(unusualvariant);
            this.SDM.Upsert(unusualvariant);
            this.OnAfterPut(unusualvariant);
            return unusualvariant;
        }

        // POST api/Unusualvariants/{unusualvariant-guid}
        public void Delete(Guid unusualvariantId)
        {
            var unusualvariantWhere = String.Format("UnusualvariantId = '{0}'", unusualvariantId);
            var unusualvariant = this.SDM.GetAllUnusualvariants<Unusualvariant>(unusualvariantWhere).FirstOrDefault();
            this.OnBeforeDelete(unusualvariant);
            this.SDM.Delete(unusualvariant);
            this.OnAfterDelete(unusualvariant);
        }
    }
}
