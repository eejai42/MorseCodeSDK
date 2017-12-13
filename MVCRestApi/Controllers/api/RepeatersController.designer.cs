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
    public partial class RepeatersController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Repeater> Repeaters);
        partial void OnAfterGetById(Repeater Repeaters, Guid repeaterId);
        partial void OnBeforePost(Repeater repeater);
        partial void OnAfterPost(Repeater repeater);
        partial void OnBeforePut(Repeater repeater);
        partial void OnAfterPut(Repeater repeater);
        partial void OnBeforeDelete(Repeater repeater);
        partial void OnAfterDelete(Repeater repeater);
        

        public RepeatersController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Repeater
        public IEnumerable<Repeater> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllRepeaters<Repeater>();
            Repeater.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Repeaters/{repeater-guid}
        public Repeater Get(Guid repeaterId)
        {
            var RepeatersWhere = String.Format("RepeaterId = '{0}'", repeaterId);
            var result = this.SDM.GetAllRepeaters<Repeater>(RepeatersWhere).FirstOrDefault();
            this.OnAfterGetById(result, repeaterId);
            return result;
        }

        // POST api/Repeaters/{repeater-guid}
        public Repeater Post([FromBody]Repeater repeater)
        {
            if (repeater.RepeaterId == Guid.Empty) repeater.RepeaterId = Guid.NewGuid();
            this.OnBeforePost(repeater);
            this.SDM.Upsert(repeater);
            this.OnAfterPost(repeater);
            return repeater;
        }

        // POST api/Repeaters/{repeater-guid}
        public Repeater Put([FromBody]Repeater repeater)
        {
            if (repeater.RepeaterId == Guid.Empty) repeater.RepeaterId = Guid.NewGuid();
            this.OnBeforePut(repeater);
            this.SDM.Upsert(repeater);
            this.OnAfterPut(repeater);
            return repeater;
        }

        // POST api/Repeaters/{repeater-guid}
        public void Delete(Guid repeaterId)
        {
            var repeaterWhere = String.Format("RepeaterId = '{0}'", repeaterId);
            var repeater = this.SDM.GetAllRepeaters<Repeater>(repeaterWhere).FirstOrDefault();
            this.OnBeforeDelete(repeater);
            this.SDM.Delete(repeater);
            this.OnAfterDelete(repeater);
        }
    }
}
