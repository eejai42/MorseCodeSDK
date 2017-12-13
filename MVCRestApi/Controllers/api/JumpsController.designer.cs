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
    public partial class JumpsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Jump> Jumps);
        partial void OnAfterGetById(Jump Jumps, Guid jumpId);
        partial void OnBeforePost(Jump jump);
        partial void OnAfterPost(Jump jump);
        partial void OnBeforePut(Jump jump);
        partial void OnAfterPut(Jump jump);
        partial void OnBeforeDelete(Jump jump);
        partial void OnAfterDelete(Jump jump);
        

        public JumpsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Jump
        public IEnumerable<Jump> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllJumps<Jump>();
            Jump.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Jumps/{jump-guid}
        public Jump Get(Guid jumpId)
        {
            var JumpsWhere = String.Format("JumpId = '{0}'", jumpId);
            var result = this.SDM.GetAllJumps<Jump>(JumpsWhere).FirstOrDefault();
            this.OnAfterGetById(result, jumpId);
            return result;
        }

        // POST api/Jumps/{jump-guid}
        public Jump Post([FromBody]Jump jump)
        {
            if (jump.JumpId == Guid.Empty) jump.JumpId = Guid.NewGuid();
            this.OnBeforePost(jump);
            this.SDM.Upsert(jump);
            this.OnAfterPost(jump);
            return jump;
        }

        // POST api/Jumps/{jump-guid}
        public Jump Put([FromBody]Jump jump)
        {
            if (jump.JumpId == Guid.Empty) jump.JumpId = Guid.NewGuid();
            this.OnBeforePut(jump);
            this.SDM.Upsert(jump);
            this.OnAfterPut(jump);
            return jump;
        }

        // POST api/Jumps/{jump-guid}
        public void Delete(Guid jumpId)
        {
            var jumpWhere = String.Format("JumpId = '{0}'", jumpId);
            var jump = this.SDM.GetAllJumps<Jump>(jumpWhere).FirstOrDefault();
            this.OnBeforeDelete(jump);
            this.SDM.Delete(jump);
            this.OnAfterDelete(jump);
        }
    }
}
