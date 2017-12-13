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
    public partial class VorsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Vor> Vors);
        partial void OnAfterGetById(Vor Vors, Guid vorId);
        partial void OnBeforePost(Vor vor);
        partial void OnAfterPost(Vor vor);
        partial void OnBeforePut(Vor vor);
        partial void OnAfterPut(Vor vor);
        partial void OnBeforeDelete(Vor vor);
        partial void OnAfterDelete(Vor vor);
        

        public VorsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Vor
        public IEnumerable<Vor> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllVors<Vor>();
            Vor.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Vors/{vor-guid}
        public Vor Get(Guid vorId)
        {
            var VorsWhere = String.Format("VorId = '{0}'", vorId);
            var result = this.SDM.GetAllVors<Vor>(VorsWhere).FirstOrDefault();
            this.OnAfterGetById(result, vorId);
            return result;
        }

        // POST api/Vors/{vor-guid}
        public Vor Post([FromBody]Vor vor)
        {
            if (vor.VorId == Guid.Empty) vor.VorId = Guid.NewGuid();
            this.OnBeforePost(vor);
            this.SDM.Upsert(vor);
            this.OnAfterPost(vor);
            return vor;
        }

        // POST api/Vors/{vor-guid}
        public Vor Put([FromBody]Vor vor)
        {
            if (vor.VorId == Guid.Empty) vor.VorId = Guid.NewGuid();
            this.OnBeforePut(vor);
            this.SDM.Upsert(vor);
            this.OnAfterPut(vor);
            return vor;
        }

        // POST api/Vors/{vor-guid}
        public void Delete(Guid vorId)
        {
            var vorWhere = String.Format("VorId = '{0}'", vorId);
            var vor = this.SDM.GetAllVors<Vor>(vorWhere).FirstOrDefault();
            this.OnBeforeDelete(vor);
            this.SDM.Delete(vor);
            this.OnAfterDelete(vor);
        }
    }
}
