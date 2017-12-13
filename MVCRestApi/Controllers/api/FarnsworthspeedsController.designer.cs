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
    public partial class FarnsworthspeedsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Farnsworthspeed> Farnsworthspeeds);
        partial void OnAfterGetById(Farnsworthspeed Farnsworthspeeds, Guid farnsworthspeedId);
        partial void OnBeforePost(Farnsworthspeed farnsworthspeed);
        partial void OnAfterPost(Farnsworthspeed farnsworthspeed);
        partial void OnBeforePut(Farnsworthspeed farnsworthspeed);
        partial void OnAfterPut(Farnsworthspeed farnsworthspeed);
        partial void OnBeforeDelete(Farnsworthspeed farnsworthspeed);
        partial void OnAfterDelete(Farnsworthspeed farnsworthspeed);
        

        public FarnsworthspeedsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Farnsworthspeed
        public IEnumerable<Farnsworthspeed> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllFarnsworthspeeds<Farnsworthspeed>();
            Farnsworthspeed.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Farnsworthspeeds/{farnsworthspeed-guid}
        public Farnsworthspeed Get(Guid farnsworthspeedId)
        {
            var FarnsworthspeedsWhere = String.Format("FarnsworthspeedId = '{0}'", farnsworthspeedId);
            var result = this.SDM.GetAllFarnsworthspeeds<Farnsworthspeed>(FarnsworthspeedsWhere).FirstOrDefault();
            this.OnAfterGetById(result, farnsworthspeedId);
            return result;
        }

        // POST api/Farnsworthspeeds/{farnsworthspeed-guid}
        public Farnsworthspeed Post([FromBody]Farnsworthspeed farnsworthspeed)
        {
            if (farnsworthspeed.FarnsworthspeedId == Guid.Empty) farnsworthspeed.FarnsworthspeedId = Guid.NewGuid();
            this.OnBeforePost(farnsworthspeed);
            this.SDM.Upsert(farnsworthspeed);
            this.OnAfterPost(farnsworthspeed);
            return farnsworthspeed;
        }

        // POST api/Farnsworthspeeds/{farnsworthspeed-guid}
        public Farnsworthspeed Put([FromBody]Farnsworthspeed farnsworthspeed)
        {
            if (farnsworthspeed.FarnsworthspeedId == Guid.Empty) farnsworthspeed.FarnsworthspeedId = Guid.NewGuid();
            this.OnBeforePut(farnsworthspeed);
            this.SDM.Upsert(farnsworthspeed);
            this.OnAfterPut(farnsworthspeed);
            return farnsworthspeed;
        }

        // POST api/Farnsworthspeeds/{farnsworthspeed-guid}
        public void Delete(Guid farnsworthspeedId)
        {
            var farnsworthspeedWhere = String.Format("FarnsworthspeedId = '{0}'", farnsworthspeedId);
            var farnsworthspeed = this.SDM.GetAllFarnsworthspeeds<Farnsworthspeed>(farnsworthspeedWhere).FirstOrDefault();
            this.OnBeforeDelete(farnsworthspeed);
            this.SDM.Delete(farnsworthspeed);
            this.OnAfterDelete(farnsworthspeed);
        }
    }
}
