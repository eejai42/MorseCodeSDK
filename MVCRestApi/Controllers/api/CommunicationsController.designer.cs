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
    public partial class CommunicationsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Communication> Communications);
        partial void OnAfterGetById(Communication Communications, Guid communicationId);
        partial void OnBeforePost(Communication communication);
        partial void OnAfterPost(Communication communication);
        partial void OnBeforePut(Communication communication);
        partial void OnAfterPut(Communication communication);
        partial void OnBeforeDelete(Communication communication);
        partial void OnAfterDelete(Communication communication);
        

        public CommunicationsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Communication
        public IEnumerable<Communication> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllCommunications<Communication>();
            Communication.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Communications/{communication-guid}
        public Communication Get(Guid communicationId)
        {
            var CommunicationsWhere = String.Format("CommunicationId = '{0}'", communicationId);
            var result = this.SDM.GetAllCommunications<Communication>(CommunicationsWhere).FirstOrDefault();
            this.OnAfterGetById(result, communicationId);
            return result;
        }

        // POST api/Communications/{communication-guid}
        public Communication Post([FromBody]Communication communication)
        {
            if (communication.CommunicationId == Guid.Empty) communication.CommunicationId = Guid.NewGuid();
            this.OnBeforePost(communication);
            this.SDM.Upsert(communication);
            this.OnAfterPost(communication);
            return communication;
        }

        // POST api/Communications/{communication-guid}
        public Communication Put([FromBody]Communication communication)
        {
            if (communication.CommunicationId == Guid.Empty) communication.CommunicationId = Guid.NewGuid();
            this.OnBeforePut(communication);
            this.SDM.Upsert(communication);
            this.OnAfterPut(communication);
            return communication;
        }

        // POST api/Communications/{communication-guid}
        public void Delete(Guid communicationId)
        {
            var communicationWhere = String.Format("CommunicationId = '{0}'", communicationId);
            var communication = this.SDM.GetAllCommunications<Communication>(communicationWhere).FirstOrDefault();
            this.OnBeforeDelete(communication);
            this.SDM.Delete(communication);
            this.OnAfterDelete(communication);
        }
    }
}
