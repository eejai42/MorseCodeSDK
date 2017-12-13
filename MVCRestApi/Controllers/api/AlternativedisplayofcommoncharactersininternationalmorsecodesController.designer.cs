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
    public partial class AlternativedisplayofcommoncharactersininternationalmorsecodesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Alternativedisplayofcommoncharactersininternationalmorsecode> Alternativedisplayofcommoncharactersininternationalmorsecodes);
        partial void OnAfterGetById(Alternativedisplayofcommoncharactersininternationalmorsecode Alternativedisplayofcommoncharactersininternationalmorsecodes, Guid alternativedisplayofcommoncharactersininternationalmorsecodeId);
        partial void OnBeforePost(Alternativedisplayofcommoncharactersininternationalmorsecode alternativedisplayofcommoncharactersininternationalmorsecode);
        partial void OnAfterPost(Alternativedisplayofcommoncharactersininternationalmorsecode alternativedisplayofcommoncharactersininternationalmorsecode);
        partial void OnBeforePut(Alternativedisplayofcommoncharactersininternationalmorsecode alternativedisplayofcommoncharactersininternationalmorsecode);
        partial void OnAfterPut(Alternativedisplayofcommoncharactersininternationalmorsecode alternativedisplayofcommoncharactersininternationalmorsecode);
        partial void OnBeforeDelete(Alternativedisplayofcommoncharactersininternationalmorsecode alternativedisplayofcommoncharactersininternationalmorsecode);
        partial void OnAfterDelete(Alternativedisplayofcommoncharactersininternationalmorsecode alternativedisplayofcommoncharactersininternationalmorsecode);
        

        public AlternativedisplayofcommoncharactersininternationalmorsecodesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Alternativedisplayofcommoncharactersininternationalmorsecode
        public IEnumerable<Alternativedisplayofcommoncharactersininternationalmorsecode> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllAlternativedisplayofcommoncharactersininternationalmorsecodes<Alternativedisplayofcommoncharactersininternationalmorsecode>();
            Alternativedisplayofcommoncharactersininternationalmorsecode.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Alternativedisplayofcommoncharactersininternationalmorsecodes/{alternativedisplayofcommoncharactersininternationalmorsecode-guid}
        public Alternativedisplayofcommoncharactersininternationalmorsecode Get(Guid alternativedisplayofcommoncharactersininternationalmorsecodeId)
        {
            var AlternativedisplayofcommoncharactersininternationalmorsecodesWhere = String.Format("AlternativedisplayofcommoncharactersininternationalmorsecodeId = '{0}'", alternativedisplayofcommoncharactersininternationalmorsecodeId);
            var result = this.SDM.GetAllAlternativedisplayofcommoncharactersininternationalmorsecodes<Alternativedisplayofcommoncharactersininternationalmorsecode>(AlternativedisplayofcommoncharactersininternationalmorsecodesWhere).FirstOrDefault();
            this.OnAfterGetById(result, alternativedisplayofcommoncharactersininternationalmorsecodeId);
            return result;
        }

        // POST api/Alternativedisplayofcommoncharactersininternationalmorsecodes/{alternativedisplayofcommoncharactersininternationalmorsecode-guid}
        public Alternativedisplayofcommoncharactersininternationalmorsecode Post([FromBody]Alternativedisplayofcommoncharactersininternationalmorsecode alternativedisplayofcommoncharactersininternationalmorsecode)
        {
            if (alternativedisplayofcommoncharactersininternationalmorsecode.AlternativedisplayofcommoncharactersininternationalmorsecodeId == Guid.Empty) alternativedisplayofcommoncharactersininternationalmorsecode.AlternativedisplayofcommoncharactersininternationalmorsecodeId = Guid.NewGuid();
            this.OnBeforePost(alternativedisplayofcommoncharactersininternationalmorsecode);
            this.SDM.Upsert(alternativedisplayofcommoncharactersininternationalmorsecode);
            this.OnAfterPost(alternativedisplayofcommoncharactersininternationalmorsecode);
            return alternativedisplayofcommoncharactersininternationalmorsecode;
        }

        // POST api/Alternativedisplayofcommoncharactersininternationalmorsecodes/{alternativedisplayofcommoncharactersininternationalmorsecode-guid}
        public Alternativedisplayofcommoncharactersininternationalmorsecode Put([FromBody]Alternativedisplayofcommoncharactersininternationalmorsecode alternativedisplayofcommoncharactersininternationalmorsecode)
        {
            if (alternativedisplayofcommoncharactersininternationalmorsecode.AlternativedisplayofcommoncharactersininternationalmorsecodeId == Guid.Empty) alternativedisplayofcommoncharactersininternationalmorsecode.AlternativedisplayofcommoncharactersininternationalmorsecodeId = Guid.NewGuid();
            this.OnBeforePut(alternativedisplayofcommoncharactersininternationalmorsecode);
            this.SDM.Upsert(alternativedisplayofcommoncharactersininternationalmorsecode);
            this.OnAfterPut(alternativedisplayofcommoncharactersininternationalmorsecode);
            return alternativedisplayofcommoncharactersininternationalmorsecode;
        }

        // POST api/Alternativedisplayofcommoncharactersininternationalmorsecodes/{alternativedisplayofcommoncharactersininternationalmorsecode-guid}
        public void Delete(Guid alternativedisplayofcommoncharactersininternationalmorsecodeId)
        {
            var alternativedisplayofcommoncharactersininternationalmorsecodeWhere = String.Format("AlternativedisplayofcommoncharactersininternationalmorsecodeId = '{0}'", alternativedisplayofcommoncharactersininternationalmorsecodeId);
            var alternativedisplayofcommoncharactersininternationalmorsecode = this.SDM.GetAllAlternativedisplayofcommoncharactersininternationalmorsecodes<Alternativedisplayofcommoncharactersininternationalmorsecode>(alternativedisplayofcommoncharactersininternationalmorsecodeWhere).FirstOrDefault();
            this.OnBeforeDelete(alternativedisplayofcommoncharactersininternationalmorsecode);
            this.SDM.Delete(alternativedisplayofcommoncharactersininternationalmorsecode);
            this.OnAfterDelete(alternativedisplayofcommoncharactersininternationalmorsecode);
        }
    }
}
