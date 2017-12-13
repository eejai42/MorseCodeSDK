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
    public partial class TechnologiesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Technology> Technologies);
        partial void OnAfterGetById(Technology Technologies, Guid technologyId);
        partial void OnBeforePost(Technology technology);
        partial void OnAfterPost(Technology technology);
        partial void OnBeforePut(Technology technology);
        partial void OnAfterPut(Technology technology);
        partial void OnBeforeDelete(Technology technology);
        partial void OnAfterDelete(Technology technology);
        

        public TechnologiesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Technology
        public IEnumerable<Technology> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllTechnologies<Technology>();
            Technology.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Technologies/{technology-guid}
        public Technology Get(Guid technologyId)
        {
            var TechnologiesWhere = String.Format("TechnologyId = '{0}'", technologyId);
            var result = this.SDM.GetAllTechnologies<Technology>(TechnologiesWhere).FirstOrDefault();
            this.OnAfterGetById(result, technologyId);
            return result;
        }

        // POST api/Technologies/{technology-guid}
        public Technology Post([FromBody]Technology technology)
        {
            if (technology.TechnologyId == Guid.Empty) technology.TechnologyId = Guid.NewGuid();
            this.OnBeforePost(technology);
            this.SDM.Upsert(technology);
            this.OnAfterPost(technology);
            return technology;
        }

        // POST api/Technologies/{technology-guid}
        public Technology Put([FromBody]Technology technology)
        {
            if (technology.TechnologyId == Guid.Empty) technology.TechnologyId = Guid.NewGuid();
            this.OnBeforePut(technology);
            this.SDM.Upsert(technology);
            this.OnAfterPut(technology);
            return technology;
        }

        // POST api/Technologies/{technology-guid}
        public void Delete(Guid technologyId)
        {
            var technologyWhere = String.Format("TechnologyId = '{0}'", technologyId);
            var technology = this.SDM.GetAllTechnologies<Technology>(technologyWhere).FirstOrDefault();
            this.OnBeforeDelete(technology);
            this.SDM.Delete(technology);
            this.OnAfterDelete(technology);
        }
    }
}
