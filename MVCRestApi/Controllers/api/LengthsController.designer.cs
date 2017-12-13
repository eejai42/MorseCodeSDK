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
    public partial class LengthsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Length> Lengths);
        partial void OnAfterGetById(Length Lengths, Guid lengthId);
        partial void OnBeforePost(Length length);
        partial void OnAfterPost(Length length);
        partial void OnBeforePut(Length length);
        partial void OnAfterPut(Length length);
        partial void OnBeforeDelete(Length length);
        partial void OnAfterDelete(Length length);
        

        public LengthsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Length
        public IEnumerable<Length> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllLengths<Length>();
            Length.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Lengths/{length-guid}
        public Length Get(Guid lengthId)
        {
            var LengthsWhere = String.Format("LengthId = '{0}'", lengthId);
            var result = this.SDM.GetAllLengths<Length>(LengthsWhere).FirstOrDefault();
            this.OnAfterGetById(result, lengthId);
            return result;
        }

        // POST api/Lengths/{length-guid}
        public Length Post([FromBody]Length length)
        {
            if (length.LengthId == Guid.Empty) length.LengthId = Guid.NewGuid();
            this.OnBeforePost(length);
            this.SDM.Upsert(length);
            this.OnAfterPost(length);
            return length;
        }

        // POST api/Lengths/{length-guid}
        public Length Put([FromBody]Length length)
        {
            if (length.LengthId == Guid.Empty) length.LengthId = Guid.NewGuid();
            this.OnBeforePut(length);
            this.SDM.Upsert(length);
            this.OnAfterPut(length);
            return length;
        }

        // POST api/Lengths/{length-guid}
        public void Delete(Guid lengthId)
        {
            var lengthWhere = String.Format("LengthId = '{0}'", lengthId);
            var length = this.SDM.GetAllLengths<Length>(lengthWhere).FirstOrDefault();
            this.OnBeforeDelete(length);
            this.SDM.Delete(length);
            this.OnAfterDelete(length);
        }
    }
}
