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
    public partial class HumansController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Human> Humans);
        partial void OnAfterGetById(Human Humans, Guid humanId);
        partial void OnBeforePost(Human human);
        partial void OnAfterPost(Human human);
        partial void OnBeforePut(Human human);
        partial void OnAfterPut(Human human);
        partial void OnBeforeDelete(Human human);
        partial void OnAfterDelete(Human human);
        

        public HumansController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Human
        public IEnumerable<Human> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllHumans<Human>();
            Human.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Humans/{human-guid}
        public Human Get(Guid humanId)
        {
            var HumansWhere = String.Format("HumanId = '{0}'", humanId);
            var result = this.SDM.GetAllHumans<Human>(HumansWhere).FirstOrDefault();
            this.OnAfterGetById(result, humanId);
            return result;
        }

        // POST api/Humans/{human-guid}
        public Human Post([FromBody]Human human)
        {
            if (human.HumanId == Guid.Empty) human.HumanId = Guid.NewGuid();
            this.OnBeforePost(human);
            this.SDM.Upsert(human);
            this.OnAfterPost(human);
            return human;
        }

        // POST api/Humans/{human-guid}
        public Human Put([FromBody]Human human)
        {
            if (human.HumanId == Guid.Empty) human.HumanId = Guid.NewGuid();
            this.OnBeforePut(human);
            this.SDM.Upsert(human);
            this.OnAfterPut(human);
            return human;
        }

        // POST api/Humans/{human-guid}
        public void Delete(Guid humanId)
        {
            var humanWhere = String.Format("HumanId = '{0}'", humanId);
            var human = this.SDM.GetAllHumans<Human>(humanWhere).FirstOrDefault();
            this.OnBeforeDelete(human);
            this.SDM.Delete(human);
            this.OnAfterDelete(human);
        }
    }
}
