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
    public partial class TrafficsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Traffic> Traffics);
        partial void OnAfterGetById(Traffic Traffics, Guid trafficId);
        partial void OnBeforePost(Traffic traffic);
        partial void OnAfterPost(Traffic traffic);
        partial void OnBeforePut(Traffic traffic);
        partial void OnAfterPut(Traffic traffic);
        partial void OnBeforeDelete(Traffic traffic);
        partial void OnAfterDelete(Traffic traffic);
        

        public TrafficsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Traffic
        public IEnumerable<Traffic> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllTraffics<Traffic>();
            Traffic.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Traffics/{traffic-guid}
        public Traffic Get(Guid trafficId)
        {
            var TrafficsWhere = String.Format("TrafficId = '{0}'", trafficId);
            var result = this.SDM.GetAllTraffics<Traffic>(TrafficsWhere).FirstOrDefault();
            this.OnAfterGetById(result, trafficId);
            return result;
        }

        // POST api/Traffics/{traffic-guid}
        public Traffic Post([FromBody]Traffic traffic)
        {
            if (traffic.TrafficId == Guid.Empty) traffic.TrafficId = Guid.NewGuid();
            this.OnBeforePost(traffic);
            this.SDM.Upsert(traffic);
            this.OnAfterPost(traffic);
            return traffic;
        }

        // POST api/Traffics/{traffic-guid}
        public Traffic Put([FromBody]Traffic traffic)
        {
            if (traffic.TrafficId == Guid.Empty) traffic.TrafficId = Guid.NewGuid();
            this.OnBeforePut(traffic);
            this.SDM.Upsert(traffic);
            this.OnAfterPut(traffic);
            return traffic;
        }

        // POST api/Traffics/{traffic-guid}
        public void Delete(Guid trafficId)
        {
            var trafficWhere = String.Format("TrafficId = '{0}'", trafficId);
            var traffic = this.SDM.GetAllTraffics<Traffic>(trafficWhere).FirstOrDefault();
            this.OnBeforeDelete(traffic);
            this.SDM.Delete(traffic);
            this.OnAfterDelete(traffic);
        }
    }
}
