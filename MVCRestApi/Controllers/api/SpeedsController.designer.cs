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
    public partial class SpeedsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Speed> Speeds);
        partial void OnAfterGetById(Speed Speeds, Guid speedId);
        partial void OnBeforePost(Speed speed);
        partial void OnAfterPost(Speed speed);
        partial void OnBeforePut(Speed speed);
        partial void OnAfterPut(Speed speed);
        partial void OnBeforeDelete(Speed speed);
        partial void OnAfterDelete(Speed speed);
        

        public SpeedsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Speed
        public IEnumerable<Speed> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSpeeds<Speed>();
            Speed.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Speeds/{speed-guid}
        public Speed Get(Guid speedId)
        {
            var SpeedsWhere = String.Format("SpeedId = '{0}'", speedId);
            var result = this.SDM.GetAllSpeeds<Speed>(SpeedsWhere).FirstOrDefault();
            this.OnAfterGetById(result, speedId);
            return result;
        }

        // POST api/Speeds/{speed-guid}
        public Speed Post([FromBody]Speed speed)
        {
            if (speed.SpeedId == Guid.Empty) speed.SpeedId = Guid.NewGuid();
            this.OnBeforePost(speed);
            this.SDM.Upsert(speed);
            this.OnAfterPost(speed);
            return speed;
        }

        // POST api/Speeds/{speed-guid}
        public Speed Put([FromBody]Speed speed)
        {
            if (speed.SpeedId == Guid.Empty) speed.SpeedId = Guid.NewGuid();
            this.OnBeforePut(speed);
            this.SDM.Upsert(speed);
            this.OnAfterPut(speed);
            return speed;
        }

        // POST api/Speeds/{speed-guid}
        public void Delete(Guid speedId)
        {
            var speedWhere = String.Format("SpeedId = '{0}'", speedId);
            var speed = this.SDM.GetAllSpeeds<Speed>(speedWhere).FirstOrDefault();
            this.OnBeforeDelete(speed);
            this.SDM.Delete(speed);
            this.OnAfterDelete(speed);
        }
    }
}
