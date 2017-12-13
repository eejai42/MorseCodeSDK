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
    public partial class KnowledgesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Knowledge> Knowledges);
        partial void OnAfterGetById(Knowledge Knowledges, Guid knowledgeId);
        partial void OnBeforePost(Knowledge knowledge);
        partial void OnAfterPost(Knowledge knowledge);
        partial void OnBeforePut(Knowledge knowledge);
        partial void OnAfterPut(Knowledge knowledge);
        partial void OnBeforeDelete(Knowledge knowledge);
        partial void OnAfterDelete(Knowledge knowledge);
        

        public KnowledgesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Knowledge
        public IEnumerable<Knowledge> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllKnowledges<Knowledge>();
            Knowledge.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Knowledges/{knowledge-guid}
        public Knowledge Get(Guid knowledgeId)
        {
            var KnowledgesWhere = String.Format("KnowledgeId = '{0}'", knowledgeId);
            var result = this.SDM.GetAllKnowledges<Knowledge>(KnowledgesWhere).FirstOrDefault();
            this.OnAfterGetById(result, knowledgeId);
            return result;
        }

        // POST api/Knowledges/{knowledge-guid}
        public Knowledge Post([FromBody]Knowledge knowledge)
        {
            if (knowledge.KnowledgeId == Guid.Empty) knowledge.KnowledgeId = Guid.NewGuid();
            this.OnBeforePost(knowledge);
            this.SDM.Upsert(knowledge);
            this.OnAfterPost(knowledge);
            return knowledge;
        }

        // POST api/Knowledges/{knowledge-guid}
        public Knowledge Put([FromBody]Knowledge knowledge)
        {
            if (knowledge.KnowledgeId == Guid.Empty) knowledge.KnowledgeId = Guid.NewGuid();
            this.OnBeforePut(knowledge);
            this.SDM.Upsert(knowledge);
            this.OnAfterPut(knowledge);
            return knowledge;
        }

        // POST api/Knowledges/{knowledge-guid}
        public void Delete(Guid knowledgeId)
        {
            var knowledgeWhere = String.Format("KnowledgeId = '{0}'", knowledgeId);
            var knowledge = this.SDM.GetAllKnowledges<Knowledge>(knowledgeWhere).FirstOrDefault();
            this.OnBeforeDelete(knowledge);
            this.SDM.Delete(knowledge);
            this.OnAfterDelete(knowledge);
        }
    }
}
