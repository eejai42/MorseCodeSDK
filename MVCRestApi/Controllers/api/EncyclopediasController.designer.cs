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
    public partial class EncyclopediasController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Encyclopedia> Encyclopedias);
        partial void OnAfterGetById(Encyclopedia Encyclopedias, Guid encyclopediaId);
        partial void OnBeforePost(Encyclopedia encyclopedia);
        partial void OnAfterPost(Encyclopedia encyclopedia);
        partial void OnBeforePut(Encyclopedia encyclopedia);
        partial void OnAfterPut(Encyclopedia encyclopedia);
        partial void OnBeforeDelete(Encyclopedia encyclopedia);
        partial void OnAfterDelete(Encyclopedia encyclopedia);
        

        public EncyclopediasController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Encyclopedia
        public IEnumerable<Encyclopedia> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllEncyclopedias<Encyclopedia>();
            Encyclopedia.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Encyclopedias/{encyclopedia-guid}
        public Encyclopedia Get(Guid encyclopediaId)
        {
            var EncyclopediasWhere = String.Format("EncyclopediaId = '{0}'", encyclopediaId);
            var result = this.SDM.GetAllEncyclopedias<Encyclopedia>(EncyclopediasWhere).FirstOrDefault();
            this.OnAfterGetById(result, encyclopediaId);
            return result;
        }

        // POST api/Encyclopedias/{encyclopedia-guid}
        public Encyclopedia Post([FromBody]Encyclopedia encyclopedia)
        {
            if (encyclopedia.EncyclopediaId == Guid.Empty) encyclopedia.EncyclopediaId = Guid.NewGuid();
            this.OnBeforePost(encyclopedia);
            this.SDM.Upsert(encyclopedia);
            this.OnAfterPost(encyclopedia);
            return encyclopedia;
        }

        // POST api/Encyclopedias/{encyclopedia-guid}
        public Encyclopedia Put([FromBody]Encyclopedia encyclopedia)
        {
            if (encyclopedia.EncyclopediaId == Guid.Empty) encyclopedia.EncyclopediaId = Guid.NewGuid();
            this.OnBeforePut(encyclopedia);
            this.SDM.Upsert(encyclopedia);
            this.OnAfterPut(encyclopedia);
            return encyclopedia;
        }

        // POST api/Encyclopedias/{encyclopedia-guid}
        public void Delete(Guid encyclopediaId)
        {
            var encyclopediaWhere = String.Format("EncyclopediaId = '{0}'", encyclopediaId);
            var encyclopedia = this.SDM.GetAllEncyclopedias<Encyclopedia>(encyclopediaWhere).FirstOrDefault();
            this.OnBeforeDelete(encyclopedia);
            this.SDM.Delete(encyclopedia);
            this.OnAfterDelete(encyclopedia);
        }
    }
}
