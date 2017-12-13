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
    public partial class AviationsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Aviation> Aviations);
        partial void OnAfterGetById(Aviation Aviations, Guid aviationId);
        partial void OnBeforePost(Aviation aviation);
        partial void OnAfterPost(Aviation aviation);
        partial void OnBeforePut(Aviation aviation);
        partial void OnAfterPut(Aviation aviation);
        partial void OnBeforeDelete(Aviation aviation);
        partial void OnAfterDelete(Aviation aviation);
        

        public AviationsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Aviation
        public IEnumerable<Aviation> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllAviations<Aviation>();
            Aviation.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Aviations/{aviation-guid}
        public Aviation Get(Guid aviationId)
        {
            var AviationsWhere = String.Format("AviationId = '{0}'", aviationId);
            var result = this.SDM.GetAllAviations<Aviation>(AviationsWhere).FirstOrDefault();
            this.OnAfterGetById(result, aviationId);
            return result;
        }

        // POST api/Aviations/{aviation-guid}
        public Aviation Post([FromBody]Aviation aviation)
        {
            if (aviation.AviationId == Guid.Empty) aviation.AviationId = Guid.NewGuid();
            this.OnBeforePost(aviation);
            this.SDM.Upsert(aviation);
            this.OnAfterPost(aviation);
            return aviation;
        }

        // POST api/Aviations/{aviation-guid}
        public Aviation Put([FromBody]Aviation aviation)
        {
            if (aviation.AviationId == Guid.Empty) aviation.AviationId = Guid.NewGuid();
            this.OnBeforePut(aviation);
            this.SDM.Upsert(aviation);
            this.OnAfterPut(aviation);
            return aviation;
        }

        // POST api/Aviations/{aviation-guid}
        public void Delete(Guid aviationId)
        {
            var aviationWhere = String.Format("AviationId = '{0}'", aviationId);
            var aviation = this.SDM.GetAllAviations<Aviation>(aviationWhere).FirstOrDefault();
            this.OnBeforeDelete(aviation);
            this.SDM.Delete(aviation);
            this.OnAfterDelete(aviation);
        }
    }
}
