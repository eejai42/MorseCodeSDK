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
    public partial class SetsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Set> Sets);
        partial void OnAfterGetById(Set Sets, Guid setId);
        partial void OnBeforePost(Set set);
        partial void OnAfterPost(Set set);
        partial void OnBeforePut(Set set);
        partial void OnAfterPut(Set set);
        partial void OnBeforeDelete(Set set);
        partial void OnAfterDelete(Set set);
        

        public SetsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Set
        public IEnumerable<Set> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSets<Set>();
            Set.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Sets/{set-guid}
        public Set Get(Guid setId)
        {
            var SetsWhere = String.Format("SetId = '{0}'", setId);
            var result = this.SDM.GetAllSets<Set>(SetsWhere).FirstOrDefault();
            this.OnAfterGetById(result, setId);
            return result;
        }

        // POST api/Sets/{set-guid}
        public Set Post([FromBody]Set set)
        {
            if (set.SetId == Guid.Empty) set.SetId = Guid.NewGuid();
            this.OnBeforePost(set);
            this.SDM.Upsert(set);
            this.OnAfterPost(set);
            return set;
        }

        // POST api/Sets/{set-guid}
        public Set Put([FromBody]Set set)
        {
            if (set.SetId == Guid.Empty) set.SetId = Guid.NewGuid();
            this.OnBeforePut(set);
            this.SDM.Upsert(set);
            this.OnAfterPut(set);
            return set;
        }

        // POST api/Sets/{set-guid}
        public void Delete(Guid setId)
        {
            var setWhere = String.Format("SetId = '{0}'", setId);
            var set = this.SDM.GetAllSets<Set>(setWhere).FirstOrDefault();
            this.OnBeforeDelete(set);
            this.SDM.Delete(set);
            this.OnAfterDelete(set);
        }
    }
}
