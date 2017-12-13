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
    public partial class SpokenrepresentationsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Spokenrepresentation> Spokenrepresentations);
        partial void OnAfterGetById(Spokenrepresentation Spokenrepresentations, Guid spokenrepresentationId);
        partial void OnBeforePost(Spokenrepresentation spokenrepresentation);
        partial void OnAfterPost(Spokenrepresentation spokenrepresentation);
        partial void OnBeforePut(Spokenrepresentation spokenrepresentation);
        partial void OnAfterPut(Spokenrepresentation spokenrepresentation);
        partial void OnBeforeDelete(Spokenrepresentation spokenrepresentation);
        partial void OnAfterDelete(Spokenrepresentation spokenrepresentation);
        

        public SpokenrepresentationsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Spokenrepresentation
        public IEnumerable<Spokenrepresentation> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSpokenrepresentations<Spokenrepresentation>();
            Spokenrepresentation.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Spokenrepresentations/{spokenrepresentation-guid}
        public Spokenrepresentation Get(Guid spokenrepresentationId)
        {
            var SpokenrepresentationsWhere = String.Format("SpokenrepresentationId = '{0}'", spokenrepresentationId);
            var result = this.SDM.GetAllSpokenrepresentations<Spokenrepresentation>(SpokenrepresentationsWhere).FirstOrDefault();
            this.OnAfterGetById(result, spokenrepresentationId);
            return result;
        }

        // POST api/Spokenrepresentations/{spokenrepresentation-guid}
        public Spokenrepresentation Post([FromBody]Spokenrepresentation spokenrepresentation)
        {
            if (spokenrepresentation.SpokenrepresentationId == Guid.Empty) spokenrepresentation.SpokenrepresentationId = Guid.NewGuid();
            this.OnBeforePost(spokenrepresentation);
            this.SDM.Upsert(spokenrepresentation);
            this.OnAfterPost(spokenrepresentation);
            return spokenrepresentation;
        }

        // POST api/Spokenrepresentations/{spokenrepresentation-guid}
        public Spokenrepresentation Put([FromBody]Spokenrepresentation spokenrepresentation)
        {
            if (spokenrepresentation.SpokenrepresentationId == Guid.Empty) spokenrepresentation.SpokenrepresentationId = Guid.NewGuid();
            this.OnBeforePut(spokenrepresentation);
            this.SDM.Upsert(spokenrepresentation);
            this.OnAfterPut(spokenrepresentation);
            return spokenrepresentation;
        }

        // POST api/Spokenrepresentations/{spokenrepresentation-guid}
        public void Delete(Guid spokenrepresentationId)
        {
            var spokenrepresentationWhere = String.Format("SpokenrepresentationId = '{0}'", spokenrepresentationId);
            var spokenrepresentation = this.SDM.GetAllSpokenrepresentations<Spokenrepresentation>(spokenrepresentationWhere).FirstOrDefault();
            this.OnBeforeDelete(spokenrepresentation);
            this.SDM.Delete(spokenrepresentation);
            this.OnAfterDelete(spokenrepresentation);
        }
    }
}
