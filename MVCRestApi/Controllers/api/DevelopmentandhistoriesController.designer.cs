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
    public partial class DevelopmentandhistoriesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Developmentandhistory> Developmentandhistories);
        partial void OnAfterGetById(Developmentandhistory Developmentandhistories, Guid developmentandhistoryId);
        partial void OnBeforePost(Developmentandhistory developmentandhistory);
        partial void OnAfterPost(Developmentandhistory developmentandhistory);
        partial void OnBeforePut(Developmentandhistory developmentandhistory);
        partial void OnAfterPut(Developmentandhistory developmentandhistory);
        partial void OnBeforeDelete(Developmentandhistory developmentandhistory);
        partial void OnAfterDelete(Developmentandhistory developmentandhistory);
        

        public DevelopmentandhistoriesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Developmentandhistory
        public IEnumerable<Developmentandhistory> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllDevelopmentandhistories<Developmentandhistory>();
            Developmentandhistory.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Developmentandhistories/{developmentandhistory-guid}
        public Developmentandhistory Get(Guid developmentandhistoryId)
        {
            var DevelopmentandhistoriesWhere = String.Format("DevelopmentandhistoryId = '{0}'", developmentandhistoryId);
            var result = this.SDM.GetAllDevelopmentandhistories<Developmentandhistory>(DevelopmentandhistoriesWhere).FirstOrDefault();
            this.OnAfterGetById(result, developmentandhistoryId);
            return result;
        }

        // POST api/Developmentandhistories/{developmentandhistory-guid}
        public Developmentandhistory Post([FromBody]Developmentandhistory developmentandhistory)
        {
            if (developmentandhistory.DevelopmentandhistoryId == Guid.Empty) developmentandhistory.DevelopmentandhistoryId = Guid.NewGuid();
            this.OnBeforePost(developmentandhistory);
            this.SDM.Upsert(developmentandhistory);
            this.OnAfterPost(developmentandhistory);
            return developmentandhistory;
        }

        // POST api/Developmentandhistories/{developmentandhistory-guid}
        public Developmentandhistory Put([FromBody]Developmentandhistory developmentandhistory)
        {
            if (developmentandhistory.DevelopmentandhistoryId == Guid.Empty) developmentandhistory.DevelopmentandhistoryId = Guid.NewGuid();
            this.OnBeforePut(developmentandhistory);
            this.SDM.Upsert(developmentandhistory);
            this.OnAfterPut(developmentandhistory);
            return developmentandhistory;
        }

        // POST api/Developmentandhistories/{developmentandhistory-guid}
        public void Delete(Guid developmentandhistoryId)
        {
            var developmentandhistoryWhere = String.Format("DevelopmentandhistoryId = '{0}'", developmentandhistoryId);
            var developmentandhistory = this.SDM.GetAllDevelopmentandhistories<Developmentandhistory>(developmentandhistoryWhere).FirstOrDefault();
            this.OnBeforeDelete(developmentandhistory);
            this.SDM.Delete(developmentandhistory);
            this.OnAfterDelete(developmentandhistory);
        }
    }
}
