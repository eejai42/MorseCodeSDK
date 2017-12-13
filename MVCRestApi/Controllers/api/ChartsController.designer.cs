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
    public partial class ChartsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Chart> Charts);
        partial void OnAfterGetById(Chart Charts, Guid chartId);
        partial void OnBeforePost(Chart chart);
        partial void OnAfterPost(Chart chart);
        partial void OnBeforePut(Chart chart);
        partial void OnAfterPut(Chart chart);
        partial void OnBeforeDelete(Chart chart);
        partial void OnAfterDelete(Chart chart);
        

        public ChartsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Chart
        public IEnumerable<Chart> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllCharts<Chart>();
            Chart.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Charts/{chart-guid}
        public Chart Get(Guid chartId)
        {
            var ChartsWhere = String.Format("ChartId = '{0}'", chartId);
            var result = this.SDM.GetAllCharts<Chart>(ChartsWhere).FirstOrDefault();
            this.OnAfterGetById(result, chartId);
            return result;
        }

        // POST api/Charts/{chart-guid}
        public Chart Post([FromBody]Chart chart)
        {
            if (chart.ChartId == Guid.Empty) chart.ChartId = Guid.NewGuid();
            this.OnBeforePost(chart);
            this.SDM.Upsert(chart);
            this.OnAfterPost(chart);
            return chart;
        }

        // POST api/Charts/{chart-guid}
        public Chart Put([FromBody]Chart chart)
        {
            if (chart.ChartId == Guid.Empty) chart.ChartId = Guid.NewGuid();
            this.OnBeforePut(chart);
            this.SDM.Upsert(chart);
            this.OnAfterPut(chart);
            return chart;
        }

        // POST api/Charts/{chart-guid}
        public void Delete(Guid chartId)
        {
            var chartWhere = String.Format("ChartId = '{0}'", chartId);
            var chart = this.SDM.GetAllCharts<Chart>(chartWhere).FirstOrDefault();
            this.OnBeforeDelete(chart);
            this.SDM.Delete(chart);
            this.OnAfterDelete(chart);
        }
    }
}
