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
    public partial class RepresentationsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Representation> Representations);
        partial void OnAfterGetById(Representation Representations, Guid representationId);
        partial void OnBeforePost(Representation representation);
        partial void OnAfterPost(Representation representation);
        partial void OnBeforePut(Representation representation);
        partial void OnAfterPut(Representation representation);
        partial void OnBeforeDelete(Representation representation);
        partial void OnAfterDelete(Representation representation);
        

        public RepresentationsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Representation
        public IEnumerable<Representation> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllRepresentations<Representation>();
            Representation.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Representations/{representation-guid}
        public Representation Get(Guid representationId)
        {
            var RepresentationsWhere = String.Format("RepresentationId = '{0}'", representationId);
            var result = this.SDM.GetAllRepresentations<Representation>(RepresentationsWhere).FirstOrDefault();
            this.OnAfterGetById(result, representationId);
            return result;
        }

        // POST api/Representations/{representation-guid}
        public Representation Post([FromBody]Representation representation)
        {
            if (representation.RepresentationId == Guid.Empty) representation.RepresentationId = Guid.NewGuid();
            this.OnBeforePost(representation);
            this.SDM.Upsert(representation);
            this.OnAfterPost(representation);
            return representation;
        }

        // POST api/Representations/{representation-guid}
        public Representation Put([FromBody]Representation representation)
        {
            if (representation.RepresentationId == Guid.Empty) representation.RepresentationId = Guid.NewGuid();
            this.OnBeforePut(representation);
            this.SDM.Upsert(representation);
            this.OnAfterPut(representation);
            return representation;
        }

        // POST api/Representations/{representation-guid}
        public void Delete(Guid representationId)
        {
            var representationWhere = String.Format("RepresentationId = '{0}'", representationId);
            var representation = this.SDM.GetAllRepresentations<Representation>(representationWhere).FirstOrDefault();
            this.OnBeforeDelete(representation);
            this.SDM.Delete(representation);
            this.OnAfterDelete(representation);
        }
    }
}
