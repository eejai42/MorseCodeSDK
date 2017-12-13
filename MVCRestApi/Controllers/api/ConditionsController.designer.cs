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
    public partial class ConditionsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Condition> Conditions);
        partial void OnAfterGetById(Condition Conditions, Guid conditionId);
        partial void OnBeforePost(Condition condition);
        partial void OnAfterPost(Condition condition);
        partial void OnBeforePut(Condition condition);
        partial void OnAfterPut(Condition condition);
        partial void OnBeforeDelete(Condition condition);
        partial void OnAfterDelete(Condition condition);
        

        public ConditionsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Condition
        public IEnumerable<Condition> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllConditions<Condition>();
            Condition.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Conditions/{condition-guid}
        public Condition Get(Guid conditionId)
        {
            var ConditionsWhere = String.Format("ConditionId = '{0}'", conditionId);
            var result = this.SDM.GetAllConditions<Condition>(ConditionsWhere).FirstOrDefault();
            this.OnAfterGetById(result, conditionId);
            return result;
        }

        // POST api/Conditions/{condition-guid}
        public Condition Post([FromBody]Condition condition)
        {
            if (condition.ConditionId == Guid.Empty) condition.ConditionId = Guid.NewGuid();
            this.OnBeforePost(condition);
            this.SDM.Upsert(condition);
            this.OnAfterPost(condition);
            return condition;
        }

        // POST api/Conditions/{condition-guid}
        public Condition Put([FromBody]Condition condition)
        {
            if (condition.ConditionId == Guid.Empty) condition.ConditionId = Guid.NewGuid();
            this.OnBeforePut(condition);
            this.SDM.Upsert(condition);
            this.OnAfterPut(condition);
            return condition;
        }

        // POST api/Conditions/{condition-guid}
        public void Delete(Guid conditionId)
        {
            var conditionWhere = String.Format("ConditionId = '{0}'", conditionId);
            var condition = this.SDM.GetAllConditions<Condition>(conditionWhere).FirstOrDefault();
            this.OnBeforeDelete(condition);
            this.SDM.Delete(condition);
            this.OnAfterDelete(condition);
        }
    }
}
