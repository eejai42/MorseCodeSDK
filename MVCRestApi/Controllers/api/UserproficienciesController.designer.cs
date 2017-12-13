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
    public partial class UserproficienciesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Userproficiency> Userproficiencies);
        partial void OnAfterGetById(Userproficiency Userproficiencies, Guid userproficiencyId);
        partial void OnBeforePost(Userproficiency userproficiency);
        partial void OnAfterPost(Userproficiency userproficiency);
        partial void OnBeforePut(Userproficiency userproficiency);
        partial void OnAfterPut(Userproficiency userproficiency);
        partial void OnBeforeDelete(Userproficiency userproficiency);
        partial void OnAfterDelete(Userproficiency userproficiency);
        

        public UserproficienciesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Userproficiency
        public IEnumerable<Userproficiency> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllUserproficiencies<Userproficiency>();
            Userproficiency.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Userproficiencies/{userproficiency-guid}
        public Userproficiency Get(Guid userproficiencyId)
        {
            var UserproficienciesWhere = String.Format("UserproficiencyId = '{0}'", userproficiencyId);
            var result = this.SDM.GetAllUserproficiencies<Userproficiency>(UserproficienciesWhere).FirstOrDefault();
            this.OnAfterGetById(result, userproficiencyId);
            return result;
        }

        // POST api/Userproficiencies/{userproficiency-guid}
        public Userproficiency Post([FromBody]Userproficiency userproficiency)
        {
            if (userproficiency.UserproficiencyId == Guid.Empty) userproficiency.UserproficiencyId = Guid.NewGuid();
            this.OnBeforePost(userproficiency);
            this.SDM.Upsert(userproficiency);
            this.OnAfterPost(userproficiency);
            return userproficiency;
        }

        // POST api/Userproficiencies/{userproficiency-guid}
        public Userproficiency Put([FromBody]Userproficiency userproficiency)
        {
            if (userproficiency.UserproficiencyId == Guid.Empty) userproficiency.UserproficiencyId = Guid.NewGuid();
            this.OnBeforePut(userproficiency);
            this.SDM.Upsert(userproficiency);
            this.OnAfterPut(userproficiency);
            return userproficiency;
        }

        // POST api/Userproficiencies/{userproficiency-guid}
        public void Delete(Guid userproficiencyId)
        {
            var userproficiencyWhere = String.Format("UserproficiencyId = '{0}'", userproficiencyId);
            var userproficiency = this.SDM.GetAllUserproficiencies<Userproficiency>(userproficiencyWhere).FirstOrDefault();
            this.OnBeforeDelete(userproficiency);
            this.SDM.Delete(userproficiency);
            this.OnAfterDelete(userproficiency);
        }
    }
}
