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
    public partial class HttpsenwikipediaorgwindexphptitlemorsecodeoldidsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Httpsenwikipediaorgwindexphptitlemorsecodeoldid> Httpsenwikipediaorgwindexphptitlemorsecodeoldids);
        partial void OnAfterGetById(Httpsenwikipediaorgwindexphptitlemorsecodeoldid Httpsenwikipediaorgwindexphptitlemorsecodeoldids, Guid httpsenwikipediaorgwindexphptitlemorsecodeoldidId);
        partial void OnBeforePost(Httpsenwikipediaorgwindexphptitlemorsecodeoldid httpsenwikipediaorgwindexphptitlemorsecodeoldid);
        partial void OnAfterPost(Httpsenwikipediaorgwindexphptitlemorsecodeoldid httpsenwikipediaorgwindexphptitlemorsecodeoldid);
        partial void OnBeforePut(Httpsenwikipediaorgwindexphptitlemorsecodeoldid httpsenwikipediaorgwindexphptitlemorsecodeoldid);
        partial void OnAfterPut(Httpsenwikipediaorgwindexphptitlemorsecodeoldid httpsenwikipediaorgwindexphptitlemorsecodeoldid);
        partial void OnBeforeDelete(Httpsenwikipediaorgwindexphptitlemorsecodeoldid httpsenwikipediaorgwindexphptitlemorsecodeoldid);
        partial void OnAfterDelete(Httpsenwikipediaorgwindexphptitlemorsecodeoldid httpsenwikipediaorgwindexphptitlemorsecodeoldid);
        

        public HttpsenwikipediaorgwindexphptitlemorsecodeoldidsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Httpsenwikipediaorgwindexphptitlemorsecodeoldid
        public IEnumerable<Httpsenwikipediaorgwindexphptitlemorsecodeoldid> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllHttpsenwikipediaorgwindexphptitlemorsecodeoldids<Httpsenwikipediaorgwindexphptitlemorsecodeoldid>();
            Httpsenwikipediaorgwindexphptitlemorsecodeoldid.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Httpsenwikipediaorgwindexphptitlemorsecodeoldids/{httpsenwikipediaorgwindexphptitlemorsecodeoldid-guid}
        public Httpsenwikipediaorgwindexphptitlemorsecodeoldid Get(Guid httpsenwikipediaorgwindexphptitlemorsecodeoldidId)
        {
            var HttpsenwikipediaorgwindexphptitlemorsecodeoldidsWhere = String.Format("HttpsenwikipediaorgwindexphptitlemorsecodeoldidId = '{0}'", httpsenwikipediaorgwindexphptitlemorsecodeoldidId);
            var result = this.SDM.GetAllHttpsenwikipediaorgwindexphptitlemorsecodeoldids<Httpsenwikipediaorgwindexphptitlemorsecodeoldid>(HttpsenwikipediaorgwindexphptitlemorsecodeoldidsWhere).FirstOrDefault();
            this.OnAfterGetById(result, httpsenwikipediaorgwindexphptitlemorsecodeoldidId);
            return result;
        }

        // POST api/Httpsenwikipediaorgwindexphptitlemorsecodeoldids/{httpsenwikipediaorgwindexphptitlemorsecodeoldid-guid}
        public Httpsenwikipediaorgwindexphptitlemorsecodeoldid Post([FromBody]Httpsenwikipediaorgwindexphptitlemorsecodeoldid httpsenwikipediaorgwindexphptitlemorsecodeoldid)
        {
            if (httpsenwikipediaorgwindexphptitlemorsecodeoldid.HttpsenwikipediaorgwindexphptitlemorsecodeoldidId == Guid.Empty) httpsenwikipediaorgwindexphptitlemorsecodeoldid.HttpsenwikipediaorgwindexphptitlemorsecodeoldidId = Guid.NewGuid();
            this.OnBeforePost(httpsenwikipediaorgwindexphptitlemorsecodeoldid);
            this.SDM.Upsert(httpsenwikipediaorgwindexphptitlemorsecodeoldid);
            this.OnAfterPost(httpsenwikipediaorgwindexphptitlemorsecodeoldid);
            return httpsenwikipediaorgwindexphptitlemorsecodeoldid;
        }

        // POST api/Httpsenwikipediaorgwindexphptitlemorsecodeoldids/{httpsenwikipediaorgwindexphptitlemorsecodeoldid-guid}
        public Httpsenwikipediaorgwindexphptitlemorsecodeoldid Put([FromBody]Httpsenwikipediaorgwindexphptitlemorsecodeoldid httpsenwikipediaorgwindexphptitlemorsecodeoldid)
        {
            if (httpsenwikipediaorgwindexphptitlemorsecodeoldid.HttpsenwikipediaorgwindexphptitlemorsecodeoldidId == Guid.Empty) httpsenwikipediaorgwindexphptitlemorsecodeoldid.HttpsenwikipediaorgwindexphptitlemorsecodeoldidId = Guid.NewGuid();
            this.OnBeforePut(httpsenwikipediaorgwindexphptitlemorsecodeoldid);
            this.SDM.Upsert(httpsenwikipediaorgwindexphptitlemorsecodeoldid);
            this.OnAfterPut(httpsenwikipediaorgwindexphptitlemorsecodeoldid);
            return httpsenwikipediaorgwindexphptitlemorsecodeoldid;
        }

        // POST api/Httpsenwikipediaorgwindexphptitlemorsecodeoldids/{httpsenwikipediaorgwindexphptitlemorsecodeoldid-guid}
        public void Delete(Guid httpsenwikipediaorgwindexphptitlemorsecodeoldidId)
        {
            var httpsenwikipediaorgwindexphptitlemorsecodeoldidWhere = String.Format("HttpsenwikipediaorgwindexphptitlemorsecodeoldidId = '{0}'", httpsenwikipediaorgwindexphptitlemorsecodeoldidId);
            var httpsenwikipediaorgwindexphptitlemorsecodeoldid = this.SDM.GetAllHttpsenwikipediaorgwindexphptitlemorsecodeoldids<Httpsenwikipediaorgwindexphptitlemorsecodeoldid>(httpsenwikipediaorgwindexphptitlemorsecodeoldidWhere).FirstOrDefault();
            this.OnBeforeDelete(httpsenwikipediaorgwindexphptitlemorsecodeoldid);
            this.SDM.Delete(httpsenwikipediaorgwindexphptitlemorsecodeoldid);
            this.OnAfterDelete(httpsenwikipediaorgwindexphptitlemorsecodeoldid);
        }
    }
}
