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
    public partial class ControllersController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Controller> Controllers);
        partial void OnAfterGetById(Controller Controllers, Guid controllerId);
        partial void OnBeforePost(Controller controller);
        partial void OnAfterPost(Controller controller);
        partial void OnBeforePut(Controller controller);
        partial void OnAfterPut(Controller controller);
        partial void OnBeforeDelete(Controller controller);
        partial void OnAfterDelete(Controller controller);
        

        public ControllersController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Controller
        public IEnumerable<Controller> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllControllers<Controller>();
            Controller.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Controllers/{controller-guid}
        public Controller Get(Guid controllerId)
        {
            var ControllersWhere = String.Format("ControllerId = '{0}'", controllerId);
            var result = this.SDM.GetAllControllers<Controller>(ControllersWhere).FirstOrDefault();
            this.OnAfterGetById(result, controllerId);
            return result;
        }

        // POST api/Controllers/{controller-guid}
        public Controller Post([FromBody]Controller controller)
        {
            if (controller.ControllerId == Guid.Empty) controller.ControllerId = Guid.NewGuid();
            this.OnBeforePost(controller);
            this.SDM.Upsert(controller);
            this.OnAfterPost(controller);
            return controller;
        }

        // POST api/Controllers/{controller-guid}
        public Controller Put([FromBody]Controller controller)
        {
            if (controller.ControllerId == Guid.Empty) controller.ControllerId = Guid.NewGuid();
            this.OnBeforePut(controller);
            this.SDM.Upsert(controller);
            this.OnAfterPut(controller);
            return controller;
        }

        // POST api/Controllers/{controller-guid}
        public void Delete(Guid controllerId)
        {
            var controllerWhere = String.Format("ControllerId = '{0}'", controllerId);
            var controller = this.SDM.GetAllControllers<Controller>(controllerWhere).FirstOrDefault();
            this.OnBeforeDelete(controller);
            this.SDM.Delete(controller);
            this.OnAfterDelete(controller);
        }
    }
}
