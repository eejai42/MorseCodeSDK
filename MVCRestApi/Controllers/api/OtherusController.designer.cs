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
    public partial class OtherusController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Otheru> Otherus);
        partial void OnAfterGetById(Otheru Otherus, Guid otheruId);
        partial void OnBeforePost(Otheru otheru);
        partial void OnAfterPost(Otheru otheru);
        partial void OnBeforePut(Otheru otheru);
        partial void OnAfterPut(Otheru otheru);
        partial void OnBeforeDelete(Otheru otheru);
        partial void OnAfterDelete(Otheru otheru);
        

        public OtherusController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Otheru
        public IEnumerable<Otheru> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllOtherus<Otheru>();
            Otheru.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Otherus/{otheru-guid}
        public Otheru Get(Guid otheruId)
        {
            var OtherusWhere = String.Format("OtheruId = '{0}'", otheruId);
            var result = this.SDM.GetAllOtherus<Otheru>(OtherusWhere).FirstOrDefault();
            this.OnAfterGetById(result, otheruId);
            return result;
        }

        // POST api/Otherus/{otheru-guid}
        public Otheru Post([FromBody]Otheru otheru)
        {
            if (otheru.OtheruId == Guid.Empty) otheru.OtheruId = Guid.NewGuid();
            this.OnBeforePost(otheru);
            this.SDM.Upsert(otheru);
            this.OnAfterPost(otheru);
            return otheru;
        }

        // POST api/Otherus/{otheru-guid}
        public Otheru Put([FromBody]Otheru otheru)
        {
            if (otheru.OtheruId == Guid.Empty) otheru.OtheruId = Guid.NewGuid();
            this.OnBeforePut(otheru);
            this.SDM.Upsert(otheru);
            this.OnAfterPut(otheru);
            return otheru;
        }

        // POST api/Otherus/{otheru-guid}
        public void Delete(Guid otheruId)
        {
            var otheruWhere = String.Format("OtheruId = '{0}'", otheruId);
            var otheru = this.SDM.GetAllOtherus<Otheru>(otheruWhere).FirstOrDefault();
            this.OnBeforeDelete(otheru);
            this.SDM.Delete(otheru);
            this.OnAfterDelete(otheru);
        }
    }
}
