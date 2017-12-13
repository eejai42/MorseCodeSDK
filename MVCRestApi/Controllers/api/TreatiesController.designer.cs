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
    public partial class TreatiesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Treaty> Treaties);
        partial void OnAfterGetById(Treaty Treaties, Guid treatyId);
        partial void OnBeforePost(Treaty treaty);
        partial void OnAfterPost(Treaty treaty);
        partial void OnBeforePut(Treaty treaty);
        partial void OnAfterPut(Treaty treaty);
        partial void OnBeforeDelete(Treaty treaty);
        partial void OnAfterDelete(Treaty treaty);
        

        public TreatiesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Treaty
        public IEnumerable<Treaty> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllTreaties<Treaty>();
            Treaty.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Treaties/{treaty-guid}
        public Treaty Get(Guid treatyId)
        {
            var TreatiesWhere = String.Format("TreatyId = '{0}'", treatyId);
            var result = this.SDM.GetAllTreaties<Treaty>(TreatiesWhere).FirstOrDefault();
            this.OnAfterGetById(result, treatyId);
            return result;
        }

        // POST api/Treaties/{treaty-guid}
        public Treaty Post([FromBody]Treaty treaty)
        {
            if (treaty.TreatyId == Guid.Empty) treaty.TreatyId = Guid.NewGuid();
            this.OnBeforePost(treaty);
            this.SDM.Upsert(treaty);
            this.OnAfterPost(treaty);
            return treaty;
        }

        // POST api/Treaties/{treaty-guid}
        public Treaty Put([FromBody]Treaty treaty)
        {
            if (treaty.TreatyId == Guid.Empty) treaty.TreatyId = Guid.NewGuid();
            this.OnBeforePut(treaty);
            this.SDM.Upsert(treaty);
            this.OnAfterPut(treaty);
            return treaty;
        }

        // POST api/Treaties/{treaty-guid}
        public void Delete(Guid treatyId)
        {
            var treatyWhere = String.Format("TreatyId = '{0}'", treatyId);
            var treaty = this.SDM.GetAllTreaties<Treaty>(treatyWhere).FirstOrDefault();
            this.OnBeforeDelete(treaty);
            this.SDM.Delete(treaty);
            this.OnAfterDelete(treaty);
        }
    }
}
