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
    public partial class DecodingsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Decoding> Decodings);
        partial void OnAfterGetById(Decoding Decodings, Guid decodingId);
        partial void OnBeforePost(Decoding decoding);
        partial void OnAfterPost(Decoding decoding);
        partial void OnBeforePut(Decoding decoding);
        partial void OnAfterPut(Decoding decoding);
        partial void OnBeforeDelete(Decoding decoding);
        partial void OnAfterDelete(Decoding decoding);
        

        public DecodingsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Decoding
        public IEnumerable<Decoding> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllDecodings<Decoding>();
            Decoding.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Decodings/{decoding-guid}
        public Decoding Get(Guid decodingId)
        {
            var DecodingsWhere = String.Format("DecodingId = '{0}'", decodingId);
            var result = this.SDM.GetAllDecodings<Decoding>(DecodingsWhere).FirstOrDefault();
            this.OnAfterGetById(result, decodingId);
            return result;
        }

        // POST api/Decodings/{decoding-guid}
        public Decoding Post([FromBody]Decoding decoding)
        {
            if (decoding.DecodingId == Guid.Empty) decoding.DecodingId = Guid.NewGuid();
            this.OnBeforePost(decoding);
            this.SDM.Upsert(decoding);
            this.OnAfterPost(decoding);
            return decoding;
        }

        // POST api/Decodings/{decoding-guid}
        public Decoding Put([FromBody]Decoding decoding)
        {
            if (decoding.DecodingId == Guid.Empty) decoding.DecodingId = Guid.NewGuid();
            this.OnBeforePut(decoding);
            this.SDM.Upsert(decoding);
            this.OnAfterPut(decoding);
            return decoding;
        }

        // POST api/Decodings/{decoding-guid}
        public void Delete(Guid decodingId)
        {
            var decodingWhere = String.Format("DecodingId = '{0}'", decodingId);
            var decoding = this.SDM.GetAllDecodings<Decoding>(decodingWhere).FirstOrDefault();
            this.OnBeforeDelete(decoding);
            this.SDM.Delete(decoding);
            this.OnAfterDelete(decoding);
        }
    }
}
