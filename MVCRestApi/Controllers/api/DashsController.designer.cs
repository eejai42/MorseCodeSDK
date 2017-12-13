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
    public partial class DashsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Dash> Dashs);
        partial void OnAfterGetById(Dash Dashs, Guid dashId);
        partial void OnBeforePost(Dash dash);
        partial void OnAfterPost(Dash dash);
        partial void OnBeforePut(Dash dash);
        partial void OnAfterPut(Dash dash);
        partial void OnBeforeDelete(Dash dash);
        partial void OnAfterDelete(Dash dash);
        

        public DashsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Dash
        public IEnumerable<Dash> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllDashs<Dash>();
            Dash.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Dashs/{dash-guid}
        public Dash Get(Guid dashId)
        {
            var DashsWhere = String.Format("DashId = '{0}'", dashId);
            var result = this.SDM.GetAllDashs<Dash>(DashsWhere).FirstOrDefault();
            this.OnAfterGetById(result, dashId);
            return result;
        }

        // POST api/Dashs/{dash-guid}
        public Dash Post([FromBody]Dash dash)
        {
            if (dash.DashId == Guid.Empty) dash.DashId = Guid.NewGuid();
            this.OnBeforePost(dash);
            this.SDM.Upsert(dash);
            this.OnAfterPost(dash);
            return dash;
        }

        // POST api/Dashs/{dash-guid}
        public Dash Put([FromBody]Dash dash)
        {
            if (dash.DashId == Guid.Empty) dash.DashId = Guid.NewGuid();
            this.OnBeforePut(dash);
            this.SDM.Upsert(dash);
            this.OnAfterPut(dash);
            return dash;
        }

        // POST api/Dashs/{dash-guid}
        public void Delete(Guid dashId)
        {
            var dashWhere = String.Format("DashId = '{0}'", dashId);
            var dash = this.SDM.GetAllDashs<Dash>(dashWhere).FirstOrDefault();
            this.OnBeforeDelete(dash);
            this.SDM.Delete(dash);
            this.OnAfterDelete(dash);
        }
    }
}
