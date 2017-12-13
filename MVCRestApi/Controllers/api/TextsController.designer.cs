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
    public partial class TextsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Text> Texts);
        partial void OnAfterGetById(Text Texts, Guid textId);
        partial void OnBeforePost(Text text);
        partial void OnAfterPost(Text text);
        partial void OnBeforePut(Text text);
        partial void OnAfterPut(Text text);
        partial void OnBeforeDelete(Text text);
        partial void OnAfterDelete(Text text);
        

        public TextsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Text
        public IEnumerable<Text> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllTexts<Text>();
            Text.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Texts/{text-guid}
        public Text Get(Guid textId)
        {
            var TextsWhere = String.Format("TextId = '{0}'", textId);
            var result = this.SDM.GetAllTexts<Text>(TextsWhere).FirstOrDefault();
            this.OnAfterGetById(result, textId);
            return result;
        }

        // POST api/Texts/{text-guid}
        public Text Post([FromBody]Text text)
        {
            if (text.TextId == Guid.Empty) text.TextId = Guid.NewGuid();
            this.OnBeforePost(text);
            this.SDM.Upsert(text);
            this.OnAfterPost(text);
            return text;
        }

        // POST api/Texts/{text-guid}
        public Text Put([FromBody]Text text)
        {
            if (text.TextId == Guid.Empty) text.TextId = Guid.NewGuid();
            this.OnBeforePut(text);
            this.SDM.Upsert(text);
            this.OnAfterPut(text);
            return text;
        }

        // POST api/Texts/{text-guid}
        public void Delete(Guid textId)
        {
            var textWhere = String.Format("TextId = '{0}'", textId);
            var text = this.SDM.GetAllTexts<Text>(textWhere).FirstOrDefault();
            this.OnBeforeDelete(text);
            this.SDM.Delete(text);
            this.OnAfterDelete(text);
        }
    }
}
