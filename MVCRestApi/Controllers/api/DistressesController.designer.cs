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
    public partial class DistressesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Distress> Distresses);
        partial void OnAfterGetById(Distress Distresses, Guid distressId);
        partial void OnBeforePost(Distress distress);
        partial void OnAfterPost(Distress distress);
        partial void OnBeforePut(Distress distress);
        partial void OnAfterPut(Distress distress);
        partial void OnBeforeDelete(Distress distress);
        partial void OnAfterDelete(Distress distress);
        

        public DistressesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Distress
        public IEnumerable<Distress> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllDistresses<Distress>();
            Distress.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Distresses/{distress-guid}
        public Distress Get(Guid distressId)
        {
            var DistressesWhere = String.Format("DistressId = '{0}'", distressId);
            var result = this.SDM.GetAllDistresses<Distress>(DistressesWhere).FirstOrDefault();
            this.OnAfterGetById(result, distressId);
            return result;
        }

        // POST api/Distresses/{distress-guid}
        public Distress Post([FromBody]Distress distress)
        {
            if (distress.DistressId == Guid.Empty) distress.DistressId = Guid.NewGuid();
            this.OnBeforePost(distress);
            this.SDM.Upsert(distress);
            this.OnAfterPost(distress);
            return distress;
        }

        // POST api/Distresses/{distress-guid}
        public Distress Put([FromBody]Distress distress)
        {
            if (distress.DistressId == Guid.Empty) distress.DistressId = Guid.NewGuid();
            this.OnBeforePut(distress);
            this.SDM.Upsert(distress);
            this.OnAfterPut(distress);
            return distress;
        }

        // POST api/Distresses/{distress-guid}
        public void Delete(Guid distressId)
        {
            var distressWhere = String.Format("DistressId = '{0}'", distressId);
            var distress = this.SDM.GetAllDistresses<Distress>(distressWhere).FirstOrDefault();
            this.OnBeforeDelete(distress);
            this.SDM.Delete(distress);
            this.OnAfterDelete(distress);
        }
    }
}
