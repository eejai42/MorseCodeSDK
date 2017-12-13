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
    public partial class SeriesesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Series> Serieses);
        partial void OnAfterGetById(Series Serieses, Guid seriesId);
        partial void OnBeforePost(Series series);
        partial void OnAfterPost(Series series);
        partial void OnBeforePut(Series series);
        partial void OnAfterPut(Series series);
        partial void OnBeforeDelete(Series series);
        partial void OnAfterDelete(Series series);
        

        public SeriesesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Series
        public IEnumerable<Series> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSerieses<Series>();
            Series.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Serieses/{series-guid}
        public Series Get(Guid seriesId)
        {
            var SeriesesWhere = String.Format("SeriesId = '{0}'", seriesId);
            var result = this.SDM.GetAllSerieses<Series>(SeriesesWhere).FirstOrDefault();
            this.OnAfterGetById(result, seriesId);
            return result;
        }

        // POST api/Serieses/{series-guid}
        public Series Post([FromBody]Series series)
        {
            if (series.SeriesId == Guid.Empty) series.SeriesId = Guid.NewGuid();
            this.OnBeforePost(series);
            this.SDM.Upsert(series);
            this.OnAfterPost(series);
            return series;
        }

        // POST api/Serieses/{series-guid}
        public Series Put([FromBody]Series series)
        {
            if (series.SeriesId == Guid.Empty) series.SeriesId = Guid.NewGuid();
            this.OnBeforePut(series);
            this.SDM.Upsert(series);
            this.OnAfterPut(series);
            return series;
        }

        // POST api/Serieses/{series-guid}
        public void Delete(Guid seriesId)
        {
            var seriesWhere = String.Format("SeriesId = '{0}'", seriesId);
            var series = this.SDM.GetAllSerieses<Series>(seriesWhere).FirstOrDefault();
            this.OnBeforeDelete(series);
            this.SDM.Delete(series);
            this.OnAfterDelete(series);
        }
    }
}
