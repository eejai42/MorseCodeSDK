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
    public partial class TimingsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Timing> Timings);
        partial void OnAfterGetById(Timing Timings, Guid timingId);
        partial void OnBeforePost(Timing timing);
        partial void OnAfterPost(Timing timing);
        partial void OnBeforePut(Timing timing);
        partial void OnAfterPut(Timing timing);
        partial void OnBeforeDelete(Timing timing);
        partial void OnAfterDelete(Timing timing);
        

        public TimingsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Timing
        public IEnumerable<Timing> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllTimings<Timing>();
            Timing.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Timings/{timing-guid}
        public Timing Get(Guid timingId)
        {
            var TimingsWhere = String.Format("TimingId = '{0}'", timingId);
            var result = this.SDM.GetAllTimings<Timing>(TimingsWhere).FirstOrDefault();
            this.OnAfterGetById(result, timingId);
            return result;
        }

        // POST api/Timings/{timing-guid}
        public Timing Post([FromBody]Timing timing)
        {
            if (timing.TimingId == Guid.Empty) timing.TimingId = Guid.NewGuid();
            this.OnBeforePost(timing);
            this.SDM.Upsert(timing);
            this.OnAfterPost(timing);
            return timing;
        }

        // POST api/Timings/{timing-guid}
        public Timing Put([FromBody]Timing timing)
        {
            if (timing.TimingId == Guid.Empty) timing.TimingId = Guid.NewGuid();
            this.OnBeforePut(timing);
            this.SDM.Upsert(timing);
            this.OnAfterPut(timing);
            return timing;
        }

        // POST api/Timings/{timing-guid}
        public void Delete(Guid timingId)
        {
            var timingWhere = String.Format("TimingId = '{0}'", timingId);
            var timing = this.SDM.GetAllTimings<Timing>(timingWhere).FirstOrDefault();
            this.OnBeforeDelete(timing);
            this.SDM.Delete(timing);
            this.OnAfterDelete(timing);
        }
    }
}
