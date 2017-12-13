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
    public partial class NonsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Non> Nons);
        partial void OnAfterGetById(Non Nons, Guid nonId);
        partial void OnBeforePost(Non non);
        partial void OnAfterPost(Non non);
        partial void OnBeforePut(Non non);
        partial void OnAfterPut(Non non);
        partial void OnBeforeDelete(Non non);
        partial void OnAfterDelete(Non non);
        

        public NonsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Non
        public IEnumerable<Non> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllNons<Non>();
            Non.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Nons/{non-guid}
        public Non Get(Guid nonId)
        {
            var NonsWhere = String.Format("NonId = '{0}'", nonId);
            var result = this.SDM.GetAllNons<Non>(NonsWhere).FirstOrDefault();
            this.OnAfterGetById(result, nonId);
            return result;
        }

        // POST api/Nons/{non-guid}
        public Non Post([FromBody]Non non)
        {
            if (non.NonId == Guid.Empty) non.NonId = Guid.NewGuid();
            this.OnBeforePost(non);
            this.SDM.Upsert(non);
            this.OnAfterPost(non);
            return non;
        }

        // POST api/Nons/{non-guid}
        public Non Put([FromBody]Non non)
        {
            if (non.NonId == Guid.Empty) non.NonId = Guid.NewGuid();
            this.OnBeforePut(non);
            this.SDM.Upsert(non);
            this.OnAfterPut(non);
            return non;
        }

        // POST api/Nons/{non-guid}
        public void Delete(Guid nonId)
        {
            var nonWhere = String.Format("NonId = '{0}'", nonId);
            var non = this.SDM.GetAllNons<Non>(nonWhere).FirstOrDefault();
            this.OnBeforeDelete(non);
            this.SDM.Delete(non);
            this.OnAfterDelete(non);
        }
    }
}
