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
    public partial class LettersController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Letter> Letters);
        partial void OnAfterGetById(Letter Letters, Guid letterId);
        partial void OnBeforePost(Letter letter);
        partial void OnAfterPost(Letter letter);
        partial void OnBeforePut(Letter letter);
        partial void OnAfterPut(Letter letter);
        partial void OnBeforeDelete(Letter letter);
        partial void OnAfterDelete(Letter letter);
        

        public LettersController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Letter
        public IEnumerable<Letter> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllLetters<Letter>();
            Letter.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Letters/{letter-guid}
        public Letter Get(Guid letterId)
        {
            var LettersWhere = String.Format("LetterId = '{0}'", letterId);
            var result = this.SDM.GetAllLetters<Letter>(LettersWhere).FirstOrDefault();
            this.OnAfterGetById(result, letterId);
            return result;
        }

        // POST api/Letters/{letter-guid}
        public Letter Post([FromBody]Letter letter)
        {
            if (letter.LetterId == Guid.Empty) letter.LetterId = Guid.NewGuid();
            this.OnBeforePost(letter);
            this.SDM.Upsert(letter);
            this.OnAfterPost(letter);
            return letter;
        }

        // POST api/Letters/{letter-guid}
        public Letter Put([FromBody]Letter letter)
        {
            if (letter.LetterId == Guid.Empty) letter.LetterId = Guid.NewGuid();
            this.OnBeforePut(letter);
            this.SDM.Upsert(letter);
            this.OnAfterPut(letter);
            return letter;
        }

        // POST api/Letters/{letter-guid}
        public void Delete(Guid letterId)
        {
            var letterWhere = String.Format("LetterId = '{0}'", letterId);
            var letter = this.SDM.GetAllLetters<Letter>(letterWhere).FirstOrDefault();
            this.OnBeforeDelete(letter);
            this.SDM.Delete(letter);
            this.OnAfterDelete(letter);
        }
    }
}
