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
    public partial class AirtrafficcontrollersController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Airtrafficcontroller> Airtrafficcontrollers);
        partial void OnAfterGetById(Airtrafficcontroller Airtrafficcontrollers, Guid airtrafficcontrollerId);
        partial void OnBeforePost(Airtrafficcontroller airtrafficcontroller);
        partial void OnAfterPost(Airtrafficcontroller airtrafficcontroller);
        partial void OnBeforePut(Airtrafficcontroller airtrafficcontroller);
        partial void OnAfterPut(Airtrafficcontroller airtrafficcontroller);
        partial void OnBeforeDelete(Airtrafficcontroller airtrafficcontroller);
        partial void OnAfterDelete(Airtrafficcontroller airtrafficcontroller);
        

        public AirtrafficcontrollersController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Airtrafficcontroller
        public IEnumerable<Airtrafficcontroller> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllAirtrafficcontrollers<Airtrafficcontroller>();
            Airtrafficcontroller.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Airtrafficcontrollers/{airtrafficcontroller-guid}
        public Airtrafficcontroller Get(Guid airtrafficcontrollerId)
        {
            var AirtrafficcontrollersWhere = String.Format("AirtrafficcontrollerId = '{0}'", airtrafficcontrollerId);
            var result = this.SDM.GetAllAirtrafficcontrollers<Airtrafficcontroller>(AirtrafficcontrollersWhere).FirstOrDefault();
            this.OnAfterGetById(result, airtrafficcontrollerId);
            return result;
        }

        // POST api/Airtrafficcontrollers/{airtrafficcontroller-guid}
        public Airtrafficcontroller Post([FromBody]Airtrafficcontroller airtrafficcontroller)
        {
            if (airtrafficcontroller.AirtrafficcontrollerId == Guid.Empty) airtrafficcontroller.AirtrafficcontrollerId = Guid.NewGuid();
            this.OnBeforePost(airtrafficcontroller);
            this.SDM.Upsert(airtrafficcontroller);
            this.OnAfterPost(airtrafficcontroller);
            return airtrafficcontroller;
        }

        // POST api/Airtrafficcontrollers/{airtrafficcontroller-guid}
        public Airtrafficcontroller Put([FromBody]Airtrafficcontroller airtrafficcontroller)
        {
            if (airtrafficcontroller.AirtrafficcontrollerId == Guid.Empty) airtrafficcontroller.AirtrafficcontrollerId = Guid.NewGuid();
            this.OnBeforePut(airtrafficcontroller);
            this.SDM.Upsert(airtrafficcontroller);
            this.OnAfterPut(airtrafficcontroller);
            return airtrafficcontroller;
        }

        // POST api/Airtrafficcontrollers/{airtrafficcontroller-guid}
        public void Delete(Guid airtrafficcontrollerId)
        {
            var airtrafficcontrollerWhere = String.Format("AirtrafficcontrollerId = '{0}'", airtrafficcontrollerId);
            var airtrafficcontroller = this.SDM.GetAllAirtrafficcontrollers<Airtrafficcontroller>(airtrafficcontrollerWhere).FirstOrDefault();
            this.OnBeforeDelete(airtrafficcontroller);
            this.SDM.Delete(airtrafficcontroller);
            this.OnAfterDelete(airtrafficcontroller);
        }
    }
}
