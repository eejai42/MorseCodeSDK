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
    public partial class AeronauticalsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Aeronautical> Aeronauticals);
        partial void OnAfterGetById(Aeronautical Aeronauticals, Guid aeronauticalId);
        partial void OnBeforePost(Aeronautical aeronautical);
        partial void OnAfterPost(Aeronautical aeronautical);
        partial void OnBeforePut(Aeronautical aeronautical);
        partial void OnAfterPut(Aeronautical aeronautical);
        partial void OnBeforeDelete(Aeronautical aeronautical);
        partial void OnAfterDelete(Aeronautical aeronautical);
        

        public AeronauticalsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Aeronautical
        public IEnumerable<Aeronautical> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllAeronauticals<Aeronautical>();
            Aeronautical.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Aeronauticals/{aeronautical-guid}
        public Aeronautical Get(Guid aeronauticalId)
        {
            var AeronauticalsWhere = String.Format("AeronauticalId = '{0}'", aeronauticalId);
            var result = this.SDM.GetAllAeronauticals<Aeronautical>(AeronauticalsWhere).FirstOrDefault();
            this.OnAfterGetById(result, aeronauticalId);
            return result;
        }

        // POST api/Aeronauticals/{aeronautical-guid}
        public Aeronautical Post([FromBody]Aeronautical aeronautical)
        {
            if (aeronautical.AeronauticalId == Guid.Empty) aeronautical.AeronauticalId = Guid.NewGuid();
            this.OnBeforePost(aeronautical);
            this.SDM.Upsert(aeronautical);
            this.OnAfterPost(aeronautical);
            return aeronautical;
        }

        // POST api/Aeronauticals/{aeronautical-guid}
        public Aeronautical Put([FromBody]Aeronautical aeronautical)
        {
            if (aeronautical.AeronauticalId == Guid.Empty) aeronautical.AeronauticalId = Guid.NewGuid();
            this.OnBeforePut(aeronautical);
            this.SDM.Upsert(aeronautical);
            this.OnAfterPut(aeronautical);
            return aeronautical;
        }

        // POST api/Aeronauticals/{aeronautical-guid}
        public void Delete(Guid aeronauticalId)
        {
            var aeronauticalWhere = String.Format("AeronauticalId = '{0}'", aeronauticalId);
            var aeronautical = this.SDM.GetAllAeronauticals<Aeronautical>(aeronauticalWhere).FirstOrDefault();
            this.OnBeforeDelete(aeronautical);
            this.SDM.Delete(aeronautical);
            this.OnAfterDelete(aeronautical);
        }
    }
}
