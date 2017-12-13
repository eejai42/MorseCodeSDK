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
    public partial class MeasurementsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Measurement> Measurements);
        partial void OnAfterGetById(Measurement Measurements, Guid measurementId);
        partial void OnBeforePost(Measurement measurement);
        partial void OnAfterPost(Measurement measurement);
        partial void OnBeforePut(Measurement measurement);
        partial void OnAfterPut(Measurement measurement);
        partial void OnBeforeDelete(Measurement measurement);
        partial void OnAfterDelete(Measurement measurement);
        

        public MeasurementsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Measurement
        public IEnumerable<Measurement> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllMeasurements<Measurement>();
            Measurement.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Measurements/{measurement-guid}
        public Measurement Get(Guid measurementId)
        {
            var MeasurementsWhere = String.Format("MeasurementId = '{0}'", measurementId);
            var result = this.SDM.GetAllMeasurements<Measurement>(MeasurementsWhere).FirstOrDefault();
            this.OnAfterGetById(result, measurementId);
            return result;
        }

        // POST api/Measurements/{measurement-guid}
        public Measurement Post([FromBody]Measurement measurement)
        {
            if (measurement.MeasurementId == Guid.Empty) measurement.MeasurementId = Guid.NewGuid();
            this.OnBeforePost(measurement);
            this.SDM.Upsert(measurement);
            this.OnAfterPost(measurement);
            return measurement;
        }

        // POST api/Measurements/{measurement-guid}
        public Measurement Put([FromBody]Measurement measurement)
        {
            if (measurement.MeasurementId == Guid.Empty) measurement.MeasurementId = Guid.NewGuid();
            this.OnBeforePut(measurement);
            this.SDM.Upsert(measurement);
            this.OnAfterPut(measurement);
            return measurement;
        }

        // POST api/Measurements/{measurement-guid}
        public void Delete(Guid measurementId)
        {
            var measurementWhere = String.Format("MeasurementId = '{0}'", measurementId);
            var measurement = this.SDM.GetAllMeasurements<Measurement>(measurementWhere).FirstOrDefault();
            this.OnBeforeDelete(measurement);
            this.SDM.Delete(measurement);
            this.OnAfterDelete(measurement);
        }
    }
}
