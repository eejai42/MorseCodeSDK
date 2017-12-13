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
    public partial class PracticesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Practice> Practices);
        partial void OnAfterGetById(Practice Practices, Guid practiceId);
        partial void OnBeforePost(Practice practice);
        partial void OnAfterPost(Practice practice);
        partial void OnBeforePut(Practice practice);
        partial void OnAfterPut(Practice practice);
        partial void OnBeforeDelete(Practice practice);
        partial void OnAfterDelete(Practice practice);
        

        public PracticesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Practice
        public IEnumerable<Practice> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllPractices<Practice>();
            Practice.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Practices/{practice-guid}
        public Practice Get(Guid practiceId)
        {
            var PracticesWhere = String.Format("PracticeId = '{0}'", practiceId);
            var result = this.SDM.GetAllPractices<Practice>(PracticesWhere).FirstOrDefault();
            this.OnAfterGetById(result, practiceId);
            return result;
        }

        // POST api/Practices/{practice-guid}
        public Practice Post([FromBody]Practice practice)
        {
            if (practice.PracticeId == Guid.Empty) practice.PracticeId = Guid.NewGuid();
            this.OnBeforePost(practice);
            this.SDM.Upsert(practice);
            this.OnAfterPost(practice);
            return practice;
        }

        // POST api/Practices/{practice-guid}
        public Practice Put([FromBody]Practice practice)
        {
            if (practice.PracticeId == Guid.Empty) practice.PracticeId = Guid.NewGuid();
            this.OnBeforePut(practice);
            this.SDM.Upsert(practice);
            this.OnAfterPut(practice);
            return practice;
        }

        // POST api/Practices/{practice-guid}
        public void Delete(Guid practiceId)
        {
            var practiceWhere = String.Format("PracticeId = '{0}'", practiceId);
            var practice = this.SDM.GetAllPractices<Practice>(practiceWhere).FirstOrDefault();
            this.OnBeforeDelete(practice);
            this.SDM.Delete(practice);
            this.OnAfterDelete(practice);
        }
    }
}
