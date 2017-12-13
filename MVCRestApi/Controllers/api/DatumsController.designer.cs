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
    public partial class DatumsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Datum> Datums);
        partial void OnAfterGetById(Datum Datums, Guid datumId);
        partial void OnBeforePost(Datum datum);
        partial void OnAfterPost(Datum datum);
        partial void OnBeforePut(Datum datum);
        partial void OnAfterPut(Datum datum);
        partial void OnBeforeDelete(Datum datum);
        partial void OnAfterDelete(Datum datum);
        

        public DatumsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Datum
        public IEnumerable<Datum> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllDatums<Datum>();
            Datum.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Datums/{datum-guid}
        public Datum Get(Guid datumId)
        {
            var DatumsWhere = String.Format("DatumId = '{0}'", datumId);
            var result = this.SDM.GetAllDatums<Datum>(DatumsWhere).FirstOrDefault();
            this.OnAfterGetById(result, datumId);
            return result;
        }

        // POST api/Datums/{datum-guid}
        public Datum Post([FromBody]Datum datum)
        {
            if (datum.DatumId == Guid.Empty) datum.DatumId = Guid.NewGuid();
            this.OnBeforePost(datum);
            this.SDM.Upsert(datum);
            this.OnAfterPost(datum);
            return datum;
        }

        // POST api/Datums/{datum-guid}
        public Datum Put([FromBody]Datum datum)
        {
            if (datum.DatumId == Guid.Empty) datum.DatumId = Guid.NewGuid();
            this.OnBeforePut(datum);
            this.SDM.Upsert(datum);
            this.OnAfterPut(datum);
            return datum;
        }

        // POST api/Datums/{datum-guid}
        public void Delete(Guid datumId)
        {
            var datumWhere = String.Format("DatumId = '{0}'", datumId);
            var datum = this.SDM.GetAllDatums<Datum>(datumWhere).FirstOrDefault();
            this.OnBeforeDelete(datum);
            this.SDM.Delete(datum);
            this.OnAfterDelete(datum);
        }
    }
}
