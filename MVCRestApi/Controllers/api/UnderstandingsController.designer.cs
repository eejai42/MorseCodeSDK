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
    public partial class UnderstandingsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Understanding> Understandings);
        partial void OnAfterGetById(Understanding Understandings, Guid understandingId);
        partial void OnBeforePost(Understanding understanding);
        partial void OnAfterPost(Understanding understanding);
        partial void OnBeforePut(Understanding understanding);
        partial void OnAfterPut(Understanding understanding);
        partial void OnBeforeDelete(Understanding understanding);
        partial void OnAfterDelete(Understanding understanding);
        

        public UnderstandingsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Understanding
        public IEnumerable<Understanding> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllUnderstandings<Understanding>();
            Understanding.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Understandings/{understanding-guid}
        public Understanding Get(Guid understandingId)
        {
            var UnderstandingsWhere = String.Format("UnderstandingId = '{0}'", understandingId);
            var result = this.SDM.GetAllUnderstandings<Understanding>(UnderstandingsWhere).FirstOrDefault();
            this.OnAfterGetById(result, understandingId);
            return result;
        }

        // POST api/Understandings/{understanding-guid}
        public Understanding Post([FromBody]Understanding understanding)
        {
            if (understanding.UnderstandingId == Guid.Empty) understanding.UnderstandingId = Guid.NewGuid();
            this.OnBeforePost(understanding);
            this.SDM.Upsert(understanding);
            this.OnAfterPost(understanding);
            return understanding;
        }

        // POST api/Understandings/{understanding-guid}
        public Understanding Put([FromBody]Understanding understanding)
        {
            if (understanding.UnderstandingId == Guid.Empty) understanding.UnderstandingId = Guid.NewGuid();
            this.OnBeforePut(understanding);
            this.SDM.Upsert(understanding);
            this.OnAfterPut(understanding);
            return understanding;
        }

        // POST api/Understandings/{understanding-guid}
        public void Delete(Guid understandingId)
        {
            var understandingWhere = String.Format("UnderstandingId = '{0}'", understandingId);
            var understanding = this.SDM.GetAllUnderstandings<Understanding>(understandingWhere).FirstOrDefault();
            this.OnBeforeDelete(understanding);
            this.SDM.Delete(understanding);
            this.OnAfterDelete(understanding);
        }
    }
}
