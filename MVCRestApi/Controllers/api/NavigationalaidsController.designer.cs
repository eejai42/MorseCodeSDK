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
    public partial class NavigationalaidsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Navigationalaid> Navigationalaids);
        partial void OnAfterGetById(Navigationalaid Navigationalaids, Guid navigationalaidId);
        partial void OnBeforePost(Navigationalaid navigationalaid);
        partial void OnAfterPost(Navigationalaid navigationalaid);
        partial void OnBeforePut(Navigationalaid navigationalaid);
        partial void OnAfterPut(Navigationalaid navigationalaid);
        partial void OnBeforeDelete(Navigationalaid navigationalaid);
        partial void OnAfterDelete(Navigationalaid navigationalaid);
        

        public NavigationalaidsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Navigationalaid
        public IEnumerable<Navigationalaid> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllNavigationalaids<Navigationalaid>();
            Navigationalaid.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Navigationalaids/{navigationalaid-guid}
        public Navigationalaid Get(Guid navigationalaidId)
        {
            var NavigationalaidsWhere = String.Format("NavigationalaidId = '{0}'", navigationalaidId);
            var result = this.SDM.GetAllNavigationalaids<Navigationalaid>(NavigationalaidsWhere).FirstOrDefault();
            this.OnAfterGetById(result, navigationalaidId);
            return result;
        }

        // POST api/Navigationalaids/{navigationalaid-guid}
        public Navigationalaid Post([FromBody]Navigationalaid navigationalaid)
        {
            if (navigationalaid.NavigationalaidId == Guid.Empty) navigationalaid.NavigationalaidId = Guid.NewGuid();
            this.OnBeforePost(navigationalaid);
            this.SDM.Upsert(navigationalaid);
            this.OnAfterPost(navigationalaid);
            return navigationalaid;
        }

        // POST api/Navigationalaids/{navigationalaid-guid}
        public Navigationalaid Put([FromBody]Navigationalaid navigationalaid)
        {
            if (navigationalaid.NavigationalaidId == Guid.Empty) navigationalaid.NavigationalaidId = Guid.NewGuid();
            this.OnBeforePut(navigationalaid);
            this.SDM.Upsert(navigationalaid);
            this.OnAfterPut(navigationalaid);
            return navigationalaid;
        }

        // POST api/Navigationalaids/{navigationalaid-guid}
        public void Delete(Guid navigationalaidId)
        {
            var navigationalaidWhere = String.Format("NavigationalaidId = '{0}'", navigationalaidId);
            var navigationalaid = this.SDM.GetAllNavigationalaids<Navigationalaid>(navigationalaidWhere).FirstOrDefault();
            this.OnBeforeDelete(navigationalaid);
            this.SDM.Delete(navigationalaid);
            this.OnAfterDelete(navigationalaid);
        }
    }
}
