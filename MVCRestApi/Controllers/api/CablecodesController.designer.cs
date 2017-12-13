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
    public partial class CablecodesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Cablecode> Cablecodes);
        partial void OnAfterGetById(Cablecode Cablecodes, Guid cablecodeId);
        partial void OnBeforePost(Cablecode cablecode);
        partial void OnAfterPost(Cablecode cablecode);
        partial void OnBeforePut(Cablecode cablecode);
        partial void OnAfterPut(Cablecode cablecode);
        partial void OnBeforeDelete(Cablecode cablecode);
        partial void OnAfterDelete(Cablecode cablecode);
        

        public CablecodesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Cablecode
        public IEnumerable<Cablecode> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllCablecodes<Cablecode>();
            Cablecode.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Cablecodes/{cablecode-guid}
        public Cablecode Get(Guid cablecodeId)
        {
            var CablecodesWhere = String.Format("CablecodeId = '{0}'", cablecodeId);
            var result = this.SDM.GetAllCablecodes<Cablecode>(CablecodesWhere).FirstOrDefault();
            this.OnAfterGetById(result, cablecodeId);
            return result;
        }

        // POST api/Cablecodes/{cablecode-guid}
        public Cablecode Post([FromBody]Cablecode cablecode)
        {
            if (cablecode.CablecodeId == Guid.Empty) cablecode.CablecodeId = Guid.NewGuid();
            this.OnBeforePost(cablecode);
            this.SDM.Upsert(cablecode);
            this.OnAfterPost(cablecode);
            return cablecode;
        }

        // POST api/Cablecodes/{cablecode-guid}
        public Cablecode Put([FromBody]Cablecode cablecode)
        {
            if (cablecode.CablecodeId == Guid.Empty) cablecode.CablecodeId = Guid.NewGuid();
            this.OnBeforePut(cablecode);
            this.SDM.Upsert(cablecode);
            this.OnAfterPut(cablecode);
            return cablecode;
        }

        // POST api/Cablecodes/{cablecode-guid}
        public void Delete(Guid cablecodeId)
        {
            var cablecodeWhere = String.Format("CablecodeId = '{0}'", cablecodeId);
            var cablecode = this.SDM.GetAllCablecodes<Cablecode>(cablecodeWhere).FirstOrDefault();
            this.OnBeforeDelete(cablecode);
            this.SDM.Delete(cablecode);
            this.OnAfterDelete(cablecode);
        }
    }
}
