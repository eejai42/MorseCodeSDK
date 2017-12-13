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
    public partial class AviatorsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Aviator> Aviators);
        partial void OnAfterGetById(Aviator Aviators, Guid aviatorId);
        partial void OnBeforePost(Aviator aviator);
        partial void OnAfterPost(Aviator aviator);
        partial void OnBeforePut(Aviator aviator);
        partial void OnAfterPut(Aviator aviator);
        partial void OnBeforeDelete(Aviator aviator);
        partial void OnAfterDelete(Aviator aviator);
        

        public AviatorsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Aviator
        public IEnumerable<Aviator> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllAviators<Aviator>();
            Aviator.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Aviators/{aviator-guid}
        public Aviator Get(Guid aviatorId)
        {
            var AviatorsWhere = String.Format("AviatorId = '{0}'", aviatorId);
            var result = this.SDM.GetAllAviators<Aviator>(AviatorsWhere).FirstOrDefault();
            this.OnAfterGetById(result, aviatorId);
            return result;
        }

        // POST api/Aviators/{aviator-guid}
        public Aviator Post([FromBody]Aviator aviator)
        {
            if (aviator.AviatorId == Guid.Empty) aviator.AviatorId = Guid.NewGuid();
            this.OnBeforePost(aviator);
            this.SDM.Upsert(aviator);
            this.OnAfterPost(aviator);
            return aviator;
        }

        // POST api/Aviators/{aviator-guid}
        public Aviator Put([FromBody]Aviator aviator)
        {
            if (aviator.AviatorId == Guid.Empty) aviator.AviatorId = Guid.NewGuid();
            this.OnBeforePut(aviator);
            this.SDM.Upsert(aviator);
            this.OnAfterPut(aviator);
            return aviator;
        }

        // POST api/Aviators/{aviator-guid}
        public void Delete(Guid aviatorId)
        {
            var aviatorWhere = String.Format("AviatorId = '{0}'", aviatorId);
            var aviator = this.SDM.GetAllAviators<Aviator>(aviatorWhere).FirstOrDefault();
            this.OnBeforeDelete(aviator);
            this.SDM.Delete(aviator);
            this.OnAfterDelete(aviator);
        }
    }
}
