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
    public partial class NdbsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Ndb> Ndbs);
        partial void OnAfterGetById(Ndb Ndbs, Guid ndbId);
        partial void OnBeforePost(Ndb ndb);
        partial void OnAfterPost(Ndb ndb);
        partial void OnBeforePut(Ndb ndb);
        partial void OnAfterPut(Ndb ndb);
        partial void OnBeforeDelete(Ndb ndb);
        partial void OnAfterDelete(Ndb ndb);
        

        public NdbsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Ndb
        public IEnumerable<Ndb> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllNdbs<Ndb>();
            Ndb.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Ndbs/{ndb-guid}
        public Ndb Get(Guid ndbId)
        {
            var NdbsWhere = String.Format("NdbId = '{0}'", ndbId);
            var result = this.SDM.GetAllNdbs<Ndb>(NdbsWhere).FirstOrDefault();
            this.OnAfterGetById(result, ndbId);
            return result;
        }

        // POST api/Ndbs/{ndb-guid}
        public Ndb Post([FromBody]Ndb ndb)
        {
            if (ndb.NdbId == Guid.Empty) ndb.NdbId = Guid.NewGuid();
            this.OnBeforePost(ndb);
            this.SDM.Upsert(ndb);
            this.OnAfterPost(ndb);
            return ndb;
        }

        // POST api/Ndbs/{ndb-guid}
        public Ndb Put([FromBody]Ndb ndb)
        {
            if (ndb.NdbId == Guid.Empty) ndb.NdbId = Guid.NewGuid();
            this.OnBeforePut(ndb);
            this.SDM.Upsert(ndb);
            this.OnAfterPut(ndb);
            return ndb;
        }

        // POST api/Ndbs/{ndb-guid}
        public void Delete(Guid ndbId)
        {
            var ndbWhere = String.Format("NdbId = '{0}'", ndbId);
            var ndb = this.SDM.GetAllNdbs<Ndb>(ndbWhere).FirstOrDefault();
            this.OnBeforeDelete(ndb);
            this.SDM.Delete(ndb);
            this.OnAfterDelete(ndb);
        }
    }
}
