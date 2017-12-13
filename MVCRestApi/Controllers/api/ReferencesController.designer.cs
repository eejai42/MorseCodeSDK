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
    public partial class ReferencesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Reference> References);
        partial void OnAfterGetById(Reference References, Guid referenceId);
        partial void OnBeforePost(Reference reference);
        partial void OnAfterPost(Reference reference);
        partial void OnBeforePut(Reference reference);
        partial void OnAfterPut(Reference reference);
        partial void OnBeforeDelete(Reference reference);
        partial void OnAfterDelete(Reference reference);
        

        public ReferencesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Reference
        public IEnumerable<Reference> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllReferences<Reference>();
            Reference.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/References/{reference-guid}
        public Reference Get(Guid referenceId)
        {
            var ReferencesWhere = String.Format("ReferenceId = '{0}'", referenceId);
            var result = this.SDM.GetAllReferences<Reference>(ReferencesWhere).FirstOrDefault();
            this.OnAfterGetById(result, referenceId);
            return result;
        }

        // POST api/References/{reference-guid}
        public Reference Post([FromBody]Reference reference)
        {
            if (reference.ReferenceId == Guid.Empty) reference.ReferenceId = Guid.NewGuid();
            this.OnBeforePost(reference);
            this.SDM.Upsert(reference);
            this.OnAfterPost(reference);
            return reference;
        }

        // POST api/References/{reference-guid}
        public Reference Put([FromBody]Reference reference)
        {
            if (reference.ReferenceId == Guid.Empty) reference.ReferenceId = Guid.NewGuid();
            this.OnBeforePut(reference);
            this.SDM.Upsert(reference);
            this.OnAfterPut(reference);
            return reference;
        }

        // POST api/References/{reference-guid}
        public void Delete(Guid referenceId)
        {
            var referenceWhere = String.Format("ReferenceId = '{0}'", referenceId);
            var reference = this.SDM.GetAllReferences<Reference>(referenceWhere).FirstOrDefault();
            this.OnBeforeDelete(reference);
            this.SDM.Delete(reference);
            this.OnAfterDelete(reference);
        }
    }
}
