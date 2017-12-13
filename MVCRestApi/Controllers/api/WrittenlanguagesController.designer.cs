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
    public partial class WrittenlanguagesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Writtenlanguage> Writtenlanguages);
        partial void OnAfterGetById(Writtenlanguage Writtenlanguages, Guid writtenlanguageId);
        partial void OnBeforePost(Writtenlanguage writtenlanguage);
        partial void OnAfterPost(Writtenlanguage writtenlanguage);
        partial void OnBeforePut(Writtenlanguage writtenlanguage);
        partial void OnAfterPut(Writtenlanguage writtenlanguage);
        partial void OnBeforeDelete(Writtenlanguage writtenlanguage);
        partial void OnAfterDelete(Writtenlanguage writtenlanguage);
        

        public WrittenlanguagesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Writtenlanguage
        public IEnumerable<Writtenlanguage> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllWrittenlanguages<Writtenlanguage>();
            Writtenlanguage.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Writtenlanguages/{writtenlanguage-guid}
        public Writtenlanguage Get(Guid writtenlanguageId)
        {
            var WrittenlanguagesWhere = String.Format("WrittenlanguageId = '{0}'", writtenlanguageId);
            var result = this.SDM.GetAllWrittenlanguages<Writtenlanguage>(WrittenlanguagesWhere).FirstOrDefault();
            this.OnAfterGetById(result, writtenlanguageId);
            return result;
        }

        // POST api/Writtenlanguages/{writtenlanguage-guid}
        public Writtenlanguage Post([FromBody]Writtenlanguage writtenlanguage)
        {
            if (writtenlanguage.WrittenlanguageId == Guid.Empty) writtenlanguage.WrittenlanguageId = Guid.NewGuid();
            this.OnBeforePost(writtenlanguage);
            this.SDM.Upsert(writtenlanguage);
            this.OnAfterPost(writtenlanguage);
            return writtenlanguage;
        }

        // POST api/Writtenlanguages/{writtenlanguage-guid}
        public Writtenlanguage Put([FromBody]Writtenlanguage writtenlanguage)
        {
            if (writtenlanguage.WrittenlanguageId == Guid.Empty) writtenlanguage.WrittenlanguageId = Guid.NewGuid();
            this.OnBeforePut(writtenlanguage);
            this.SDM.Upsert(writtenlanguage);
            this.OnAfterPut(writtenlanguage);
            return writtenlanguage;
        }

        // POST api/Writtenlanguages/{writtenlanguage-guid}
        public void Delete(Guid writtenlanguageId)
        {
            var writtenlanguageWhere = String.Format("WrittenlanguageId = '{0}'", writtenlanguageId);
            var writtenlanguage = this.SDM.GetAllWrittenlanguages<Writtenlanguage>(writtenlanguageWhere).FirstOrDefault();
            this.OnBeforeDelete(writtenlanguage);
            this.SDM.Delete(writtenlanguage);
            this.OnAfterDelete(writtenlanguage);
        }
    }
}
