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
    public partial class ApplicationsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Application> Applications);
        partial void OnAfterGetById(Application Applications, Guid applicationId);
        partial void OnBeforePost(Application application);
        partial void OnAfterPost(Application application);
        partial void OnBeforePut(Application application);
        partial void OnAfterPut(Application application);
        partial void OnBeforeDelete(Application application);
        partial void OnAfterDelete(Application application);
        

        public ApplicationsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Application
        public IEnumerable<Application> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllApplications<Application>();
            Application.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Applications/{application-guid}
        public Application Get(Guid applicationId)
        {
            var ApplicationsWhere = String.Format("ApplicationId = '{0}'", applicationId);
            var result = this.SDM.GetAllApplications<Application>(ApplicationsWhere).FirstOrDefault();
            this.OnAfterGetById(result, applicationId);
            return result;
        }

        // POST api/Applications/{application-guid}
        public Application Post([FromBody]Application application)
        {
            if (application.ApplicationId == Guid.Empty) application.ApplicationId = Guid.NewGuid();
            this.OnBeforePost(application);
            this.SDM.Upsert(application);
            this.OnAfterPost(application);
            return application;
        }

        // POST api/Applications/{application-guid}
        public Application Put([FromBody]Application application)
        {
            if (application.ApplicationId == Guid.Empty) application.ApplicationId = Guid.NewGuid();
            this.OnBeforePut(application);
            this.SDM.Upsert(application);
            this.OnAfterPut(application);
            return application;
        }

        // POST api/Applications/{application-guid}
        public void Delete(Guid applicationId)
        {
            var applicationWhere = String.Format("ApplicationId = '{0}'", applicationId);
            var application = this.SDM.GetAllApplications<Application>(applicationWhere).FirstOrDefault();
            this.OnBeforeDelete(application);
            this.SDM.Delete(application);
            this.OnAfterDelete(application);
        }
    }
}
