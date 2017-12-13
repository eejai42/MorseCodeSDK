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
    public partial class PunctuationsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Punctuation> Punctuations);
        partial void OnAfterGetById(Punctuation Punctuations, Guid punctuationId);
        partial void OnBeforePost(Punctuation punctuation);
        partial void OnAfterPost(Punctuation punctuation);
        partial void OnBeforePut(Punctuation punctuation);
        partial void OnAfterPut(Punctuation punctuation);
        partial void OnBeforeDelete(Punctuation punctuation);
        partial void OnAfterDelete(Punctuation punctuation);
        

        public PunctuationsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Punctuation
        public IEnumerable<Punctuation> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllPunctuations<Punctuation>();
            Punctuation.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Punctuations/{punctuation-guid}
        public Punctuation Get(Guid punctuationId)
        {
            var PunctuationsWhere = String.Format("PunctuationId = '{0}'", punctuationId);
            var result = this.SDM.GetAllPunctuations<Punctuation>(PunctuationsWhere).FirstOrDefault();
            this.OnAfterGetById(result, punctuationId);
            return result;
        }

        // POST api/Punctuations/{punctuation-guid}
        public Punctuation Post([FromBody]Punctuation punctuation)
        {
            if (punctuation.PunctuationId == Guid.Empty) punctuation.PunctuationId = Guid.NewGuid();
            this.OnBeforePost(punctuation);
            this.SDM.Upsert(punctuation);
            this.OnAfterPost(punctuation);
            return punctuation;
        }

        // POST api/Punctuations/{punctuation-guid}
        public Punctuation Put([FromBody]Punctuation punctuation)
        {
            if (punctuation.PunctuationId == Guid.Empty) punctuation.PunctuationId = Guid.NewGuid();
            this.OnBeforePut(punctuation);
            this.SDM.Upsert(punctuation);
            this.OnAfterPut(punctuation);
            return punctuation;
        }

        // POST api/Punctuations/{punctuation-guid}
        public void Delete(Guid punctuationId)
        {
            var punctuationWhere = String.Format("PunctuationId = '{0}'", punctuationId);
            var punctuation = this.SDM.GetAllPunctuations<Punctuation>(punctuationWhere).FirstOrDefault();
            this.OnBeforeDelete(punctuation);
            this.SDM.Delete(punctuation);
            this.OnAfterDelete(punctuation);
        }
    }
}
