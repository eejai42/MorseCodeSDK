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
    public partial class DurationsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Duration> Durations);
        partial void OnAfterGetById(Duration Durations, Guid durationId);
        partial void OnBeforePost(Duration duration);
        partial void OnAfterPost(Duration duration);
        partial void OnBeforePut(Duration duration);
        partial void OnAfterPut(Duration duration);
        partial void OnBeforeDelete(Duration duration);
        partial void OnAfterDelete(Duration duration);
        

        public DurationsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Duration
        public IEnumerable<Duration> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllDurations<Duration>();
            Duration.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Durations/{duration-guid}
        public Duration Get(Guid durationId)
        {
            var DurationsWhere = String.Format("DurationId = '{0}'", durationId);
            var result = this.SDM.GetAllDurations<Duration>(DurationsWhere).FirstOrDefault();
            this.OnAfterGetById(result, durationId);
            return result;
        }

        // POST api/Durations/{duration-guid}
        public Duration Post([FromBody]Duration duration)
        {
            if (duration.DurationId == Guid.Empty) duration.DurationId = Guid.NewGuid();
            this.OnBeforePost(duration);
            this.SDM.Upsert(duration);
            this.OnAfterPost(duration);
            return duration;
        }

        // POST api/Durations/{duration-guid}
        public Duration Put([FromBody]Duration duration)
        {
            if (duration.DurationId == Guid.Empty) duration.DurationId = Guid.NewGuid();
            this.OnBeforePut(duration);
            this.SDM.Upsert(duration);
            this.OnAfterPut(duration);
            return duration;
        }

        // POST api/Durations/{duration-guid}
        public void Delete(Guid durationId)
        {
            var durationWhere = String.Format("DurationId = '{0}'", durationId);
            var duration = this.SDM.GetAllDurations<Duration>(durationWhere).FirstOrDefault();
            this.OnBeforeDelete(duration);
            this.SDM.Delete(duration);
            this.OnAfterDelete(duration);
        }
    }
}
