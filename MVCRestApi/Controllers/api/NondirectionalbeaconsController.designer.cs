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
    public partial class NondirectionalbeaconsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Nondirectionalbeacon> Nondirectionalbeacons);
        partial void OnAfterGetById(Nondirectionalbeacon Nondirectionalbeacons, Guid nondirectionalbeaconId);
        partial void OnBeforePost(Nondirectionalbeacon nondirectionalbeacon);
        partial void OnAfterPost(Nondirectionalbeacon nondirectionalbeacon);
        partial void OnBeforePut(Nondirectionalbeacon nondirectionalbeacon);
        partial void OnAfterPut(Nondirectionalbeacon nondirectionalbeacon);
        partial void OnBeforeDelete(Nondirectionalbeacon nondirectionalbeacon);
        partial void OnAfterDelete(Nondirectionalbeacon nondirectionalbeacon);
        

        public NondirectionalbeaconsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Nondirectionalbeacon
        public IEnumerable<Nondirectionalbeacon> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllNondirectionalbeacons<Nondirectionalbeacon>();
            Nondirectionalbeacon.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Nondirectionalbeacons/{nondirectionalbeacon-guid}
        public Nondirectionalbeacon Get(Guid nondirectionalbeaconId)
        {
            var NondirectionalbeaconsWhere = String.Format("NondirectionalbeaconId = '{0}'", nondirectionalbeaconId);
            var result = this.SDM.GetAllNondirectionalbeacons<Nondirectionalbeacon>(NondirectionalbeaconsWhere).FirstOrDefault();
            this.OnAfterGetById(result, nondirectionalbeaconId);
            return result;
        }

        // POST api/Nondirectionalbeacons/{nondirectionalbeacon-guid}
        public Nondirectionalbeacon Post([FromBody]Nondirectionalbeacon nondirectionalbeacon)
        {
            if (nondirectionalbeacon.NondirectionalbeaconId == Guid.Empty) nondirectionalbeacon.NondirectionalbeaconId = Guid.NewGuid();
            this.OnBeforePost(nondirectionalbeacon);
            this.SDM.Upsert(nondirectionalbeacon);
            this.OnAfterPost(nondirectionalbeacon);
            return nondirectionalbeacon;
        }

        // POST api/Nondirectionalbeacons/{nondirectionalbeacon-guid}
        public Nondirectionalbeacon Put([FromBody]Nondirectionalbeacon nondirectionalbeacon)
        {
            if (nondirectionalbeacon.NondirectionalbeaconId == Guid.Empty) nondirectionalbeacon.NondirectionalbeaconId = Guid.NewGuid();
            this.OnBeforePut(nondirectionalbeacon);
            this.SDM.Upsert(nondirectionalbeacon);
            this.OnAfterPut(nondirectionalbeacon);
            return nondirectionalbeacon;
        }

        // POST api/Nondirectionalbeacons/{nondirectionalbeacon-guid}
        public void Delete(Guid nondirectionalbeaconId)
        {
            var nondirectionalbeaconWhere = String.Format("NondirectionalbeaconId = '{0}'", nondirectionalbeaconId);
            var nondirectionalbeacon = this.SDM.GetAllNondirectionalbeacons<Nondirectionalbeacon>(nondirectionalbeaconWhere).FirstOrDefault();
            this.OnBeforeDelete(nondirectionalbeacon);
            this.SDM.Delete(nondirectionalbeacon);
            this.OnAfterDelete(nondirectionalbeacon);
        }
    }
}
