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
    public partial class LanguagesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Language> Languages);
        partial void OnAfterGetById(Language Languages, Guid languageId);
        partial void OnBeforePost(Language language);
        partial void OnAfterPost(Language language);
        partial void OnBeforePut(Language language);
        partial void OnAfterPut(Language language);
        partial void OnBeforeDelete(Language language);
        partial void OnAfterDelete(Language language);
        

        public LanguagesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Language
        public IEnumerable<Language> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllLanguages<Language>();
            Language.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Languages/{language-guid}
        public Language Get(Guid languageId)
        {
            var LanguagesWhere = String.Format("LanguageId = '{0}'", languageId);
            var result = this.SDM.GetAllLanguages<Language>(LanguagesWhere).FirstOrDefault();
            this.OnAfterGetById(result, languageId);
            return result;
        }

        // POST api/Languages/{language-guid}
        public Language Post([FromBody]Language language)
        {
            if (language.LanguageId == Guid.Empty) language.LanguageId = Guid.NewGuid();
            this.OnBeforePost(language);
            this.SDM.Upsert(language);
            this.OnAfterPost(language);
            return language;
        }

        // POST api/Languages/{language-guid}
        public Language Put([FromBody]Language language)
        {
            if (language.LanguageId == Guid.Empty) language.LanguageId = Guid.NewGuid();
            this.OnBeforePut(language);
            this.SDM.Upsert(language);
            this.OnAfterPut(language);
            return language;
        }

        // POST api/Languages/{language-guid}
        public void Delete(Guid languageId)
        {
            var languageWhere = String.Format("LanguageId = '{0}'", languageId);
            var language = this.SDM.GetAllLanguages<Language>(languageWhere).FirstOrDefault();
            this.OnBeforeDelete(language);
            this.SDM.Delete(language);
            this.OnAfterDelete(language);
        }
    }
}
