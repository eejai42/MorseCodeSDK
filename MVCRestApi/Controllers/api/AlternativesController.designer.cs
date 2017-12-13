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
    public partial class AlternativesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Alternative> Alternatives);
        partial void OnAfterGetById(Alternative Alternatives, Guid alternativeId);
        partial void OnBeforePost(Alternative alternative);
        partial void OnAfterPost(Alternative alternative);
        partial void OnBeforePut(Alternative alternative);
        partial void OnAfterPut(Alternative alternative);
        partial void OnBeforeDelete(Alternative alternative);
        partial void OnAfterDelete(Alternative alternative);
        

        public AlternativesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Alternative
        public IEnumerable<Alternative> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllAlternatives<Alternative>();
            Alternative.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Alternatives/{alternative-guid}
        public Alternative Get(Guid alternativeId)
        {
            var AlternativesWhere = String.Format("AlternativeId = '{0}'", alternativeId);
            var result = this.SDM.GetAllAlternatives<Alternative>(AlternativesWhere).FirstOrDefault();
            this.OnAfterGetById(result, alternativeId);
            return result;
        }

        // POST api/Alternatives/{alternative-guid}
        public Alternative Post([FromBody]Alternative alternative)
        {
            if (alternative.AlternativeId == Guid.Empty) alternative.AlternativeId = Guid.NewGuid();
            this.OnBeforePost(alternative);
            this.SDM.Upsert(alternative);
            this.OnAfterPost(alternative);
            return alternative;
        }

        // POST api/Alternatives/{alternative-guid}
        public Alternative Put([FromBody]Alternative alternative)
        {
            if (alternative.AlternativeId == Guid.Empty) alternative.AlternativeId = Guid.NewGuid();
            this.OnBeforePut(alternative);
            this.SDM.Upsert(alternative);
            this.OnAfterPut(alternative);
            return alternative;
        }

        // POST api/Alternatives/{alternative-guid}
        public void Delete(Guid alternativeId)
        {
            var alternativeWhere = String.Format("AlternativeId = '{0}'", alternativeId);
            var alternative = this.SDM.GetAllAlternatives<Alternative>(alternativeWhere).FirstOrDefault();
            this.OnBeforeDelete(alternative);
            this.SDM.Delete(alternative);
            this.OnAfterDelete(alternative);
        }
    }
}
