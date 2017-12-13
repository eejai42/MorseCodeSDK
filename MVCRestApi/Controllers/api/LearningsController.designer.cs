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
    public partial class LearningsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Learning> Learnings);
        partial void OnAfterGetById(Learning Learnings, Guid learningId);
        partial void OnBeforePost(Learning learning);
        partial void OnAfterPost(Learning learning);
        partial void OnBeforePut(Learning learning);
        partial void OnAfterPut(Learning learning);
        partial void OnBeforeDelete(Learning learning);
        partial void OnAfterDelete(Learning learning);
        

        public LearningsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Learning
        public IEnumerable<Learning> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllLearnings<Learning>();
            Learning.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Learnings/{learning-guid}
        public Learning Get(Guid learningId)
        {
            var LearningsWhere = String.Format("LearningId = '{0}'", learningId);
            var result = this.SDM.GetAllLearnings<Learning>(LearningsWhere).FirstOrDefault();
            this.OnAfterGetById(result, learningId);
            return result;
        }

        // POST api/Learnings/{learning-guid}
        public Learning Post([FromBody]Learning learning)
        {
            if (learning.LearningId == Guid.Empty) learning.LearningId = Guid.NewGuid();
            this.OnBeforePost(learning);
            this.SDM.Upsert(learning);
            this.OnAfterPost(learning);
            return learning;
        }

        // POST api/Learnings/{learning-guid}
        public Learning Put([FromBody]Learning learning)
        {
            if (learning.LearningId == Guid.Empty) learning.LearningId = Guid.NewGuid();
            this.OnBeforePut(learning);
            this.SDM.Upsert(learning);
            this.OnAfterPut(learning);
            return learning;
        }

        // POST api/Learnings/{learning-guid}
        public void Delete(Guid learningId)
        {
            var learningWhere = String.Format("LearningId = '{0}'", learningId);
            var learning = this.SDM.GetAllLearnings<Learning>(learningWhere).FirstOrDefault();
            this.OnBeforeDelete(learning);
            this.SDM.Delete(learning);
            this.OnAfterDelete(learning);
        }
    }
}
