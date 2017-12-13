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
    public partial class SoftwaresController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Software> Softwares);
        partial void OnAfterGetById(Software Softwares, Guid softwareId);
        partial void OnBeforePost(Software software);
        partial void OnAfterPost(Software software);
        partial void OnBeforePut(Software software);
        partial void OnAfterPut(Software software);
        partial void OnBeforeDelete(Software software);
        partial void OnAfterDelete(Software software);
        

        public SoftwaresController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Software
        public IEnumerable<Software> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSoftwares<Software>();
            Software.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Softwares/{software-guid}
        public Software Get(Guid softwareId)
        {
            var SoftwaresWhere = String.Format("SoftwareId = '{0}'", softwareId);
            var result = this.SDM.GetAllSoftwares<Software>(SoftwaresWhere).FirstOrDefault();
            this.OnAfterGetById(result, softwareId);
            return result;
        }

        // POST api/Softwares/{software-guid}
        public Software Post([FromBody]Software software)
        {
            if (software.SoftwareId == Guid.Empty) software.SoftwareId = Guid.NewGuid();
            this.OnBeforePost(software);
            this.SDM.Upsert(software);
            this.OnAfterPost(software);
            return software;
        }

        // POST api/Softwares/{software-guid}
        public Software Put([FromBody]Software software)
        {
            if (software.SoftwareId == Guid.Empty) software.SoftwareId = Guid.NewGuid();
            this.OnBeforePut(software);
            this.SDM.Upsert(software);
            this.OnAfterPut(software);
            return software;
        }

        // POST api/Softwares/{software-guid}
        public void Delete(Guid softwareId)
        {
            var softwareWhere = String.Format("SoftwareId = '{0}'", softwareId);
            var software = this.SDM.GetAllSoftwares<Software>(softwareWhere).FirstOrDefault();
            this.OnBeforeDelete(software);
            this.SDM.Delete(software);
            this.OnAfterDelete(software);
        }
    }
}
