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
    public partial class AirsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Air> Airs);
        partial void OnAfterGetById(Air Airs, Guid airId);
        partial void OnBeforePost(Air air);
        partial void OnAfterPost(Air air);
        partial void OnBeforePut(Air air);
        partial void OnAfterPut(Air air);
        partial void OnBeforeDelete(Air air);
        partial void OnAfterDelete(Air air);
        

        public AirsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Air
        public IEnumerable<Air> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllAirs<Air>();
            Air.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Airs/{air-guid}
        public Air Get(Guid airId)
        {
            var AirsWhere = String.Format("AirId = '{0}'", airId);
            var result = this.SDM.GetAllAirs<Air>(AirsWhere).FirstOrDefault();
            this.OnAfterGetById(result, airId);
            return result;
        }

        // POST api/Airs/{air-guid}
        public Air Post([FromBody]Air air)
        {
            if (air.AirId == Guid.Empty) air.AirId = Guid.NewGuid();
            this.OnBeforePost(air);
            this.SDM.Upsert(air);
            this.OnAfterPost(air);
            return air;
        }

        // POST api/Airs/{air-guid}
        public Air Put([FromBody]Air air)
        {
            if (air.AirId == Guid.Empty) air.AirId = Guid.NewGuid();
            this.OnBeforePut(air);
            this.SDM.Upsert(air);
            this.OnAfterPut(air);
            return air;
        }

        // POST api/Airs/{air-guid}
        public void Delete(Guid airId)
        {
            var airWhere = String.Format("AirId = '{0}'", airId);
            var air = this.SDM.GetAllAirs<Air>(airWhere).FirstOrDefault();
            this.OnBeforeDelete(air);
            this.SDM.Delete(air);
            this.OnAfterDelete(air);
        }
    }
}
