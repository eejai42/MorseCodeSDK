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
    public partial class CodesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Code> Codes);
        partial void OnAfterGetById(Code Codes, Guid codeId);
        partial void OnBeforePost(Code code);
        partial void OnAfterPost(Code code);
        partial void OnBeforePut(Code code);
        partial void OnAfterPut(Code code);
        partial void OnBeforeDelete(Code code);
        partial void OnAfterDelete(Code code);
        

        public CodesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Code
        public IEnumerable<Code> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllCodes<Code>();
            Code.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Codes/{code-guid}
        public Code Get(Guid codeId)
        {
            var CodesWhere = String.Format("CodeId = '{0}'", codeId);
            var result = this.SDM.GetAllCodes<Code>(CodesWhere).FirstOrDefault();
            this.OnAfterGetById(result, codeId);
            return result;
        }

        // POST api/Codes/{code-guid}
        public Code Post([FromBody]Code code)
        {
            if (code.CodeId == Guid.Empty) code.CodeId = Guid.NewGuid();
            this.OnBeforePost(code);
            this.SDM.Upsert(code);
            this.OnAfterPost(code);
            return code;
        }

        // POST api/Codes/{code-guid}
        public Code Put([FromBody]Code code)
        {
            if (code.CodeId == Guid.Empty) code.CodeId = Guid.NewGuid();
            this.OnBeforePut(code);
            this.SDM.Upsert(code);
            this.OnAfterPut(code);
            return code;
        }

        // POST api/Codes/{code-guid}
        public void Delete(Guid codeId)
        {
            var codeWhere = String.Format("CodeId = '{0}'", codeId);
            var code = this.SDM.GetAllCodes<Code>(codeWhere).FirstOrDefault();
            this.OnBeforeDelete(code);
            this.SDM.Delete(code);
            this.OnAfterDelete(code);
        }
    }
}
