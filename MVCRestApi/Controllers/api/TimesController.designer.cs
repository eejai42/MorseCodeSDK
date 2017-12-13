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
    public partial class TimesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Time> Times);
        partial void OnAfterGetById(Time Times, Guid timeId);
        partial void OnBeforePost(Time time);
        partial void OnAfterPost(Time time);
        partial void OnBeforePut(Time time);
        partial void OnAfterPut(Time time);
        partial void OnBeforeDelete(Time time);
        partial void OnAfterDelete(Time time);
        

        public TimesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Time
        public IEnumerable<Time> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllTimes<Time>();
            Time.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Times/{time-guid}
        public Time Get(Guid timeId)
        {
            var TimesWhere = String.Format("TimeId = '{0}'", timeId);
            var result = this.SDM.GetAllTimes<Time>(TimesWhere).FirstOrDefault();
            this.OnAfterGetById(result, timeId);
            return result;
        }

        // POST api/Times/{time-guid}
        public Time Post([FromBody]Time time)
        {
            if (time.TimeId == Guid.Empty) time.TimeId = Guid.NewGuid();
            this.OnBeforePost(time);
            this.SDM.Upsert(time);
            this.OnAfterPost(time);
            return time;
        }

        // POST api/Times/{time-guid}
        public Time Put([FromBody]Time time)
        {
            if (time.TimeId == Guid.Empty) time.TimeId = Guid.NewGuid();
            this.OnBeforePut(time);
            this.SDM.Upsert(time);
            this.OnAfterPut(time);
            return time;
        }

        // POST api/Times/{time-guid}
        public void Delete(Guid timeId)
        {
            var timeWhere = String.Format("TimeId = '{0}'", timeId);
            var time = this.SDM.GetAllTimes<Time>(timeWhere).FirstOrDefault();
            this.OnBeforeDelete(time);
            this.SDM.Delete(time);
            this.OnAfterDelete(time);
        }
    }
}
