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
    public partial class AlphabetsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Alphabet> Alphabets);
        partial void OnAfterGetById(Alphabet Alphabets, Guid alphabetId);
        partial void OnBeforePost(Alphabet alphabet);
        partial void OnAfterPost(Alphabet alphabet);
        partial void OnBeforePut(Alphabet alphabet);
        partial void OnAfterPut(Alphabet alphabet);
        partial void OnBeforeDelete(Alphabet alphabet);
        partial void OnAfterDelete(Alphabet alphabet);
        

        public AlphabetsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Alphabet
        public IEnumerable<Alphabet> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllAlphabets<Alphabet>();
            Alphabet.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Alphabets/{alphabet-guid}
        public Alphabet Get(Guid alphabetId)
        {
            var AlphabetsWhere = String.Format("AlphabetId = '{0}'", alphabetId);
            var result = this.SDM.GetAllAlphabets<Alphabet>(AlphabetsWhere).FirstOrDefault();
            this.OnAfterGetById(result, alphabetId);
            return result;
        }

        // POST api/Alphabets/{alphabet-guid}
        public Alphabet Post([FromBody]Alphabet alphabet)
        {
            if (alphabet.AlphabetId == Guid.Empty) alphabet.AlphabetId = Guid.NewGuid();
            this.OnBeforePost(alphabet);
            this.SDM.Upsert(alphabet);
            this.OnAfterPost(alphabet);
            return alphabet;
        }

        // POST api/Alphabets/{alphabet-guid}
        public Alphabet Put([FromBody]Alphabet alphabet)
        {
            if (alphabet.AlphabetId == Guid.Empty) alphabet.AlphabetId = Guid.NewGuid();
            this.OnBeforePut(alphabet);
            this.SDM.Upsert(alphabet);
            this.OnAfterPut(alphabet);
            return alphabet;
        }

        // POST api/Alphabets/{alphabet-guid}
        public void Delete(Guid alphabetId)
        {
            var alphabetWhere = String.Format("AlphabetId = '{0}'", alphabetId);
            var alphabet = this.SDM.GetAllAlphabets<Alphabet>(alphabetWhere).FirstOrDefault();
            this.OnBeforeDelete(alphabet);
            this.SDM.Delete(alphabet);
            this.OnAfterDelete(alphabet);
        }
    }
}
