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
    public partial class MinutesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Minute> Minutes);
        partial void OnAfterGetById(Minute Minutes, Guid minuteId);
        partial void OnBeforePost(Minute minute);
        partial void OnAfterPost(Minute minute);
        partial void OnBeforePut(Minute minute);
        partial void OnAfterPut(Minute minute);
        partial void OnBeforeDelete(Minute minute);
        partial void OnAfterDelete(Minute minute);
        

        public MinutesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Minute
        public IEnumerable<Minute> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllMinutes<Minute>();
            Minute.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Minutes/{minute-guid}
        public Minute Get(Guid minuteId)
        {
            var MinutesWhere = String.Format("MinuteId = '{0}'", minuteId);
            var result = this.SDM.GetAllMinutes<Minute>(MinutesWhere).FirstOrDefault();
            this.OnAfterGetById(result, minuteId);
            return result;
        }

        // POST api/Minutes/{minute-guid}
        public Minute Post([FromBody]Minute minute)
        {
            if (minute.MinuteId == Guid.Empty) minute.MinuteId = Guid.NewGuid();
            this.OnBeforePost(minute);
            this.SDM.Upsert(minute);
            this.OnAfterPost(minute);
            return minute;
        }

        // POST api/Minutes/{minute-guid}
        public Minute Put([FromBody]Minute minute)
        {
            if (minute.MinuteId == Guid.Empty) minute.MinuteId = Guid.NewGuid();
            this.OnBeforePut(minute);
            this.SDM.Upsert(minute);
            this.OnAfterPut(minute);
            return minute;
        }

        // POST api/Minutes/{minute-guid}
        public void Delete(Guid minuteId)
        {
            var minuteWhere = String.Format("MinuteId = '{0}'", minuteId);
            var minute = this.SDM.GetAllMinutes<Minute>(minuteWhere).FirstOrDefault();
            this.OnBeforeDelete(minute);
            this.SDM.Delete(minute);
            this.OnAfterDelete(minute);
        }
    }
}
