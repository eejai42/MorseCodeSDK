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
    public partial class EntropyencodingsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Entropyencoding> Entropyencodings);
        partial void OnAfterGetById(Entropyencoding Entropyencodings, Guid entropyencodingId);
        partial void OnBeforePost(Entropyencoding entropyencoding);
        partial void OnAfterPost(Entropyencoding entropyencoding);
        partial void OnBeforePut(Entropyencoding entropyencoding);
        partial void OnAfterPut(Entropyencoding entropyencoding);
        partial void OnBeforeDelete(Entropyencoding entropyencoding);
        partial void OnAfterDelete(Entropyencoding entropyencoding);
        

        public EntropyencodingsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Entropyencoding
        public IEnumerable<Entropyencoding> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllEntropyencodings<Entropyencoding>();
            Entropyencoding.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Entropyencodings/{entropyencoding-guid}
        public Entropyencoding Get(Guid entropyencodingId)
        {
            var EntropyencodingsWhere = String.Format("EntropyencodingId = '{0}'", entropyencodingId);
            var result = this.SDM.GetAllEntropyencodings<Entropyencoding>(EntropyencodingsWhere).FirstOrDefault();
            this.OnAfterGetById(result, entropyencodingId);
            return result;
        }

        // POST api/Entropyencodings/{entropyencoding-guid}
        public Entropyencoding Post([FromBody]Entropyencoding entropyencoding)
        {
            if (entropyencoding.EntropyencodingId == Guid.Empty) entropyencoding.EntropyencodingId = Guid.NewGuid();
            this.OnBeforePost(entropyencoding);
            this.SDM.Upsert(entropyencoding);
            this.OnAfterPost(entropyencoding);
            return entropyencoding;
        }

        // POST api/Entropyencodings/{entropyencoding-guid}
        public Entropyencoding Put([FromBody]Entropyencoding entropyencoding)
        {
            if (entropyencoding.EntropyencodingId == Guid.Empty) entropyencoding.EntropyencodingId = Guid.NewGuid();
            this.OnBeforePut(entropyencoding);
            this.SDM.Upsert(entropyencoding);
            this.OnAfterPut(entropyencoding);
            return entropyencoding;
        }

        // POST api/Entropyencodings/{entropyencoding-guid}
        public void Delete(Guid entropyencodingId)
        {
            var entropyencodingWhere = String.Format("EntropyencodingId = '{0}'", entropyencodingId);
            var entropyencoding = this.SDM.GetAllEntropyencodings<Entropyencoding>(entropyencodingWhere).FirstOrDefault();
            this.OnBeforeDelete(entropyencoding);
            this.SDM.Delete(entropyencoding);
            this.OnAfterDelete(entropyencoding);
        }
    }
}
