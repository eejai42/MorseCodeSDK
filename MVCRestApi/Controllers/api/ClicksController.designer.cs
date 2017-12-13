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
    public partial class ClicksController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Click> Clicks);
        partial void OnAfterGetById(Click Clicks, Guid clickId);
        partial void OnBeforePost(Click click);
        partial void OnAfterPost(Click click);
        partial void OnBeforePut(Click click);
        partial void OnAfterPut(Click click);
        partial void OnBeforeDelete(Click click);
        partial void OnAfterDelete(Click click);
        

        public ClicksController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Click
        public IEnumerable<Click> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllClicks<Click>();
            Click.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Clicks/{click-guid}
        public Click Get(Guid clickId)
        {
            var ClicksWhere = String.Format("ClickId = '{0}'", clickId);
            var result = this.SDM.GetAllClicks<Click>(ClicksWhere).FirstOrDefault();
            this.OnAfterGetById(result, clickId);
            return result;
        }

        // POST api/Clicks/{click-guid}
        public Click Post([FromBody]Click click)
        {
            if (click.ClickId == Guid.Empty) click.ClickId = Guid.NewGuid();
            this.OnBeforePost(click);
            this.SDM.Upsert(click);
            this.OnAfterPost(click);
            return click;
        }

        // POST api/Clicks/{click-guid}
        public Click Put([FromBody]Click click)
        {
            if (click.ClickId == Guid.Empty) click.ClickId = Guid.NewGuid();
            this.OnBeforePut(click);
            this.SDM.Upsert(click);
            this.OnAfterPut(click);
            return click;
        }

        // POST api/Clicks/{click-guid}
        public void Delete(Guid clickId)
        {
            var clickWhere = String.Format("ClickId = '{0}'", clickId);
            var click = this.SDM.GetAllClicks<Click>(clickWhere).FirstOrDefault();
            this.OnBeforeDelete(click);
            this.SDM.Delete(click);
            this.OnAfterDelete(click);
        }
    }
}
