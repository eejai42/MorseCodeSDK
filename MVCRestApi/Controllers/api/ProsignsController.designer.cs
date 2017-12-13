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
    public partial class ProsignsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Prosign> Prosigns);
        partial void OnAfterGetById(Prosign Prosigns, Guid prosignId);
        partial void OnBeforePost(Prosign prosign);
        partial void OnAfterPost(Prosign prosign);
        partial void OnBeforePut(Prosign prosign);
        partial void OnAfterPut(Prosign prosign);
        partial void OnBeforeDelete(Prosign prosign);
        partial void OnAfterDelete(Prosign prosign);
        

        public ProsignsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Prosign
        public IEnumerable<Prosign> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllProsigns<Prosign>();
            Prosign.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Prosigns/{prosign-guid}
        public Prosign Get(Guid prosignId)
        {
            var ProsignsWhere = String.Format("ProsignId = '{0}'", prosignId);
            var result = this.SDM.GetAllProsigns<Prosign>(ProsignsWhere).FirstOrDefault();
            this.OnAfterGetById(result, prosignId);
            return result;
        }

        // POST api/Prosigns/{prosign-guid}
        public Prosign Post([FromBody]Prosign prosign)
        {
            if (prosign.ProsignId == Guid.Empty) prosign.ProsignId = Guid.NewGuid();
            this.OnBeforePost(prosign);
            this.SDM.Upsert(prosign);
            this.OnAfterPost(prosign);
            return prosign;
        }

        // POST api/Prosigns/{prosign-guid}
        public Prosign Put([FromBody]Prosign prosign)
        {
            if (prosign.ProsignId == Guid.Empty) prosign.ProsignId = Guid.NewGuid();
            this.OnBeforePut(prosign);
            this.SDM.Upsert(prosign);
            this.OnAfterPut(prosign);
            return prosign;
        }

        // POST api/Prosigns/{prosign-guid}
        public void Delete(Guid prosignId)
        {
            var prosignWhere = String.Format("ProsignId = '{0}'", prosignId);
            var prosign = this.SDM.GetAllProsigns<Prosign>(prosignWhere).FirstOrDefault();
            this.OnBeforeDelete(prosign);
            this.SDM.Delete(prosign);
            this.OnAfterDelete(prosign);
        }
    }
}
