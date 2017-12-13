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
    public partial class ObserversController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Observer> Observers);
        partial void OnAfterGetById(Observer Observers, Guid observerId);
        partial void OnBeforePost(Observer observer);
        partial void OnAfterPost(Observer observer);
        partial void OnBeforePut(Observer observer);
        partial void OnAfterPut(Observer observer);
        partial void OnBeforeDelete(Observer observer);
        partial void OnAfterDelete(Observer observer);
        

        public ObserversController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Observer
        public IEnumerable<Observer> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllObservers<Observer>();
            Observer.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Observers/{observer-guid}
        public Observer Get(Guid observerId)
        {
            var ObserversWhere = String.Format("ObserverId = '{0}'", observerId);
            var result = this.SDM.GetAllObservers<Observer>(ObserversWhere).FirstOrDefault();
            this.OnAfterGetById(result, observerId);
            return result;
        }

        // POST api/Observers/{observer-guid}
        public Observer Post([FromBody]Observer observer)
        {
            if (observer.ObserverId == Guid.Empty) observer.ObserverId = Guid.NewGuid();
            this.OnBeforePost(observer);
            this.SDM.Upsert(observer);
            this.OnAfterPost(observer);
            return observer;
        }

        // POST api/Observers/{observer-guid}
        public Observer Put([FromBody]Observer observer)
        {
            if (observer.ObserverId == Guid.Empty) observer.ObserverId = Guid.NewGuid();
            this.OnBeforePut(observer);
            this.SDM.Upsert(observer);
            this.OnAfterPut(observer);
            return observer;
        }

        // POST api/Observers/{observer-guid}
        public void Delete(Guid observerId)
        {
            var observerWhere = String.Format("ObserverId = '{0}'", observerId);
            var observer = this.SDM.GetAllObservers<Observer>(observerWhere).FirstOrDefault();
            this.OnBeforeDelete(observer);
            this.SDM.Delete(observer);
            this.OnAfterDelete(observer);
        }
    }
}
