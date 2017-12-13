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
    public partial class ExamplesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Example> Examples);
        partial void OnAfterGetById(Example Examples, Guid exampleId);
        partial void OnBeforePost(Example example);
        partial void OnAfterPost(Example example);
        partial void OnBeforePut(Example example);
        partial void OnAfterPut(Example example);
        partial void OnBeforeDelete(Example example);
        partial void OnAfterDelete(Example example);
        

        public ExamplesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Example
        public IEnumerable<Example> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllExamples<Example>();
            Example.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Examples/{example-guid}
        public Example Get(Guid exampleId)
        {
            var ExamplesWhere = String.Format("ExampleId = '{0}'", exampleId);
            var result = this.SDM.GetAllExamples<Example>(ExamplesWhere).FirstOrDefault();
            this.OnAfterGetById(result, exampleId);
            return result;
        }

        // POST api/Examples/{example-guid}
        public Example Post([FromBody]Example example)
        {
            if (example.ExampleId == Guid.Empty) example.ExampleId = Guid.NewGuid();
            this.OnBeforePost(example);
            this.SDM.Upsert(example);
            this.OnAfterPost(example);
            return example;
        }

        // POST api/Examples/{example-guid}
        public Example Put([FromBody]Example example)
        {
            if (example.ExampleId == Guid.Empty) example.ExampleId = Guid.NewGuid();
            this.OnBeforePut(example);
            this.SDM.Upsert(example);
            this.OnAfterPut(example);
            return example;
        }

        // POST api/Examples/{example-guid}
        public void Delete(Guid exampleId)
        {
            var exampleWhere = String.Format("ExampleId = '{0}'", exampleId);
            var example = this.SDM.GetAllExamples<Example>(exampleWhere).FirstOrDefault();
            this.OnBeforeDelete(example);
            this.SDM.Delete(example);
            this.OnAfterDelete(example);
        }
    }
}
