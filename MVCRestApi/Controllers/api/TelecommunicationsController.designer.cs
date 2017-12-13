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
    public partial class TelecommunicationsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Telecommunication> Telecommunications);
        partial void OnAfterGetById(Telecommunication Telecommunications, Guid telecommunicationId);
        partial void OnBeforePost(Telecommunication telecommunication);
        partial void OnAfterPost(Telecommunication telecommunication);
        partial void OnBeforePut(Telecommunication telecommunication);
        partial void OnAfterPut(Telecommunication telecommunication);
        partial void OnBeforeDelete(Telecommunication telecommunication);
        partial void OnAfterDelete(Telecommunication telecommunication);
        

        public TelecommunicationsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Telecommunication
        public IEnumerable<Telecommunication> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllTelecommunications<Telecommunication>();
            Telecommunication.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Telecommunications/{telecommunication-guid}
        public Telecommunication Get(Guid telecommunicationId)
        {
            var TelecommunicationsWhere = String.Format("TelecommunicationId = '{0}'", telecommunicationId);
            var result = this.SDM.GetAllTelecommunications<Telecommunication>(TelecommunicationsWhere).FirstOrDefault();
            this.OnAfterGetById(result, telecommunicationId);
            return result;
        }

        // POST api/Telecommunications/{telecommunication-guid}
        public Telecommunication Post([FromBody]Telecommunication telecommunication)
        {
            if (telecommunication.TelecommunicationId == Guid.Empty) telecommunication.TelecommunicationId = Guid.NewGuid();
            this.OnBeforePost(telecommunication);
            this.SDM.Upsert(telecommunication);
            this.OnAfterPost(telecommunication);
            return telecommunication;
        }

        // POST api/Telecommunications/{telecommunication-guid}
        public Telecommunication Put([FromBody]Telecommunication telecommunication)
        {
            if (telecommunication.TelecommunicationId == Guid.Empty) telecommunication.TelecommunicationId = Guid.NewGuid();
            this.OnBeforePut(telecommunication);
            this.SDM.Upsert(telecommunication);
            this.OnAfterPut(telecommunication);
            return telecommunication;
        }

        // POST api/Telecommunications/{telecommunication-guid}
        public void Delete(Guid telecommunicationId)
        {
            var telecommunicationWhere = String.Format("TelecommunicationId = '{0}'", telecommunicationId);
            var telecommunication = this.SDM.GetAllTelecommunications<Telecommunication>(telecommunicationWhere).FirstOrDefault();
            this.OnBeforeDelete(telecommunication);
            this.SDM.Delete(telecommunication);
            this.OnAfterDelete(telecommunication);
        }
    }
}
