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
    public partial class AndspeedsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Andspeed> Andspeeds);
        partial void OnAfterGetById(Andspeed Andspeeds, Guid andspeedId);
        partial void OnBeforePost(Andspeed andspeed);
        partial void OnAfterPost(Andspeed andspeed);
        partial void OnBeforePut(Andspeed andspeed);
        partial void OnAfterPut(Andspeed andspeed);
        partial void OnBeforeDelete(Andspeed andspeed);
        partial void OnAfterDelete(Andspeed andspeed);
        

        public AndspeedsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Andspeed
        public IEnumerable<Andspeed> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllAndspeeds<Andspeed>();
            Andspeed.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Andspeeds/{andspeed-guid}
        public Andspeed Get(Guid andspeedId)
        {
            var AndspeedsWhere = String.Format("AndspeedId = '{0}'", andspeedId);
            var result = this.SDM.GetAllAndspeeds<Andspeed>(AndspeedsWhere).FirstOrDefault();
            this.OnAfterGetById(result, andspeedId);
            return result;
        }

        // POST api/Andspeeds/{andspeed-guid}
        public Andspeed Post([FromBody]Andspeed andspeed)
        {
            if (andspeed.AndspeedId == Guid.Empty) andspeed.AndspeedId = Guid.NewGuid();
            this.OnBeforePost(andspeed);
            this.SDM.Upsert(andspeed);
            this.OnAfterPost(andspeed);
            return andspeed;
        }

        // POST api/Andspeeds/{andspeed-guid}
        public Andspeed Put([FromBody]Andspeed andspeed)
        {
            if (andspeed.AndspeedId == Guid.Empty) andspeed.AndspeedId = Guid.NewGuid();
            this.OnBeforePut(andspeed);
            this.SDM.Upsert(andspeed);
            this.OnAfterPut(andspeed);
            return andspeed;
        }

        // POST api/Andspeeds/{andspeed-guid}
        public void Delete(Guid andspeedId)
        {
            var andspeedWhere = String.Format("AndspeedId = '{0}'", andspeedId);
            var andspeed = this.SDM.GetAllAndspeeds<Andspeed>(andspeedWhere).FirstOrDefault();
            this.OnBeforeDelete(andspeed);
            this.SDM.Delete(andspeed);
            this.OnAfterDelete(andspeed);
        }
    }
}
