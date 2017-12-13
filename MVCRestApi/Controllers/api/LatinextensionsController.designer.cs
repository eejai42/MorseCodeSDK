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
    public partial class LatinextensionsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Latinextension> Latinextensions);
        partial void OnAfterGetById(Latinextension Latinextensions, Guid latinextensionId);
        partial void OnBeforePost(Latinextension latinextension);
        partial void OnAfterPost(Latinextension latinextension);
        partial void OnBeforePut(Latinextension latinextension);
        partial void OnAfterPut(Latinextension latinextension);
        partial void OnBeforeDelete(Latinextension latinextension);
        partial void OnAfterDelete(Latinextension latinextension);
        

        public LatinextensionsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Latinextension
        public IEnumerable<Latinextension> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllLatinextensions<Latinextension>();
            Latinextension.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Latinextensions/{latinextension-guid}
        public Latinextension Get(Guid latinextensionId)
        {
            var LatinextensionsWhere = String.Format("LatinextensionId = '{0}'", latinextensionId);
            var result = this.SDM.GetAllLatinextensions<Latinextension>(LatinextensionsWhere).FirstOrDefault();
            this.OnAfterGetById(result, latinextensionId);
            return result;
        }

        // POST api/Latinextensions/{latinextension-guid}
        public Latinextension Post([FromBody]Latinextension latinextension)
        {
            if (latinextension.LatinextensionId == Guid.Empty) latinextension.LatinextensionId = Guid.NewGuid();
            this.OnBeforePost(latinextension);
            this.SDM.Upsert(latinextension);
            this.OnAfterPost(latinextension);
            return latinextension;
        }

        // POST api/Latinextensions/{latinextension-guid}
        public Latinextension Put([FromBody]Latinextension latinextension)
        {
            if (latinextension.LatinextensionId == Guid.Empty) latinextension.LatinextensionId = Guid.NewGuid();
            this.OnBeforePut(latinextension);
            this.SDM.Upsert(latinextension);
            this.OnAfterPut(latinextension);
            return latinextension;
        }

        // POST api/Latinextensions/{latinextension-guid}
        public void Delete(Guid latinextensionId)
        {
            var latinextensionWhere = String.Format("LatinextensionId = '{0}'", latinextensionId);
            var latinextension = this.SDM.GetAllLatinextensions<Latinextension>(latinextensionWhere).FirstOrDefault();
            this.OnBeforeDelete(latinextension);
            this.SDM.Delete(latinextension);
            this.OnAfterDelete(latinextension);
        }
    }
}
