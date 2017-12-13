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
    public partial class MethodsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Method> Methods);
        partial void OnAfterGetById(Method Methods, Guid methodId);
        partial void OnBeforePost(Method method);
        partial void OnAfterPost(Method method);
        partial void OnBeforePut(Method method);
        partial void OnAfterPut(Method method);
        partial void OnBeforeDelete(Method method);
        partial void OnAfterDelete(Method method);
        

        public MethodsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Method
        public IEnumerable<Method> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllMethods<Method>();
            Method.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Methods/{method-guid}
        public Method Get(Guid methodId)
        {
            var MethodsWhere = String.Format("MethodId = '{0}'", methodId);
            var result = this.SDM.GetAllMethods<Method>(MethodsWhere).FirstOrDefault();
            this.OnAfterGetById(result, methodId);
            return result;
        }

        // POST api/Methods/{method-guid}
        public Method Post([FromBody]Method method)
        {
            if (method.MethodId == Guid.Empty) method.MethodId = Guid.NewGuid();
            this.OnBeforePost(method);
            this.SDM.Upsert(method);
            this.OnAfterPost(method);
            return method;
        }

        // POST api/Methods/{method-guid}
        public Method Put([FromBody]Method method)
        {
            if (method.MethodId == Guid.Empty) method.MethodId = Guid.NewGuid();
            this.OnBeforePut(method);
            this.SDM.Upsert(method);
            this.OnAfterPut(method);
            return method;
        }

        // POST api/Methods/{method-guid}
        public void Delete(Guid methodId)
        {
            var methodWhere = String.Format("MethodId = '{0}'", methodId);
            var method = this.SDM.GetAllMethods<Method>(methodWhere).FirstOrDefault();
            this.OnBeforeDelete(method);
            this.SDM.Delete(method);
            this.OnAfterDelete(method);
        }
    }
}
