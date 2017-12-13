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
    public partial class AidsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Aid> Aids);
        partial void OnAfterGetById(Aid Aids, Guid aidId);
        partial void OnBeforePost(Aid aid);
        partial void OnAfterPost(Aid aid);
        partial void OnBeforePut(Aid aid);
        partial void OnAfterPut(Aid aid);
        partial void OnBeforeDelete(Aid aid);
        partial void OnAfterDelete(Aid aid);
        

        public AidsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Aid
        public IEnumerable<Aid> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllAids<Aid>();
            Aid.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Aids/{aid-guid}
        public Aid Get(Guid aidId)
        {
            var AidsWhere = String.Format("AidId = '{0}'", aidId);
            var result = this.SDM.GetAllAids<Aid>(AidsWhere).FirstOrDefault();
            this.OnAfterGetById(result, aidId);
            return result;
        }

        // POST api/Aids/{aid-guid}
        public Aid Post([FromBody]Aid aid)
        {
            if (aid.AidId == Guid.Empty) aid.AidId = Guid.NewGuid();
            this.OnBeforePost(aid);
            this.SDM.Upsert(aid);
            this.OnAfterPost(aid);
            return aid;
        }

        // POST api/Aids/{aid-guid}
        public Aid Put([FromBody]Aid aid)
        {
            if (aid.AidId == Guid.Empty) aid.AidId = Guid.NewGuid();
            this.OnBeforePut(aid);
            this.SDM.Upsert(aid);
            this.OnAfterPut(aid);
            return aid;
        }

        // POST api/Aids/{aid-guid}
        public void Delete(Guid aidId)
        {
            var aidWhere = String.Format("AidId = '{0}'", aidId);
            var aid = this.SDM.GetAllAids<Aid>(aidWhere).FirstOrDefault();
            this.OnBeforeDelete(aid);
            this.SDM.Delete(aid);
            this.OnAfterDelete(aid);
        }
    }
}
