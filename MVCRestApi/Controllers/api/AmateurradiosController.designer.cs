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
    public partial class AmateurradiosController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Amateurradio> Amateurradios);
        partial void OnAfterGetById(Amateurradio Amateurradios, Guid amateurradioId);
        partial void OnBeforePost(Amateurradio amateurradio);
        partial void OnAfterPost(Amateurradio amateurradio);
        partial void OnBeforePut(Amateurradio amateurradio);
        partial void OnAfterPut(Amateurradio amateurradio);
        partial void OnBeforeDelete(Amateurradio amateurradio);
        partial void OnAfterDelete(Amateurradio amateurradio);
        

        public AmateurradiosController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Amateurradio
        public IEnumerable<Amateurradio> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllAmateurradios<Amateurradio>();
            Amateurradio.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Amateurradios/{amateurradio-guid}
        public Amateurradio Get(Guid amateurradioId)
        {
            var AmateurradiosWhere = String.Format("AmateurradioId = '{0}'", amateurradioId);
            var result = this.SDM.GetAllAmateurradios<Amateurradio>(AmateurradiosWhere).FirstOrDefault();
            this.OnAfterGetById(result, amateurradioId);
            return result;
        }

        // POST api/Amateurradios/{amateurradio-guid}
        public Amateurradio Post([FromBody]Amateurradio amateurradio)
        {
            if (amateurradio.AmateurradioId == Guid.Empty) amateurradio.AmateurradioId = Guid.NewGuid();
            this.OnBeforePost(amateurradio);
            this.SDM.Upsert(amateurradio);
            this.OnAfterPost(amateurradio);
            return amateurradio;
        }

        // POST api/Amateurradios/{amateurradio-guid}
        public Amateurradio Put([FromBody]Amateurradio amateurradio)
        {
            if (amateurradio.AmateurradioId == Guid.Empty) amateurradio.AmateurradioId = Guid.NewGuid();
            this.OnBeforePut(amateurradio);
            this.SDM.Upsert(amateurradio);
            this.OnAfterPut(amateurradio);
            return amateurradio;
        }

        // POST api/Amateurradios/{amateurradio-guid}
        public void Delete(Guid amateurradioId)
        {
            var amateurradioWhere = String.Format("AmateurradioId = '{0}'", amateurradioId);
            var amateurradio = this.SDM.GetAllAmateurradios<Amateurradio>(amateurradioWhere).FirstOrDefault();
            this.OnBeforeDelete(amateurradio);
            this.SDM.Delete(amateurradio);
            this.OnAfterDelete(amateurradio);
        }
    }
}
