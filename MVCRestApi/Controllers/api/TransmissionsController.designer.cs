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
    public partial class TransmissionsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Transmission> Transmissions);
        partial void OnAfterGetById(Transmission Transmissions, Guid transmissionId);
        partial void OnBeforePost(Transmission transmission);
        partial void OnAfterPost(Transmission transmission);
        partial void OnBeforePut(Transmission transmission);
        partial void OnAfterPut(Transmission transmission);
        partial void OnBeforeDelete(Transmission transmission);
        partial void OnAfterDelete(Transmission transmission);
        

        public TransmissionsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Transmission
        public IEnumerable<Transmission> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllTransmissions<Transmission>();
            Transmission.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Transmissions/{transmission-guid}
        public Transmission Get(Guid transmissionId)
        {
            var TransmissionsWhere = String.Format("TransmissionId = '{0}'", transmissionId);
            var result = this.SDM.GetAllTransmissions<Transmission>(TransmissionsWhere).FirstOrDefault();
            this.OnAfterGetById(result, transmissionId);
            return result;
        }

        // POST api/Transmissions/{transmission-guid}
        public Transmission Post([FromBody]Transmission transmission)
        {
            if (transmission.TransmissionId == Guid.Empty) transmission.TransmissionId = Guid.NewGuid();
            this.OnBeforePost(transmission);
            this.SDM.Upsert(transmission);
            this.OnAfterPost(transmission);
            return transmission;
        }

        // POST api/Transmissions/{transmission-guid}
        public Transmission Put([FromBody]Transmission transmission)
        {
            if (transmission.TransmissionId == Guid.Empty) transmission.TransmissionId = Guid.NewGuid();
            this.OnBeforePut(transmission);
            this.SDM.Upsert(transmission);
            this.OnAfterPut(transmission);
            return transmission;
        }

        // POST api/Transmissions/{transmission-guid}
        public void Delete(Guid transmissionId)
        {
            var transmissionWhere = String.Format("TransmissionId = '{0}'", transmissionId);
            var transmission = this.SDM.GetAllTransmissions<Transmission>(transmissionWhere).FirstOrDefault();
            this.OnBeforeDelete(transmission);
            this.SDM.Delete(transmission);
            this.OnAfterDelete(transmission);
        }
    }
}
