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
    public partial class DecodingsoftwaresController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Decodingsoftware> Decodingsoftwares);
        partial void OnAfterGetById(Decodingsoftware Decodingsoftwares, Guid decodingsoftwareId);
        partial void OnBeforePost(Decodingsoftware decodingsoftware);
        partial void OnAfterPost(Decodingsoftware decodingsoftware);
        partial void OnBeforePut(Decodingsoftware decodingsoftware);
        partial void OnAfterPut(Decodingsoftware decodingsoftware);
        partial void OnBeforeDelete(Decodingsoftware decodingsoftware);
        partial void OnAfterDelete(Decodingsoftware decodingsoftware);
        

        public DecodingsoftwaresController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Decodingsoftware
        public IEnumerable<Decodingsoftware> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllDecodingsoftwares<Decodingsoftware>();
            Decodingsoftware.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Decodingsoftwares/{decodingsoftware-guid}
        public Decodingsoftware Get(Guid decodingsoftwareId)
        {
            var DecodingsoftwaresWhere = String.Format("DecodingsoftwareId = '{0}'", decodingsoftwareId);
            var result = this.SDM.GetAllDecodingsoftwares<Decodingsoftware>(DecodingsoftwaresWhere).FirstOrDefault();
            this.OnAfterGetById(result, decodingsoftwareId);
            return result;
        }

        // POST api/Decodingsoftwares/{decodingsoftware-guid}
        public Decodingsoftware Post([FromBody]Decodingsoftware decodingsoftware)
        {
            if (decodingsoftware.DecodingsoftwareId == Guid.Empty) decodingsoftware.DecodingsoftwareId = Guid.NewGuid();
            this.OnBeforePost(decodingsoftware);
            this.SDM.Upsert(decodingsoftware);
            this.OnAfterPost(decodingsoftware);
            return decodingsoftware;
        }

        // POST api/Decodingsoftwares/{decodingsoftware-guid}
        public Decodingsoftware Put([FromBody]Decodingsoftware decodingsoftware)
        {
            if (decodingsoftware.DecodingsoftwareId == Guid.Empty) decodingsoftware.DecodingsoftwareId = Guid.NewGuid();
            this.OnBeforePut(decodingsoftware);
            this.SDM.Upsert(decodingsoftware);
            this.OnAfterPut(decodingsoftware);
            return decodingsoftware;
        }

        // POST api/Decodingsoftwares/{decodingsoftware-guid}
        public void Delete(Guid decodingsoftwareId)
        {
            var decodingsoftwareWhere = String.Format("DecodingsoftwareId = '{0}'", decodingsoftwareId);
            var decodingsoftware = this.SDM.GetAllDecodingsoftwares<Decodingsoftware>(decodingsoftwareWhere).FirstOrDefault();
            this.OnBeforeDelete(decodingsoftware);
            this.SDM.Delete(decodingsoftware);
            this.OnAfterDelete(decodingsoftware);
        }
    }
}
