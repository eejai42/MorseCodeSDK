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
    public partial class InternationalmorsecodesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Internationalmorsecode> Internationalmorsecodes);
        partial void OnAfterGetById(Internationalmorsecode Internationalmorsecodes, Guid internationalmorsecodeId);
        partial void OnBeforePost(Internationalmorsecode internationalmorsecode);
        partial void OnAfterPost(Internationalmorsecode internationalmorsecode);
        partial void OnBeforePut(Internationalmorsecode internationalmorsecode);
        partial void OnAfterPut(Internationalmorsecode internationalmorsecode);
        partial void OnBeforeDelete(Internationalmorsecode internationalmorsecode);
        partial void OnAfterDelete(Internationalmorsecode internationalmorsecode);
        

        public InternationalmorsecodesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Internationalmorsecode
        public IEnumerable<Internationalmorsecode> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllInternationalmorsecodes<Internationalmorsecode>();
            Internationalmorsecode.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Internationalmorsecodes/{internationalmorsecode-guid}
        public Internationalmorsecode Get(Guid internationalmorsecodeId)
        {
            var InternationalmorsecodesWhere = String.Format("InternationalmorsecodeId = '{0}'", internationalmorsecodeId);
            var result = this.SDM.GetAllInternationalmorsecodes<Internationalmorsecode>(InternationalmorsecodesWhere).FirstOrDefault();
            this.OnAfterGetById(result, internationalmorsecodeId);
            return result;
        }

        // POST api/Internationalmorsecodes/{internationalmorsecode-guid}
        public Internationalmorsecode Post([FromBody]Internationalmorsecode internationalmorsecode)
        {
            if (internationalmorsecode.InternationalmorsecodeId == Guid.Empty) internationalmorsecode.InternationalmorsecodeId = Guid.NewGuid();
            this.OnBeforePost(internationalmorsecode);
            this.SDM.Upsert(internationalmorsecode);
            this.OnAfterPost(internationalmorsecode);
            return internationalmorsecode;
        }

        // POST api/Internationalmorsecodes/{internationalmorsecode-guid}
        public Internationalmorsecode Put([FromBody]Internationalmorsecode internationalmorsecode)
        {
            if (internationalmorsecode.InternationalmorsecodeId == Guid.Empty) internationalmorsecode.InternationalmorsecodeId = Guid.NewGuid();
            this.OnBeforePut(internationalmorsecode);
            this.SDM.Upsert(internationalmorsecode);
            this.OnAfterPut(internationalmorsecode);
            return internationalmorsecode;
        }

        // POST api/Internationalmorsecodes/{internationalmorsecode-guid}
        public void Delete(Guid internationalmorsecodeId)
        {
            var internationalmorsecodeWhere = String.Format("InternationalmorsecodeId = '{0}'", internationalmorsecodeId);
            var internationalmorsecode = this.SDM.GetAllInternationalmorsecodes<Internationalmorsecode>(internationalmorsecodeWhere).FirstOrDefault();
            this.OnBeforeDelete(internationalmorsecode);
            this.SDM.Delete(internationalmorsecode);
            this.OnAfterDelete(internationalmorsecode);
        }
    }
}
