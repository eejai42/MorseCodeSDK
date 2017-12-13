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
    public partial class CablesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Cable> Cables);
        partial void OnAfterGetById(Cable Cables, Guid cableId);
        partial void OnBeforePost(Cable cable);
        partial void OnAfterPost(Cable cable);
        partial void OnBeforePut(Cable cable);
        partial void OnAfterPut(Cable cable);
        partial void OnBeforeDelete(Cable cable);
        partial void OnAfterDelete(Cable cable);
        

        public CablesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Cable
        public IEnumerable<Cable> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllCables<Cable>();
            Cable.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Cables/{cable-guid}
        public Cable Get(Guid cableId)
        {
            var CablesWhere = String.Format("CableId = '{0}'", cableId);
            var result = this.SDM.GetAllCables<Cable>(CablesWhere).FirstOrDefault();
            this.OnAfterGetById(result, cableId);
            return result;
        }

        // POST api/Cables/{cable-guid}
        public Cable Post([FromBody]Cable cable)
        {
            if (cable.CableId == Guid.Empty) cable.CableId = Guid.NewGuid();
            this.OnBeforePost(cable);
            this.SDM.Upsert(cable);
            this.OnAfterPost(cable);
            return cable;
        }

        // POST api/Cables/{cable-guid}
        public Cable Put([FromBody]Cable cable)
        {
            if (cable.CableId == Guid.Empty) cable.CableId = Guid.NewGuid();
            this.OnBeforePut(cable);
            this.SDM.Upsert(cable);
            this.OnAfterPut(cable);
            return cable;
        }

        // POST api/Cables/{cable-guid}
        public void Delete(Guid cableId)
        {
            var cableWhere = String.Format("CableId = '{0}'", cableId);
            var cable = this.SDM.GetAllCables<Cable>(cableWhere).FirstOrDefault();
            this.OnBeforeDelete(cable);
            this.SDM.Delete(cable);
            this.OnAfterDelete(cable);
        }
    }
}
