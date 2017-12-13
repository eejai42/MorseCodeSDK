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
    public partial class ProsignsformorsecodeandnonenglishvariantsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Prosignsformorsecodeandnonenglishvariant> Prosignsformorsecodeandnonenglishvariants);
        partial void OnAfterGetById(Prosignsformorsecodeandnonenglishvariant Prosignsformorsecodeandnonenglishvariants, Guid prosignsformorsecodeandnonenglishvariantId);
        partial void OnBeforePost(Prosignsformorsecodeandnonenglishvariant prosignsformorsecodeandnonenglishvariant);
        partial void OnAfterPost(Prosignsformorsecodeandnonenglishvariant prosignsformorsecodeandnonenglishvariant);
        partial void OnBeforePut(Prosignsformorsecodeandnonenglishvariant prosignsformorsecodeandnonenglishvariant);
        partial void OnAfterPut(Prosignsformorsecodeandnonenglishvariant prosignsformorsecodeandnonenglishvariant);
        partial void OnBeforeDelete(Prosignsformorsecodeandnonenglishvariant prosignsformorsecodeandnonenglishvariant);
        partial void OnAfterDelete(Prosignsformorsecodeandnonenglishvariant prosignsformorsecodeandnonenglishvariant);
        

        public ProsignsformorsecodeandnonenglishvariantsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Prosignsformorsecodeandnonenglishvariant
        public IEnumerable<Prosignsformorsecodeandnonenglishvariant> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllProsignsformorsecodeandnonenglishvariants<Prosignsformorsecodeandnonenglishvariant>();
            Prosignsformorsecodeandnonenglishvariant.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Prosignsformorsecodeandnonenglishvariants/{prosignsformorsecodeandnonenglishvariant-guid}
        public Prosignsformorsecodeandnonenglishvariant Get(Guid prosignsformorsecodeandnonenglishvariantId)
        {
            var ProsignsformorsecodeandnonenglishvariantsWhere = String.Format("ProsignsformorsecodeandnonenglishvariantId = '{0}'", prosignsformorsecodeandnonenglishvariantId);
            var result = this.SDM.GetAllProsignsformorsecodeandnonenglishvariants<Prosignsformorsecodeandnonenglishvariant>(ProsignsformorsecodeandnonenglishvariantsWhere).FirstOrDefault();
            this.OnAfterGetById(result, prosignsformorsecodeandnonenglishvariantId);
            return result;
        }

        // POST api/Prosignsformorsecodeandnonenglishvariants/{prosignsformorsecodeandnonenglishvariant-guid}
        public Prosignsformorsecodeandnonenglishvariant Post([FromBody]Prosignsformorsecodeandnonenglishvariant prosignsformorsecodeandnonenglishvariant)
        {
            if (prosignsformorsecodeandnonenglishvariant.ProsignsformorsecodeandnonenglishvariantId == Guid.Empty) prosignsformorsecodeandnonenglishvariant.ProsignsformorsecodeandnonenglishvariantId = Guid.NewGuid();
            this.OnBeforePost(prosignsformorsecodeandnonenglishvariant);
            this.SDM.Upsert(prosignsformorsecodeandnonenglishvariant);
            this.OnAfterPost(prosignsformorsecodeandnonenglishvariant);
            return prosignsformorsecodeandnonenglishvariant;
        }

        // POST api/Prosignsformorsecodeandnonenglishvariants/{prosignsformorsecodeandnonenglishvariant-guid}
        public Prosignsformorsecodeandnonenglishvariant Put([FromBody]Prosignsformorsecodeandnonenglishvariant prosignsformorsecodeandnonenglishvariant)
        {
            if (prosignsformorsecodeandnonenglishvariant.ProsignsformorsecodeandnonenglishvariantId == Guid.Empty) prosignsformorsecodeandnonenglishvariant.ProsignsformorsecodeandnonenglishvariantId = Guid.NewGuid();
            this.OnBeforePut(prosignsformorsecodeandnonenglishvariant);
            this.SDM.Upsert(prosignsformorsecodeandnonenglishvariant);
            this.OnAfterPut(prosignsformorsecodeandnonenglishvariant);
            return prosignsformorsecodeandnonenglishvariant;
        }

        // POST api/Prosignsformorsecodeandnonenglishvariants/{prosignsformorsecodeandnonenglishvariant-guid}
        public void Delete(Guid prosignsformorsecodeandnonenglishvariantId)
        {
            var prosignsformorsecodeandnonenglishvariantWhere = String.Format("ProsignsformorsecodeandnonenglishvariantId = '{0}'", prosignsformorsecodeandnonenglishvariantId);
            var prosignsformorsecodeandnonenglishvariant = this.SDM.GetAllProsignsformorsecodeandnonenglishvariants<Prosignsformorsecodeandnonenglishvariant>(prosignsformorsecodeandnonenglishvariantWhere).FirstOrDefault();
            this.OnBeforeDelete(prosignsformorsecodeandnonenglishvariant);
            this.SDM.Delete(prosignsformorsecodeandnonenglishvariant);
            this.OnAfterDelete(prosignsformorsecodeandnonenglishvariant);
        }
    }
}
