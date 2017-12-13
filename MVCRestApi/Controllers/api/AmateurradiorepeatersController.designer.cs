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
    public partial class AmateurradiorepeatersController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Amateurradiorepeater> Amateurradiorepeaters);
        partial void OnAfterGetById(Amateurradiorepeater Amateurradiorepeaters, Guid amateurradiorepeaterId);
        partial void OnBeforePost(Amateurradiorepeater amateurradiorepeater);
        partial void OnAfterPost(Amateurradiorepeater amateurradiorepeater);
        partial void OnBeforePut(Amateurradiorepeater amateurradiorepeater);
        partial void OnAfterPut(Amateurradiorepeater amateurradiorepeater);
        partial void OnBeforeDelete(Amateurradiorepeater amateurradiorepeater);
        partial void OnAfterDelete(Amateurradiorepeater amateurradiorepeater);
        

        public AmateurradiorepeatersController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Amateurradiorepeater
        public IEnumerable<Amateurradiorepeater> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllAmateurradiorepeaters<Amateurradiorepeater>();
            Amateurradiorepeater.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Amateurradiorepeaters/{amateurradiorepeater-guid}
        public Amateurradiorepeater Get(Guid amateurradiorepeaterId)
        {
            var AmateurradiorepeatersWhere = String.Format("AmateurradiorepeaterId = '{0}'", amateurradiorepeaterId);
            var result = this.SDM.GetAllAmateurradiorepeaters<Amateurradiorepeater>(AmateurradiorepeatersWhere).FirstOrDefault();
            this.OnAfterGetById(result, amateurradiorepeaterId);
            return result;
        }

        // POST api/Amateurradiorepeaters/{amateurradiorepeater-guid}
        public Amateurradiorepeater Post([FromBody]Amateurradiorepeater amateurradiorepeater)
        {
            if (amateurradiorepeater.AmateurradiorepeaterId == Guid.Empty) amateurradiorepeater.AmateurradiorepeaterId = Guid.NewGuid();
            this.OnBeforePost(amateurradiorepeater);
            this.SDM.Upsert(amateurradiorepeater);
            this.OnAfterPost(amateurradiorepeater);
            return amateurradiorepeater;
        }

        // POST api/Amateurradiorepeaters/{amateurradiorepeater-guid}
        public Amateurradiorepeater Put([FromBody]Amateurradiorepeater amateurradiorepeater)
        {
            if (amateurradiorepeater.AmateurradiorepeaterId == Guid.Empty) amateurradiorepeater.AmateurradiorepeaterId = Guid.NewGuid();
            this.OnBeforePut(amateurradiorepeater);
            this.SDM.Upsert(amateurradiorepeater);
            this.OnAfterPut(amateurradiorepeater);
            return amateurradiorepeater;
        }

        // POST api/Amateurradiorepeaters/{amateurradiorepeater-guid}
        public void Delete(Guid amateurradiorepeaterId)
        {
            var amateurradiorepeaterWhere = String.Format("AmateurradiorepeaterId = '{0}'", amateurradiorepeaterId);
            var amateurradiorepeater = this.SDM.GetAllAmateurradiorepeaters<Amateurradiorepeater>(amateurradiorepeaterWhere).FirstOrDefault();
            this.OnBeforeDelete(amateurradiorepeater);
            this.SDM.Delete(amateurradiorepeater);
            this.OnAfterDelete(amateurradiorepeater);
        }
    }
}
