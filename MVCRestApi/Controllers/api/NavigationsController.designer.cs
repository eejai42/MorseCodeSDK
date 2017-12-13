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
    public partial class NavigationsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Navigation> Navigations);
        partial void OnAfterGetById(Navigation Navigations, Guid navigationId);
        partial void OnBeforePost(Navigation navigation);
        partial void OnAfterPost(Navigation navigation);
        partial void OnBeforePut(Navigation navigation);
        partial void OnAfterPut(Navigation navigation);
        partial void OnBeforeDelete(Navigation navigation);
        partial void OnAfterDelete(Navigation navigation);
        

        public NavigationsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Navigation
        public IEnumerable<Navigation> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllNavigations<Navigation>();
            Navigation.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Navigations/{navigation-guid}
        public Navigation Get(Guid navigationId)
        {
            var NavigationsWhere = String.Format("NavigationId = '{0}'", navigationId);
            var result = this.SDM.GetAllNavigations<Navigation>(NavigationsWhere).FirstOrDefault();
            this.OnAfterGetById(result, navigationId);
            return result;
        }

        // POST api/Navigations/{navigation-guid}
        public Navigation Post([FromBody]Navigation navigation)
        {
            if (navigation.NavigationId == Guid.Empty) navigation.NavigationId = Guid.NewGuid();
            this.OnBeforePost(navigation);
            this.SDM.Upsert(navigation);
            this.OnAfterPost(navigation);
            return navigation;
        }

        // POST api/Navigations/{navigation-guid}
        public Navigation Put([FromBody]Navigation navigation)
        {
            if (navigation.NavigationId == Guid.Empty) navigation.NavigationId = Guid.NewGuid();
            this.OnBeforePut(navigation);
            this.SDM.Upsert(navigation);
            this.OnAfterPut(navigation);
            return navigation;
        }

        // POST api/Navigations/{navigation-guid}
        public void Delete(Guid navigationId)
        {
            var navigationWhere = String.Format("NavigationId = '{0}'", navigationId);
            var navigation = this.SDM.GetAllNavigations<Navigation>(navigationWhere).FirstOrDefault();
            this.OnBeforeDelete(navigation);
            this.SDM.Delete(navigation);
            this.OnAfterDelete(navigation);
        }
    }
}
