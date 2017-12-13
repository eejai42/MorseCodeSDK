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
    public partial class LearningmethodsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Learningmethod> Learningmethods);
        partial void OnAfterGetById(Learningmethod Learningmethods, Guid learningmethodId);
        partial void OnBeforePost(Learningmethod learningmethod);
        partial void OnAfterPost(Learningmethod learningmethod);
        partial void OnBeforePut(Learningmethod learningmethod);
        partial void OnAfterPut(Learningmethod learningmethod);
        partial void OnBeforeDelete(Learningmethod learningmethod);
        partial void OnAfterDelete(Learningmethod learningmethod);
        

        public LearningmethodsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Learningmethod
        public IEnumerable<Learningmethod> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllLearningmethods<Learningmethod>();
            Learningmethod.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Learningmethods/{learningmethod-guid}
        public Learningmethod Get(Guid learningmethodId)
        {
            var LearningmethodsWhere = String.Format("LearningmethodId = '{0}'", learningmethodId);
            var result = this.SDM.GetAllLearningmethods<Learningmethod>(LearningmethodsWhere).FirstOrDefault();
            this.OnAfterGetById(result, learningmethodId);
            return result;
        }

        // POST api/Learningmethods/{learningmethod-guid}
        public Learningmethod Post([FromBody]Learningmethod learningmethod)
        {
            if (learningmethod.LearningmethodId == Guid.Empty) learningmethod.LearningmethodId = Guid.NewGuid();
            this.OnBeforePost(learningmethod);
            this.SDM.Upsert(learningmethod);
            this.OnAfterPost(learningmethod);
            return learningmethod;
        }

        // POST api/Learningmethods/{learningmethod-guid}
        public Learningmethod Put([FromBody]Learningmethod learningmethod)
        {
            if (learningmethod.LearningmethodId == Guid.Empty) learningmethod.LearningmethodId = Guid.NewGuid();
            this.OnBeforePut(learningmethod);
            this.SDM.Upsert(learningmethod);
            this.OnAfterPut(learningmethod);
            return learningmethod;
        }

        // POST api/Learningmethods/{learningmethod-guid}
        public void Delete(Guid learningmethodId)
        {
            var learningmethodWhere = String.Format("LearningmethodId = '{0}'", learningmethodId);
            var learningmethod = this.SDM.GetAllLearningmethods<Learningmethod>(learningmethodWhere).FirstOrDefault();
            this.OnBeforeDelete(learningmethod);
            this.SDM.Delete(learningmethod);
            this.OnAfterDelete(learningmethod);
        }
    }
}
