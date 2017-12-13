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
    public partial class UsesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Us> Uses);
        partial void OnAfterGetById(Us Uses, Guid usId);
        partial void OnBeforePost(Us us);
        partial void OnAfterPost(Us us);
        partial void OnBeforePut(Us us);
        partial void OnAfterPut(Us us);
        partial void OnBeforeDelete(Us us);
        partial void OnAfterDelete(Us us);
        

        public UsesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Us
        public IEnumerable<Us> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllUses<Us>();
            Us.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Uses/{us-guid}
        public Us Get(Guid usId)
        {
            var UsesWhere = String.Format("UsId = '{0}'", usId);
            var result = this.SDM.GetAllUses<Us>(UsesWhere).FirstOrDefault();
            this.OnAfterGetById(result, usId);
            return result;
        }

        // POST api/Uses/{us-guid}
        public Us Post([FromBody]Us us)
        {
            if (us.UsId == Guid.Empty) us.UsId = Guid.NewGuid();
            this.OnBeforePost(us);
            this.SDM.Upsert(us);
            this.OnAfterPost(us);
            return us;
        }

        // POST api/Uses/{us-guid}
        public Us Put([FromBody]Us us)
        {
            if (us.UsId == Guid.Empty) us.UsId = Guid.NewGuid();
            this.OnBeforePut(us);
            this.SDM.Upsert(us);
            this.OnAfterPut(us);
            return us;
        }

        // POST api/Uses/{us-guid}
        public void Delete(Guid usId)
        {
            var usWhere = String.Format("UsId = '{0}'", usId);
            var us = this.SDM.GetAllUses<Us>(usWhere).FirstOrDefault();
            this.OnBeforeDelete(us);
            this.SDM.Delete(us);
            this.OnAfterDelete(us);
        }
    }
}
