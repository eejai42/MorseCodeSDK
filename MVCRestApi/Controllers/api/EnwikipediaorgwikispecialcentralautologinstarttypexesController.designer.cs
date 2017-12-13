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
    public partial class EnwikipediaorgwikispecialcentralautologinstarttypexesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Enwikipediaorgwikispecialcentralautologinstarttypex> Enwikipediaorgwikispecialcentralautologinstarttypexes);
        partial void OnAfterGetById(Enwikipediaorgwikispecialcentralautologinstarttypex Enwikipediaorgwikispecialcentralautologinstarttypexes, Guid enwikipediaorgwikispecialcentralautologinstarttypexId);
        partial void OnBeforePost(Enwikipediaorgwikispecialcentralautologinstarttypex enwikipediaorgwikispecialcentralautologinstarttypex);
        partial void OnAfterPost(Enwikipediaorgwikispecialcentralautologinstarttypex enwikipediaorgwikispecialcentralautologinstarttypex);
        partial void OnBeforePut(Enwikipediaorgwikispecialcentralautologinstarttypex enwikipediaorgwikispecialcentralautologinstarttypex);
        partial void OnAfterPut(Enwikipediaorgwikispecialcentralautologinstarttypex enwikipediaorgwikispecialcentralautologinstarttypex);
        partial void OnBeforeDelete(Enwikipediaorgwikispecialcentralautologinstarttypex enwikipediaorgwikispecialcentralautologinstarttypex);
        partial void OnAfterDelete(Enwikipediaorgwikispecialcentralautologinstarttypex enwikipediaorgwikispecialcentralautologinstarttypex);
        

        public EnwikipediaorgwikispecialcentralautologinstarttypexesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Enwikipediaorgwikispecialcentralautologinstarttypex
        public IEnumerable<Enwikipediaorgwikispecialcentralautologinstarttypex> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllEnwikipediaorgwikispecialcentralautologinstarttypexes<Enwikipediaorgwikispecialcentralautologinstarttypex>();
            Enwikipediaorgwikispecialcentralautologinstarttypex.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Enwikipediaorgwikispecialcentralautologinstarttypexes/{enwikipediaorgwikispecialcentralautologinstarttypex-guid}
        public Enwikipediaorgwikispecialcentralautologinstarttypex Get(Guid enwikipediaorgwikispecialcentralautologinstarttypexId)
        {
            var EnwikipediaorgwikispecialcentralautologinstarttypexesWhere = String.Format("EnwikipediaorgwikispecialcentralautologinstarttypexId = '{0}'", enwikipediaorgwikispecialcentralautologinstarttypexId);
            var result = this.SDM.GetAllEnwikipediaorgwikispecialcentralautologinstarttypexes<Enwikipediaorgwikispecialcentralautologinstarttypex>(EnwikipediaorgwikispecialcentralautologinstarttypexesWhere).FirstOrDefault();
            this.OnAfterGetById(result, enwikipediaorgwikispecialcentralautologinstarttypexId);
            return result;
        }

        // POST api/Enwikipediaorgwikispecialcentralautologinstarttypexes/{enwikipediaorgwikispecialcentralautologinstarttypex-guid}
        public Enwikipediaorgwikispecialcentralautologinstarttypex Post([FromBody]Enwikipediaorgwikispecialcentralautologinstarttypex enwikipediaorgwikispecialcentralautologinstarttypex)
        {
            if (enwikipediaorgwikispecialcentralautologinstarttypex.EnwikipediaorgwikispecialcentralautologinstarttypexId == Guid.Empty) enwikipediaorgwikispecialcentralautologinstarttypex.EnwikipediaorgwikispecialcentralautologinstarttypexId = Guid.NewGuid();
            this.OnBeforePost(enwikipediaorgwikispecialcentralautologinstarttypex);
            this.SDM.Upsert(enwikipediaorgwikispecialcentralautologinstarttypex);
            this.OnAfterPost(enwikipediaorgwikispecialcentralautologinstarttypex);
            return enwikipediaorgwikispecialcentralautologinstarttypex;
        }

        // POST api/Enwikipediaorgwikispecialcentralautologinstarttypexes/{enwikipediaorgwikispecialcentralautologinstarttypex-guid}
        public Enwikipediaorgwikispecialcentralautologinstarttypex Put([FromBody]Enwikipediaorgwikispecialcentralautologinstarttypex enwikipediaorgwikispecialcentralautologinstarttypex)
        {
            if (enwikipediaorgwikispecialcentralautologinstarttypex.EnwikipediaorgwikispecialcentralautologinstarttypexId == Guid.Empty) enwikipediaorgwikispecialcentralautologinstarttypex.EnwikipediaorgwikispecialcentralautologinstarttypexId = Guid.NewGuid();
            this.OnBeforePut(enwikipediaorgwikispecialcentralautologinstarttypex);
            this.SDM.Upsert(enwikipediaorgwikispecialcentralautologinstarttypex);
            this.OnAfterPut(enwikipediaorgwikispecialcentralautologinstarttypex);
            return enwikipediaorgwikispecialcentralautologinstarttypex;
        }

        // POST api/Enwikipediaorgwikispecialcentralautologinstarttypexes/{enwikipediaorgwikispecialcentralautologinstarttypex-guid}
        public void Delete(Guid enwikipediaorgwikispecialcentralautologinstarttypexId)
        {
            var enwikipediaorgwikispecialcentralautologinstarttypexWhere = String.Format("EnwikipediaorgwikispecialcentralautologinstarttypexId = '{0}'", enwikipediaorgwikispecialcentralautologinstarttypexId);
            var enwikipediaorgwikispecialcentralautologinstarttypex = this.SDM.GetAllEnwikipediaorgwikispecialcentralautologinstarttypexes<Enwikipediaorgwikispecialcentralautologinstarttypex>(enwikipediaorgwikispecialcentralautologinstarttypexWhere).FirstOrDefault();
            this.OnBeforeDelete(enwikipediaorgwikispecialcentralautologinstarttypex);
            this.SDM.Delete(enwikipediaorgwikispecialcentralautologinstarttypex);
            this.OnAfterDelete(enwikipediaorgwikispecialcentralautologinstarttypex);
        }
    }
}
