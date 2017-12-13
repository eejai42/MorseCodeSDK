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
    public partial class RomansController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Roman> Romans);
        partial void OnAfterGetById(Roman Romans, Guid romanId);
        partial void OnBeforePost(Roman roman);
        partial void OnAfterPost(Roman roman);
        partial void OnBeforePut(Roman roman);
        partial void OnAfterPut(Roman roman);
        partial void OnBeforeDelete(Roman roman);
        partial void OnAfterDelete(Roman roman);
        

        public RomansController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Roman
        public IEnumerable<Roman> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllRomans<Roman>();
            Roman.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Romans/{roman-guid}
        public Roman Get(Guid romanId)
        {
            var RomansWhere = String.Format("RomanId = '{0}'", romanId);
            var result = this.SDM.GetAllRomans<Roman>(RomansWhere).FirstOrDefault();
            this.OnAfterGetById(result, romanId);
            return result;
        }

        // POST api/Romans/{roman-guid}
        public Roman Post([FromBody]Roman roman)
        {
            if (roman.RomanId == Guid.Empty) roman.RomanId = Guid.NewGuid();
            this.OnBeforePost(roman);
            this.SDM.Upsert(roman);
            this.OnAfterPost(roman);
            return roman;
        }

        // POST api/Romans/{roman-guid}
        public Roman Put([FromBody]Roman roman)
        {
            if (roman.RomanId == Guid.Empty) roman.RomanId = Guid.NewGuid();
            this.OnBeforePut(roman);
            this.SDM.Upsert(roman);
            this.OnAfterPut(roman);
            return roman;
        }

        // POST api/Romans/{roman-guid}
        public void Delete(Guid romanId)
        {
            var romanWhere = String.Format("RomanId = '{0}'", romanId);
            var roman = this.SDM.GetAllRomans<Roman>(romanWhere).FirstOrDefault();
            this.OnBeforeDelete(roman);
            this.SDM.Delete(roman);
            this.OnAfterDelete(roman);
        }
    }
}
