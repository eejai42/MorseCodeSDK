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
    public partial class SymbolrepresentationsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Symbolrepresentation> Symbolrepresentations);
        partial void OnAfterGetById(Symbolrepresentation Symbolrepresentations, Guid symbolrepresentationId);
        partial void OnBeforePost(Symbolrepresentation symbolrepresentation);
        partial void OnAfterPost(Symbolrepresentation symbolrepresentation);
        partial void OnBeforePut(Symbolrepresentation symbolrepresentation);
        partial void OnAfterPut(Symbolrepresentation symbolrepresentation);
        partial void OnBeforeDelete(Symbolrepresentation symbolrepresentation);
        partial void OnAfterDelete(Symbolrepresentation symbolrepresentation);
        

        public SymbolrepresentationsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Symbolrepresentation
        public IEnumerable<Symbolrepresentation> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSymbolrepresentations<Symbolrepresentation>();
            Symbolrepresentation.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Symbolrepresentations/{symbolrepresentation-guid}
        public Symbolrepresentation Get(Guid symbolrepresentationId)
        {
            var SymbolrepresentationsWhere = String.Format("SymbolrepresentationId = '{0}'", symbolrepresentationId);
            var result = this.SDM.GetAllSymbolrepresentations<Symbolrepresentation>(SymbolrepresentationsWhere).FirstOrDefault();
            this.OnAfterGetById(result, symbolrepresentationId);
            return result;
        }

        // POST api/Symbolrepresentations/{symbolrepresentation-guid}
        public Symbolrepresentation Post([FromBody]Symbolrepresentation symbolrepresentation)
        {
            if (symbolrepresentation.SymbolrepresentationId == Guid.Empty) symbolrepresentation.SymbolrepresentationId = Guid.NewGuid();
            this.OnBeforePost(symbolrepresentation);
            this.SDM.Upsert(symbolrepresentation);
            this.OnAfterPost(symbolrepresentation);
            return symbolrepresentation;
        }

        // POST api/Symbolrepresentations/{symbolrepresentation-guid}
        public Symbolrepresentation Put([FromBody]Symbolrepresentation symbolrepresentation)
        {
            if (symbolrepresentation.SymbolrepresentationId == Guid.Empty) symbolrepresentation.SymbolrepresentationId = Guid.NewGuid();
            this.OnBeforePut(symbolrepresentation);
            this.SDM.Upsert(symbolrepresentation);
            this.OnAfterPut(symbolrepresentation);
            return symbolrepresentation;
        }

        // POST api/Symbolrepresentations/{symbolrepresentation-guid}
        public void Delete(Guid symbolrepresentationId)
        {
            var symbolrepresentationWhere = String.Format("SymbolrepresentationId = '{0}'", symbolrepresentationId);
            var symbolrepresentation = this.SDM.GetAllSymbolrepresentations<Symbolrepresentation>(symbolrepresentationWhere).FirstOrDefault();
            this.OnBeforeDelete(symbolrepresentation);
            this.SDM.Delete(symbolrepresentation);
            this.OnAfterDelete(symbolrepresentation);
        }
    }
}
