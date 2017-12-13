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
    public partial class TelegraphsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Telegraph> Telegraphs);
        partial void OnAfterGetById(Telegraph Telegraphs, Guid telegraphId);
        partial void OnBeforePost(Telegraph telegraph);
        partial void OnAfterPost(Telegraph telegraph);
        partial void OnBeforePut(Telegraph telegraph);
        partial void OnAfterPut(Telegraph telegraph);
        partial void OnBeforeDelete(Telegraph telegraph);
        partial void OnAfterDelete(Telegraph telegraph);
        

        public TelegraphsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Telegraph
        public IEnumerable<Telegraph> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllTelegraphs<Telegraph>();
            Telegraph.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Telegraphs/{telegraph-guid}
        public Telegraph Get(Guid telegraphId)
        {
            var TelegraphsWhere = String.Format("TelegraphId = '{0}'", telegraphId);
            var result = this.SDM.GetAllTelegraphs<Telegraph>(TelegraphsWhere).FirstOrDefault();
            this.OnAfterGetById(result, telegraphId);
            return result;
        }

        // POST api/Telegraphs/{telegraph-guid}
        public Telegraph Post([FromBody]Telegraph telegraph)
        {
            if (telegraph.TelegraphId == Guid.Empty) telegraph.TelegraphId = Guid.NewGuid();
            this.OnBeforePost(telegraph);
            this.SDM.Upsert(telegraph);
            this.OnAfterPost(telegraph);
            return telegraph;
        }

        // POST api/Telegraphs/{telegraph-guid}
        public Telegraph Put([FromBody]Telegraph telegraph)
        {
            if (telegraph.TelegraphId == Guid.Empty) telegraph.TelegraphId = Guid.NewGuid();
            this.OnBeforePut(telegraph);
            this.SDM.Upsert(telegraph);
            this.OnAfterPut(telegraph);
            return telegraph;
        }

        // POST api/Telegraphs/{telegraph-guid}
        public void Delete(Guid telegraphId)
        {
            var telegraphWhere = String.Format("TelegraphId = '{0}'", telegraphId);
            var telegraph = this.SDM.GetAllTelegraphs<Telegraph>(telegraphWhere).FirstOrDefault();
            this.OnBeforeDelete(telegraph);
            this.SDM.Delete(telegraph);
            this.OnAfterDelete(telegraph);
        }
    }
}
