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
    public partial class DevelopmentsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Development> Developments);
        partial void OnAfterGetById(Development Developments, Guid developmentId);
        partial void OnBeforePost(Development development);
        partial void OnAfterPost(Development development);
        partial void OnBeforePut(Development development);
        partial void OnAfterPut(Development development);
        partial void OnBeforeDelete(Development development);
        partial void OnAfterDelete(Development development);
        

        public DevelopmentsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Development
        public IEnumerable<Development> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllDevelopments<Development>();
            Development.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Developments/{development-guid}
        public Development Get(Guid developmentId)
        {
            var DevelopmentsWhere = String.Format("DevelopmentId = '{0}'", developmentId);
            var result = this.SDM.GetAllDevelopments<Development>(DevelopmentsWhere).FirstOrDefault();
            this.OnAfterGetById(result, developmentId);
            return result;
        }

        // POST api/Developments/{development-guid}
        public Development Post([FromBody]Development development)
        {
            if (development.DevelopmentId == Guid.Empty) development.DevelopmentId = Guid.NewGuid();
            this.OnBeforePost(development);
            this.SDM.Upsert(development);
            this.OnAfterPost(development);
            return development;
        }

        // POST api/Developments/{development-guid}
        public Development Put([FromBody]Development development)
        {
            if (development.DevelopmentId == Guid.Empty) development.DevelopmentId = Guid.NewGuid();
            this.OnBeforePut(development);
            this.SDM.Upsert(development);
            this.OnAfterPut(development);
            return development;
        }

        // POST api/Developments/{development-guid}
        public void Delete(Guid developmentId)
        {
            var developmentWhere = String.Format("DevelopmentId = '{0}'", developmentId);
            var development = this.SDM.GetAllDevelopments<Development>(developmentWhere).FirstOrDefault();
            this.OnBeforeDelete(development);
            this.SDM.Delete(development);
            this.OnAfterDelete(development);
        }
    }
}
