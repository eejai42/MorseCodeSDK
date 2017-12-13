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
    public partial class EmergenciesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Emergency> Emergencies);
        partial void OnAfterGetById(Emergency Emergencies, Guid emergencyId);
        partial void OnBeforePost(Emergency emergency);
        partial void OnAfterPost(Emergency emergency);
        partial void OnBeforePut(Emergency emergency);
        partial void OnAfterPut(Emergency emergency);
        partial void OnBeforeDelete(Emergency emergency);
        partial void OnAfterDelete(Emergency emergency);
        

        public EmergenciesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Emergency
        public IEnumerable<Emergency> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllEmergencies<Emergency>();
            Emergency.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Emergencies/{emergency-guid}
        public Emergency Get(Guid emergencyId)
        {
            var EmergenciesWhere = String.Format("EmergencyId = '{0}'", emergencyId);
            var result = this.SDM.GetAllEmergencies<Emergency>(EmergenciesWhere).FirstOrDefault();
            this.OnAfterGetById(result, emergencyId);
            return result;
        }

        // POST api/Emergencies/{emergency-guid}
        public Emergency Post([FromBody]Emergency emergency)
        {
            if (emergency.EmergencyId == Guid.Empty) emergency.EmergencyId = Guid.NewGuid();
            this.OnBeforePost(emergency);
            this.SDM.Upsert(emergency);
            this.OnAfterPost(emergency);
            return emergency;
        }

        // POST api/Emergencies/{emergency-guid}
        public Emergency Put([FromBody]Emergency emergency)
        {
            if (emergency.EmergencyId == Guid.Empty) emergency.EmergencyId = Guid.NewGuid();
            this.OnBeforePut(emergency);
            this.SDM.Upsert(emergency);
            this.OnAfterPut(emergency);
            return emergency;
        }

        // POST api/Emergencies/{emergency-guid}
        public void Delete(Guid emergencyId)
        {
            var emergencyWhere = String.Format("EmergencyId = '{0}'", emergencyId);
            var emergency = this.SDM.GetAllEmergencies<Emergency>(emergencyWhere).FirstOrDefault();
            this.OnBeforeDelete(emergency);
            this.SDM.Delete(emergency);
            this.OnAfterDelete(emergency);
        }
    }
}
