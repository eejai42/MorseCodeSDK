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
    public partial class WikipediasController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Wikipedia> Wikipedias);
        partial void OnAfterGetById(Wikipedia Wikipedias, Guid wikipediaId);
        partial void OnBeforePost(Wikipedia wikipedia);
        partial void OnAfterPost(Wikipedia wikipedia);
        partial void OnBeforePut(Wikipedia wikipedia);
        partial void OnAfterPut(Wikipedia wikipedia);
        partial void OnBeforeDelete(Wikipedia wikipedia);
        partial void OnAfterDelete(Wikipedia wikipedia);
        

        public WikipediasController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Wikipedia
        public IEnumerable<Wikipedia> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllWikipedias<Wikipedia>();
            Wikipedia.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Wikipedias/{wikipedia-guid}
        public Wikipedia Get(Guid wikipediaId)
        {
            var WikipediasWhere = String.Format("WikipediaId = '{0}'", wikipediaId);
            var result = this.SDM.GetAllWikipedias<Wikipedia>(WikipediasWhere).FirstOrDefault();
            this.OnAfterGetById(result, wikipediaId);
            return result;
        }

        // POST api/Wikipedias/{wikipedia-guid}
        public Wikipedia Post([FromBody]Wikipedia wikipedia)
        {
            if (wikipedia.WikipediaId == Guid.Empty) wikipedia.WikipediaId = Guid.NewGuid();
            this.OnBeforePost(wikipedia);
            this.SDM.Upsert(wikipedia);
            this.OnAfterPost(wikipedia);
            return wikipedia;
        }

        // POST api/Wikipedias/{wikipedia-guid}
        public Wikipedia Put([FromBody]Wikipedia wikipedia)
        {
            if (wikipedia.WikipediaId == Guid.Empty) wikipedia.WikipediaId = Guid.NewGuid();
            this.OnBeforePut(wikipedia);
            this.SDM.Upsert(wikipedia);
            this.OnAfterPut(wikipedia);
            return wikipedia;
        }

        // POST api/Wikipedias/{wikipedia-guid}
        public void Delete(Guid wikipediaId)
        {
            var wikipediaWhere = String.Format("WikipediaId = '{0}'", wikipediaId);
            var wikipedia = this.SDM.GetAllWikipedias<Wikipedia>(wikipediaWhere).FirstOrDefault();
            this.OnBeforeDelete(wikipedia);
            this.SDM.Delete(wikipedia);
            this.OnAfterDelete(wikipedia);
        }
    }
}
