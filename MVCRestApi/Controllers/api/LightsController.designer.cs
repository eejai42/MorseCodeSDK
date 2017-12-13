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
    public partial class LightsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Light> Lights);
        partial void OnAfterGetById(Light Lights, Guid lightId);
        partial void OnBeforePost(Light light);
        partial void OnAfterPost(Light light);
        partial void OnBeforePut(Light light);
        partial void OnAfterPut(Light light);
        partial void OnBeforeDelete(Light light);
        partial void OnAfterDelete(Light light);
        

        public LightsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Light
        public IEnumerable<Light> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllLights<Light>();
            Light.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Lights/{light-guid}
        public Light Get(Guid lightId)
        {
            var LightsWhere = String.Format("LightId = '{0}'", lightId);
            var result = this.SDM.GetAllLights<Light>(LightsWhere).FirstOrDefault();
            this.OnAfterGetById(result, lightId);
            return result;
        }

        // POST api/Lights/{light-guid}
        public Light Post([FromBody]Light light)
        {
            if (light.LightId == Guid.Empty) light.LightId = Guid.NewGuid();
            this.OnBeforePost(light);
            this.SDM.Upsert(light);
            this.OnAfterPost(light);
            return light;
        }

        // POST api/Lights/{light-guid}
        public Light Put([FromBody]Light light)
        {
            if (light.LightId == Guid.Empty) light.LightId = Guid.NewGuid();
            this.OnBeforePut(light);
            this.SDM.Upsert(light);
            this.OnAfterPut(light);
            return light;
        }

        // POST api/Lights/{light-guid}
        public void Delete(Guid lightId)
        {
            var lightWhere = String.Format("LightId = '{0}'", lightId);
            var light = this.SDM.GetAllLights<Light>(lightWhere).FirstOrDefault();
            this.OnBeforeDelete(light);
            this.SDM.Delete(light);
            this.OnAfterDelete(light);
        }
    }
}
