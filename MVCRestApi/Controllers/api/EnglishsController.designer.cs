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
    public partial class EnglishsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<English> Englishs);
        partial void OnAfterGetById(English Englishs, Guid englishId);
        partial void OnBeforePost(English english);
        partial void OnAfterPost(English english);
        partial void OnBeforePut(English english);
        partial void OnAfterPut(English english);
        partial void OnBeforeDelete(English english);
        partial void OnAfterDelete(English english);
        

        public EnglishsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/English
        public IEnumerable<English> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllEnglishs<English>();
            English.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Englishs/{english-guid}
        public English Get(Guid englishId)
        {
            var EnglishsWhere = String.Format("EnglishId = '{0}'", englishId);
            var result = this.SDM.GetAllEnglishs<English>(EnglishsWhere).FirstOrDefault();
            this.OnAfterGetById(result, englishId);
            return result;
        }

        // POST api/Englishs/{english-guid}
        public English Post([FromBody]English english)
        {
            if (english.EnglishId == Guid.Empty) english.EnglishId = Guid.NewGuid();
            this.OnBeforePost(english);
            this.SDM.Upsert(english);
            this.OnAfterPost(english);
            return english;
        }

        // POST api/Englishs/{english-guid}
        public English Put([FromBody]English english)
        {
            if (english.EnglishId == Guid.Empty) english.EnglishId = Guid.NewGuid();
            this.OnBeforePut(english);
            this.SDM.Upsert(english);
            this.OnAfterPut(english);
            return english;
        }

        // POST api/Englishs/{english-guid}
        public void Delete(Guid englishId)
        {
            var englishWhere = String.Format("EnglishId = '{0}'", englishId);
            var english = this.SDM.GetAllEnglishs<English>(englishWhere).FirstOrDefault();
            this.OnBeforeDelete(english);
            this.SDM.Delete(english);
            this.OnAfterDelete(english);
        }
    }
}
