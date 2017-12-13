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
    public partial class LicensingsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Licensing> Licensings);
        partial void OnAfterGetById(Licensing Licensings, Guid licensingId);
        partial void OnBeforePost(Licensing licensing);
        partial void OnAfterPost(Licensing licensing);
        partial void OnBeforePut(Licensing licensing);
        partial void OnAfterPut(Licensing licensing);
        partial void OnBeforeDelete(Licensing licensing);
        partial void OnAfterDelete(Licensing licensing);
        

        public LicensingsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Licensing
        public IEnumerable<Licensing> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllLicensings<Licensing>();
            Licensing.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Licensings/{licensing-guid}
        public Licensing Get(Guid licensingId)
        {
            var LicensingsWhere = String.Format("LicensingId = '{0}'", licensingId);
            var result = this.SDM.GetAllLicensings<Licensing>(LicensingsWhere).FirstOrDefault();
            this.OnAfterGetById(result, licensingId);
            return result;
        }

        // POST api/Licensings/{licensing-guid}
        public Licensing Post([FromBody]Licensing licensing)
        {
            if (licensing.LicensingId == Guid.Empty) licensing.LicensingId = Guid.NewGuid();
            this.OnBeforePost(licensing);
            this.SDM.Upsert(licensing);
            this.OnAfterPost(licensing);
            return licensing;
        }

        // POST api/Licensings/{licensing-guid}
        public Licensing Put([FromBody]Licensing licensing)
        {
            if (licensing.LicensingId == Guid.Empty) licensing.LicensingId = Guid.NewGuid();
            this.OnBeforePut(licensing);
            this.SDM.Upsert(licensing);
            this.OnAfterPut(licensing);
            return licensing;
        }

        // POST api/Licensings/{licensing-guid}
        public void Delete(Guid licensingId)
        {
            var licensingWhere = String.Format("LicensingId = '{0}'", licensingId);
            var licensing = this.SDM.GetAllLicensings<Licensing>(licensingWhere).FirstOrDefault();
            this.OnBeforeDelete(licensing);
            this.SDM.Delete(licensing);
            this.OnAfterDelete(licensing);
        }
    }
}
