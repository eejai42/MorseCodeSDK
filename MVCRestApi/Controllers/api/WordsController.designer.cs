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
    public partial class WordsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Word> Words);
        partial void OnAfterGetById(Word Words, Guid wordId);
        partial void OnBeforePost(Word word);
        partial void OnAfterPost(Word word);
        partial void OnBeforePut(Word word);
        partial void OnAfterPut(Word word);
        partial void OnBeforeDelete(Word word);
        partial void OnAfterDelete(Word word);
        

        public WordsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Word
        public IEnumerable<Word> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllWords<Word>();
            Word.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Words/{word-guid}
        public Word Get(Guid wordId)
        {
            var WordsWhere = String.Format("WordId = '{0}'", wordId);
            var result = this.SDM.GetAllWords<Word>(WordsWhere).FirstOrDefault();
            this.OnAfterGetById(result, wordId);
            return result;
        }

        // POST api/Words/{word-guid}
        public Word Post([FromBody]Word word)
        {
            if (word.WordId == Guid.Empty) word.WordId = Guid.NewGuid();
            this.OnBeforePost(word);
            this.SDM.Upsert(word);
            this.OnAfterPost(word);
            return word;
        }

        // POST api/Words/{word-guid}
        public Word Put([FromBody]Word word)
        {
            if (word.WordId == Guid.Empty) word.WordId = Guid.NewGuid();
            this.OnBeforePut(word);
            this.SDM.Upsert(word);
            this.OnAfterPut(word);
            return word;
        }

        // POST api/Words/{word-guid}
        public void Delete(Guid wordId)
        {
            var wordWhere = String.Format("WordId = '{0}'", wordId);
            var word = this.SDM.GetAllWords<Word>(wordWhere).FirstOrDefault();
            this.OnBeforeDelete(word);
            this.SDM.Delete(word);
            this.OnAfterDelete(word);
        }
    }
}
