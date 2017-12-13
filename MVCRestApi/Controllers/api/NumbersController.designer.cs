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
    public partial class NumbersController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Number> Numbers);
        partial void OnAfterGetById(Number Numbers, Guid numberId);
        partial void OnBeforePost(Number number);
        partial void OnAfterPost(Number number);
        partial void OnBeforePut(Number number);
        partial void OnAfterPut(Number number);
        partial void OnBeforeDelete(Number number);
        partial void OnAfterDelete(Number number);
        

        public NumbersController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Number
        public IEnumerable<Number> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllNumbers<Number>();
            Number.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Numbers/{number-guid}
        public Number Get(Guid numberId)
        {
            var NumbersWhere = String.Format("NumberId = '{0}'", numberId);
            var result = this.SDM.GetAllNumbers<Number>(NumbersWhere).FirstOrDefault();
            this.OnAfterGetById(result, numberId);
            return result;
        }

        // POST api/Numbers/{number-guid}
        public Number Post([FromBody]Number number)
        {
            if (number.NumberId == Guid.Empty) number.NumberId = Guid.NewGuid();
            this.OnBeforePost(number);
            this.SDM.Upsert(number);
            this.OnAfterPost(number);
            return number;
        }

        // POST api/Numbers/{number-guid}
        public Number Put([FromBody]Number number)
        {
            if (number.NumberId == Guid.Empty) number.NumberId = Guid.NewGuid();
            this.OnBeforePut(number);
            this.SDM.Upsert(number);
            this.OnAfterPut(number);
            return number;
        }

        // POST api/Numbers/{number-guid}
        public void Delete(Guid numberId)
        {
            var numberWhere = String.Format("NumberId = '{0}'", numberId);
            var number = this.SDM.GetAllNumbers<Number>(numberWhere).FirstOrDefault();
            this.OnBeforeDelete(number);
            this.SDM.Delete(number);
            this.OnAfterDelete(number);
        }
    }
}
