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
    public partial class AmateurradiooperatorsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Amateurradiooperator> Amateurradiooperators);
        partial void OnAfterGetById(Amateurradiooperator Amateurradiooperators, Guid amateurradiooperatorId);
        partial void OnBeforePost(Amateurradiooperator amateurradiooperator);
        partial void OnAfterPost(Amateurradiooperator amateurradiooperator);
        partial void OnBeforePut(Amateurradiooperator amateurradiooperator);
        partial void OnAfterPut(Amateurradiooperator amateurradiooperator);
        partial void OnBeforeDelete(Amateurradiooperator amateurradiooperator);
        partial void OnAfterDelete(Amateurradiooperator amateurradiooperator);
        

        public AmateurradiooperatorsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Amateurradiooperator
        public IEnumerable<Amateurradiooperator> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllAmateurradiooperators<Amateurradiooperator>();
            Amateurradiooperator.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Amateurradiooperators/{amateurradiooperator-guid}
        public Amateurradiooperator Get(Guid amateurradiooperatorId)
        {
            var AmateurradiooperatorsWhere = String.Format("AmateurradiooperatorId = '{0}'", amateurradiooperatorId);
            var result = this.SDM.GetAllAmateurradiooperators<Amateurradiooperator>(AmateurradiooperatorsWhere).FirstOrDefault();
            this.OnAfterGetById(result, amateurradiooperatorId);
            return result;
        }

        // POST api/Amateurradiooperators/{amateurradiooperator-guid}
        public Amateurradiooperator Post([FromBody]Amateurradiooperator amateurradiooperator)
        {
            if (amateurradiooperator.AmateurradiooperatorId == Guid.Empty) amateurradiooperator.AmateurradiooperatorId = Guid.NewGuid();
            this.OnBeforePost(amateurradiooperator);
            this.SDM.Upsert(amateurradiooperator);
            this.OnAfterPost(amateurradiooperator);
            return amateurradiooperator;
        }

        // POST api/Amateurradiooperators/{amateurradiooperator-guid}
        public Amateurradiooperator Put([FromBody]Amateurradiooperator amateurradiooperator)
        {
            if (amateurradiooperator.AmateurradiooperatorId == Guid.Empty) amateurradiooperator.AmateurradiooperatorId = Guid.NewGuid();
            this.OnBeforePut(amateurradiooperator);
            this.SDM.Upsert(amateurradiooperator);
            this.OnAfterPut(amateurradiooperator);
            return amateurradiooperator;
        }

        // POST api/Amateurradiooperators/{amateurradiooperator-guid}
        public void Delete(Guid amateurradiooperatorId)
        {
            var amateurradiooperatorWhere = String.Format("AmateurradiooperatorId = '{0}'", amateurradiooperatorId);
            var amateurradiooperator = this.SDM.GetAllAmateurradiooperators<Amateurradiooperator>(amateurradiooperatorWhere).FirstOrDefault();
            this.OnBeforeDelete(amateurradiooperator);
            this.SDM.Delete(amateurradiooperator);
            this.OnAfterDelete(amateurradiooperator);
        }
    }
}
