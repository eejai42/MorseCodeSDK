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
    public partial class SamuelsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Samuel> Samuels);
        partial void OnAfterGetById(Samuel Samuels, Guid samuelId);
        partial void OnBeforePost(Samuel samuel);
        partial void OnAfterPost(Samuel samuel);
        partial void OnBeforePut(Samuel samuel);
        partial void OnAfterPut(Samuel samuel);
        partial void OnBeforeDelete(Samuel samuel);
        partial void OnAfterDelete(Samuel samuel);
        

        public SamuelsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Samuel
        public IEnumerable<Samuel> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSamuels<Samuel>();
            Samuel.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Samuels/{samuel-guid}
        public Samuel Get(Guid samuelId)
        {
            var SamuelsWhere = String.Format("SamuelId = '{0}'", samuelId);
            var result = this.SDM.GetAllSamuels<Samuel>(SamuelsWhere).FirstOrDefault();
            this.OnAfterGetById(result, samuelId);
            return result;
        }

        // POST api/Samuels/{samuel-guid}
        public Samuel Post([FromBody]Samuel samuel)
        {
            if (samuel.SamuelId == Guid.Empty) samuel.SamuelId = Guid.NewGuid();
            this.OnBeforePost(samuel);
            this.SDM.Upsert(samuel);
            this.OnAfterPost(samuel);
            return samuel;
        }

        // POST api/Samuels/{samuel-guid}
        public Samuel Put([FromBody]Samuel samuel)
        {
            if (samuel.SamuelId == Guid.Empty) samuel.SamuelId = Guid.NewGuid();
            this.OnBeforePut(samuel);
            this.SDM.Upsert(samuel);
            this.OnAfterPut(samuel);
            return samuel;
        }

        // POST api/Samuels/{samuel-guid}
        public void Delete(Guid samuelId)
        {
            var samuelWhere = String.Format("SamuelId = '{0}'", samuelId);
            var samuel = this.SDM.GetAllSamuels<Samuel>(samuelWhere).FirstOrDefault();
            this.OnBeforeDelete(samuel);
            this.SDM.Delete(samuel);
            this.OnAfterDelete(samuel);
        }
    }
}
