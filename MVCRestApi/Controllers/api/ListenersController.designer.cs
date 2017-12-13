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
    public partial class ListenersController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Listener> Listeners);
        partial void OnAfterGetById(Listener Listeners, Guid listenerId);
        partial void OnBeforePost(Listener listener);
        partial void OnAfterPost(Listener listener);
        partial void OnBeforePut(Listener listener);
        partial void OnAfterPut(Listener listener);
        partial void OnBeforeDelete(Listener listener);
        partial void OnAfterDelete(Listener listener);
        

        public ListenersController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Listener
        public IEnumerable<Listener> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllListeners<Listener>();
            Listener.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Listeners/{listener-guid}
        public Listener Get(Guid listenerId)
        {
            var ListenersWhere = String.Format("ListenerId = '{0}'", listenerId);
            var result = this.SDM.GetAllListeners<Listener>(ListenersWhere).FirstOrDefault();
            this.OnAfterGetById(result, listenerId);
            return result;
        }

        // POST api/Listeners/{listener-guid}
        public Listener Post([FromBody]Listener listener)
        {
            if (listener.ListenerId == Guid.Empty) listener.ListenerId = Guid.NewGuid();
            this.OnBeforePost(listener);
            this.SDM.Upsert(listener);
            this.OnAfterPost(listener);
            return listener;
        }

        // POST api/Listeners/{listener-guid}
        public Listener Put([FromBody]Listener listener)
        {
            if (listener.ListenerId == Guid.Empty) listener.ListenerId = Guid.NewGuid();
            this.OnBeforePut(listener);
            this.SDM.Upsert(listener);
            this.OnAfterPut(listener);
            return listener;
        }

        // POST api/Listeners/{listener-guid}
        public void Delete(Guid listenerId)
        {
            var listenerWhere = String.Format("ListenerId = '{0}'", listenerId);
            var listener = this.SDM.GetAllListeners<Listener>(listenerWhere).FirstOrDefault();
            this.OnBeforeDelete(listener);
            this.SDM.Delete(listener);
            this.OnAfterDelete(listener);
        }
    }
}
