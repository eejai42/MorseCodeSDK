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
    public partial class DisplaiesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Display> Displaies);
        partial void OnAfterGetById(Display Displaies, Guid displayId);
        partial void OnBeforePost(Display display);
        partial void OnAfterPost(Display display);
        partial void OnBeforePut(Display display);
        partial void OnAfterPut(Display display);
        partial void OnBeforeDelete(Display display);
        partial void OnAfterDelete(Display display);
        

        public DisplaiesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Display
        public IEnumerable<Display> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllDisplaies<Display>();
            Display.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Displaies/{display-guid}
        public Display Get(Guid displayId)
        {
            var DisplaiesWhere = String.Format("DisplayId = '{0}'", displayId);
            var result = this.SDM.GetAllDisplaies<Display>(DisplaiesWhere).FirstOrDefault();
            this.OnAfterGetById(result, displayId);
            return result;
        }

        // POST api/Displaies/{display-guid}
        public Display Post([FromBody]Display display)
        {
            if (display.DisplayId == Guid.Empty) display.DisplayId = Guid.NewGuid();
            this.OnBeforePost(display);
            this.SDM.Upsert(display);
            this.OnAfterPost(display);
            return display;
        }

        // POST api/Displaies/{display-guid}
        public Display Put([FromBody]Display display)
        {
            if (display.DisplayId == Guid.Empty) display.DisplayId = Guid.NewGuid();
            this.OnBeforePut(display);
            this.SDM.Upsert(display);
            this.OnAfterPut(display);
            return display;
        }

        // POST api/Displaies/{display-guid}
        public void Delete(Guid displayId)
        {
            var displayWhere = String.Format("DisplayId = '{0}'", displayId);
            var display = this.SDM.GetAllDisplaies<Display>(displayWhere).FirstOrDefault();
            this.OnBeforeDelete(display);
            this.SDM.Delete(display);
            this.OnAfterDelete(display);
        }
    }
}
