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
    public partial class HistoriesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<History> Histories);
        partial void OnAfterGetById(History Histories, Guid historyId);
        partial void OnBeforePost(History history);
        partial void OnAfterPost(History history);
        partial void OnBeforePut(History history);
        partial void OnAfterPut(History history);
        partial void OnBeforeDelete(History history);
        partial void OnAfterDelete(History history);
        

        public HistoriesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/History
        public IEnumerable<History> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllHistories<History>();
            History.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Histories/{history-guid}
        public History Get(Guid historyId)
        {
            var HistoriesWhere = String.Format("HistoryId = '{0}'", historyId);
            var result = this.SDM.GetAllHistories<History>(HistoriesWhere).FirstOrDefault();
            this.OnAfterGetById(result, historyId);
            return result;
        }

        // POST api/Histories/{history-guid}
        public History Post([FromBody]History history)
        {
            if (history.HistoryId == Guid.Empty) history.HistoryId = Guid.NewGuid();
            this.OnBeforePost(history);
            this.SDM.Upsert(history);
            this.OnAfterPost(history);
            return history;
        }

        // POST api/Histories/{history-guid}
        public History Put([FromBody]History history)
        {
            if (history.HistoryId == Guid.Empty) history.HistoryId = Guid.NewGuid();
            this.OnBeforePut(history);
            this.SDM.Upsert(history);
            this.OnAfterPut(history);
            return history;
        }

        // POST api/Histories/{history-guid}
        public void Delete(Guid historyId)
        {
            var historyWhere = String.Format("HistoryId = '{0}'", historyId);
            var history = this.SDM.GetAllHistories<History>(historyWhere).FirstOrDefault();
            this.OnBeforeDelete(history);
            this.SDM.Delete(history);
            this.OnAfterDelete(history);
        }
    }
}
