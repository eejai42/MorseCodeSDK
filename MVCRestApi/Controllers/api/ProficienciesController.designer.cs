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
    public partial class ProficienciesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Proficiency> Proficiencies);
        partial void OnAfterGetById(Proficiency Proficiencies, Guid proficiencyId);
        partial void OnBeforePost(Proficiency proficiency);
        partial void OnAfterPost(Proficiency proficiency);
        partial void OnBeforePut(Proficiency proficiency);
        partial void OnAfterPut(Proficiency proficiency);
        partial void OnBeforeDelete(Proficiency proficiency);
        partial void OnAfterDelete(Proficiency proficiency);
        

        public ProficienciesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Proficiency
        public IEnumerable<Proficiency> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllProficiencies<Proficiency>();
            Proficiency.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Proficiencies/{proficiency-guid}
        public Proficiency Get(Guid proficiencyId)
        {
            var ProficienciesWhere = String.Format("ProficiencyId = '{0}'", proficiencyId);
            var result = this.SDM.GetAllProficiencies<Proficiency>(ProficienciesWhere).FirstOrDefault();
            this.OnAfterGetById(result, proficiencyId);
            return result;
        }

        // POST api/Proficiencies/{proficiency-guid}
        public Proficiency Post([FromBody]Proficiency proficiency)
        {
            if (proficiency.ProficiencyId == Guid.Empty) proficiency.ProficiencyId = Guid.NewGuid();
            this.OnBeforePost(proficiency);
            this.SDM.Upsert(proficiency);
            this.OnAfterPost(proficiency);
            return proficiency;
        }

        // POST api/Proficiencies/{proficiency-guid}
        public Proficiency Put([FromBody]Proficiency proficiency)
        {
            if (proficiency.ProficiencyId == Guid.Empty) proficiency.ProficiencyId = Guid.NewGuid();
            this.OnBeforePut(proficiency);
            this.SDM.Upsert(proficiency);
            this.OnAfterPut(proficiency);
            return proficiency;
        }

        // POST api/Proficiencies/{proficiency-guid}
        public void Delete(Guid proficiencyId)
        {
            var proficiencyWhere = String.Format("ProficiencyId = '{0}'", proficiencyId);
            var proficiency = this.SDM.GetAllProficiencies<Proficiency>(proficiencyWhere).FirstOrDefault();
            this.OnBeforeDelete(proficiency);
            this.SDM.Delete(proficiency);
            this.OnAfterDelete(proficiency);
        }
    }
}
