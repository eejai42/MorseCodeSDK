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
    public partial class ProsignsformorsecodesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Prosignsformorsecode> Prosignsformorsecodes);
        partial void OnAfterGetById(Prosignsformorsecode Prosignsformorsecodes, Guid prosignsformorsecodeId);
        partial void OnBeforePost(Prosignsformorsecode prosignsformorsecode);
        partial void OnAfterPost(Prosignsformorsecode prosignsformorsecode);
        partial void OnBeforePut(Prosignsformorsecode prosignsformorsecode);
        partial void OnAfterPut(Prosignsformorsecode prosignsformorsecode);
        partial void OnBeforeDelete(Prosignsformorsecode prosignsformorsecode);
        partial void OnAfterDelete(Prosignsformorsecode prosignsformorsecode);
        

        public ProsignsformorsecodesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Prosignsformorsecode
        public IEnumerable<Prosignsformorsecode> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllProsignsformorsecodes<Prosignsformorsecode>();
            Prosignsformorsecode.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Prosignsformorsecodes/{prosignsformorsecode-guid}
        public Prosignsformorsecode Get(Guid prosignsformorsecodeId)
        {
            var ProsignsformorsecodesWhere = String.Format("ProsignsformorsecodeId = '{0}'", prosignsformorsecodeId);
            var result = this.SDM.GetAllProsignsformorsecodes<Prosignsformorsecode>(ProsignsformorsecodesWhere).FirstOrDefault();
            this.OnAfterGetById(result, prosignsformorsecodeId);
            return result;
        }

        // POST api/Prosignsformorsecodes/{prosignsformorsecode-guid}
        public Prosignsformorsecode Post([FromBody]Prosignsformorsecode prosignsformorsecode)
        {
            if (prosignsformorsecode.ProsignsformorsecodeId == Guid.Empty) prosignsformorsecode.ProsignsformorsecodeId = Guid.NewGuid();
            this.OnBeforePost(prosignsformorsecode);
            this.SDM.Upsert(prosignsformorsecode);
            this.OnAfterPost(prosignsformorsecode);
            return prosignsformorsecode;
        }

        // POST api/Prosignsformorsecodes/{prosignsformorsecode-guid}
        public Prosignsformorsecode Put([FromBody]Prosignsformorsecode prosignsformorsecode)
        {
            if (prosignsformorsecode.ProsignsformorsecodeId == Guid.Empty) prosignsformorsecode.ProsignsformorsecodeId = Guid.NewGuid();
            this.OnBeforePut(prosignsformorsecode);
            this.SDM.Upsert(prosignsformorsecode);
            this.OnAfterPut(prosignsformorsecode);
            return prosignsformorsecode;
        }

        // POST api/Prosignsformorsecodes/{prosignsformorsecode-guid}
        public void Delete(Guid prosignsformorsecodeId)
        {
            var prosignsformorsecodeWhere = String.Format("ProsignsformorsecodeId = '{0}'", prosignsformorsecodeId);
            var prosignsformorsecode = this.SDM.GetAllProsignsformorsecodes<Prosignsformorsecode>(prosignsformorsecodeWhere).FirstOrDefault();
            this.OnBeforeDelete(prosignsformorsecode);
            this.SDM.Delete(prosignsformorsecode);
            this.OnAfterDelete(prosignsformorsecode);
        }
    }
}
