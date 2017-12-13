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
    public partial class FarnsworthsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Farnsworth> Farnsworths);
        partial void OnAfterGetById(Farnsworth Farnsworths, Guid farnsworthId);
        partial void OnBeforePost(Farnsworth farnsworth);
        partial void OnAfterPost(Farnsworth farnsworth);
        partial void OnBeforePut(Farnsworth farnsworth);
        partial void OnAfterPut(Farnsworth farnsworth);
        partial void OnBeforeDelete(Farnsworth farnsworth);
        partial void OnAfterDelete(Farnsworth farnsworth);
        

        public FarnsworthsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Farnsworth
        public IEnumerable<Farnsworth> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllFarnsworths<Farnsworth>();
            Farnsworth.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Farnsworths/{farnsworth-guid}
        public Farnsworth Get(Guid farnsworthId)
        {
            var FarnsworthsWhere = String.Format("FarnsworthId = '{0}'", farnsworthId);
            var result = this.SDM.GetAllFarnsworths<Farnsworth>(FarnsworthsWhere).FirstOrDefault();
            this.OnAfterGetById(result, farnsworthId);
            return result;
        }

        // POST api/Farnsworths/{farnsworth-guid}
        public Farnsworth Post([FromBody]Farnsworth farnsworth)
        {
            if (farnsworth.FarnsworthId == Guid.Empty) farnsworth.FarnsworthId = Guid.NewGuid();
            this.OnBeforePost(farnsworth);
            this.SDM.Upsert(farnsworth);
            this.OnAfterPost(farnsworth);
            return farnsworth;
        }

        // POST api/Farnsworths/{farnsworth-guid}
        public Farnsworth Put([FromBody]Farnsworth farnsworth)
        {
            if (farnsworth.FarnsworthId == Guid.Empty) farnsworth.FarnsworthId = Guid.NewGuid();
            this.OnBeforePut(farnsworth);
            this.SDM.Upsert(farnsworth);
            this.OnAfterPut(farnsworth);
            return farnsworth;
        }

        // POST api/Farnsworths/{farnsworth-guid}
        public void Delete(Guid farnsworthId)
        {
            var farnsworthWhere = String.Format("FarnsworthId = '{0}'", farnsworthId);
            var farnsworth = this.SDM.GetAllFarnsworths<Farnsworth>(farnsworthWhere).FirstOrDefault();
            this.OnBeforeDelete(farnsworth);
            this.SDM.Delete(farnsworth);
            this.OnAfterDelete(farnsworth);
        }
    }
}
