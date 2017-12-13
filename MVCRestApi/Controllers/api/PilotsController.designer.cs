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
    public partial class PilotsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Pilot> Pilots);
        partial void OnAfterGetById(Pilot Pilots, Guid pilotId);
        partial void OnBeforePost(Pilot pilot);
        partial void OnAfterPost(Pilot pilot);
        partial void OnBeforePut(Pilot pilot);
        partial void OnAfterPut(Pilot pilot);
        partial void OnBeforeDelete(Pilot pilot);
        partial void OnAfterDelete(Pilot pilot);
        

        public PilotsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Pilot
        public IEnumerable<Pilot> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllPilots<Pilot>();
            Pilot.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Pilots/{pilot-guid}
        public Pilot Get(Guid pilotId)
        {
            var PilotsWhere = String.Format("PilotId = '{0}'", pilotId);
            var result = this.SDM.GetAllPilots<Pilot>(PilotsWhere).FirstOrDefault();
            this.OnAfterGetById(result, pilotId);
            return result;
        }

        // POST api/Pilots/{pilot-guid}
        public Pilot Post([FromBody]Pilot pilot)
        {
            if (pilot.PilotId == Guid.Empty) pilot.PilotId = Guid.NewGuid();
            this.OnBeforePost(pilot);
            this.SDM.Upsert(pilot);
            this.OnAfterPost(pilot);
            return pilot;
        }

        // POST api/Pilots/{pilot-guid}
        public Pilot Put([FromBody]Pilot pilot)
        {
            if (pilot.PilotId == Guid.Empty) pilot.PilotId = Guid.NewGuid();
            this.OnBeforePut(pilot);
            this.SDM.Upsert(pilot);
            this.OnAfterPut(pilot);
            return pilot;
        }

        // POST api/Pilots/{pilot-guid}
        public void Delete(Guid pilotId)
        {
            var pilotWhere = String.Format("PilotId = '{0}'", pilotId);
            var pilot = this.SDM.GetAllPilots<Pilot>(pilotWhere).FirstOrDefault();
            this.OnBeforeDelete(pilot);
            this.SDM.Delete(pilot);
            this.OnAfterDelete(pilot);
        }
    }
}
