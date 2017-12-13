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
    public partial class SearchsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Search> Searchs);
        partial void OnAfterGetById(Search Searchs, Guid searchId);
        partial void OnBeforePost(Search search);
        partial void OnAfterPost(Search search);
        partial void OnBeforePut(Search search);
        partial void OnAfterPut(Search search);
        partial void OnBeforeDelete(Search search);
        partial void OnAfterDelete(Search search);
        

        public SearchsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Search
        public IEnumerable<Search> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSearchs<Search>();
            Search.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Searchs/{search-guid}
        public Search Get(Guid searchId)
        {
            var SearchsWhere = String.Format("SearchId = '{0}'", searchId);
            var result = this.SDM.GetAllSearchs<Search>(SearchsWhere).FirstOrDefault();
            this.OnAfterGetById(result, searchId);
            return result;
        }

        // POST api/Searchs/{search-guid}
        public Search Post([FromBody]Search search)
        {
            if (search.SearchId == Guid.Empty) search.SearchId = Guid.NewGuid();
            this.OnBeforePost(search);
            this.SDM.Upsert(search);
            this.OnAfterPost(search);
            return search;
        }

        // POST api/Searchs/{search-guid}
        public Search Put([FromBody]Search search)
        {
            if (search.SearchId == Guid.Empty) search.SearchId = Guid.NewGuid();
            this.OnBeforePut(search);
            this.SDM.Upsert(search);
            this.OnAfterPut(search);
            return search;
        }

        // POST api/Searchs/{search-guid}
        public void Delete(Guid searchId)
        {
            var searchWhere = String.Format("SearchId = '{0}'", searchId);
            var search = this.SDM.GetAllSearchs<Search>(searchWhere).FirstOrDefault();
            this.OnBeforeDelete(search);
            this.SDM.Delete(search);
            this.OnAfterDelete(search);
        }
    }
}
