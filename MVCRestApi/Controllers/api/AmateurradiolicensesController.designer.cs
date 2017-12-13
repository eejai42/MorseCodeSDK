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
    public partial class AmateurradiolicensesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Amateurradiolicense> Amateurradiolicenses);
        partial void OnAfterGetById(Amateurradiolicense Amateurradiolicenses, Guid amateurradiolicenseId);
        partial void OnBeforePost(Amateurradiolicense amateurradiolicense);
        partial void OnAfterPost(Amateurradiolicense amateurradiolicense);
        partial void OnBeforePut(Amateurradiolicense amateurradiolicense);
        partial void OnAfterPut(Amateurradiolicense amateurradiolicense);
        partial void OnBeforeDelete(Amateurradiolicense amateurradiolicense);
        partial void OnAfterDelete(Amateurradiolicense amateurradiolicense);
        

        public AmateurradiolicensesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Amateurradiolicense
        public IEnumerable<Amateurradiolicense> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllAmateurradiolicenses<Amateurradiolicense>();
            Amateurradiolicense.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Amateurradiolicenses/{amateurradiolicense-guid}
        public Amateurradiolicense Get(Guid amateurradiolicenseId)
        {
            var AmateurradiolicensesWhere = String.Format("AmateurradiolicenseId = '{0}'", amateurradiolicenseId);
            var result = this.SDM.GetAllAmateurradiolicenses<Amateurradiolicense>(AmateurradiolicensesWhere).FirstOrDefault();
            this.OnAfterGetById(result, amateurradiolicenseId);
            return result;
        }

        // POST api/Amateurradiolicenses/{amateurradiolicense-guid}
        public Amateurradiolicense Post([FromBody]Amateurradiolicense amateurradiolicense)
        {
            if (amateurradiolicense.AmateurradiolicenseId == Guid.Empty) amateurradiolicense.AmateurradiolicenseId = Guid.NewGuid();
            this.OnBeforePost(amateurradiolicense);
            this.SDM.Upsert(amateurradiolicense);
            this.OnAfterPost(amateurradiolicense);
            return amateurradiolicense;
        }

        // POST api/Amateurradiolicenses/{amateurradiolicense-guid}
        public Amateurradiolicense Put([FromBody]Amateurradiolicense amateurradiolicense)
        {
            if (amateurradiolicense.AmateurradiolicenseId == Guid.Empty) amateurradiolicense.AmateurradiolicenseId = Guid.NewGuid();
            this.OnBeforePut(amateurradiolicense);
            this.SDM.Upsert(amateurradiolicense);
            this.OnAfterPut(amateurradiolicense);
            return amateurradiolicense;
        }

        // POST api/Amateurradiolicenses/{amateurradiolicense-guid}
        public void Delete(Guid amateurradiolicenseId)
        {
            var amateurradiolicenseWhere = String.Format("AmateurradiolicenseId = '{0}'", amateurradiolicenseId);
            var amateurradiolicense = this.SDM.GetAllAmateurradiolicenses<Amateurradiolicense>(amateurradiolicenseWhere).FirstOrDefault();
            this.OnBeforeDelete(amateurradiolicense);
            this.SDM.Delete(amateurradiolicense);
            this.OnAfterDelete(amateurradiolicense);
        }
    }
}
