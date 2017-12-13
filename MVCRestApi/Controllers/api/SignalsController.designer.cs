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
    public partial class SignalsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Signal> Signals);
        partial void OnAfterGetById(Signal Signals, Guid signalId);
        partial void OnBeforePost(Signal signal);
        partial void OnAfterPost(Signal signal);
        partial void OnBeforePut(Signal signal);
        partial void OnAfterPut(Signal signal);
        partial void OnBeforeDelete(Signal signal);
        partial void OnAfterDelete(Signal signal);
        

        public SignalsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Signal
        public IEnumerable<Signal> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSignals<Signal>();
            Signal.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Signals/{signal-guid}
        public Signal Get(Guid signalId)
        {
            var SignalsWhere = String.Format("SignalId = '{0}'", signalId);
            var result = this.SDM.GetAllSignals<Signal>(SignalsWhere).FirstOrDefault();
            this.OnAfterGetById(result, signalId);
            return result;
        }

        // POST api/Signals/{signal-guid}
        public Signal Post([FromBody]Signal signal)
        {
            if (signal.SignalId == Guid.Empty) signal.SignalId = Guid.NewGuid();
            this.OnBeforePost(signal);
            this.SDM.Upsert(signal);
            this.OnAfterPost(signal);
            return signal;
        }

        // POST api/Signals/{signal-guid}
        public Signal Put([FromBody]Signal signal)
        {
            if (signal.SignalId == Guid.Empty) signal.SignalId = Guid.NewGuid();
            this.OnBeforePut(signal);
            this.SDM.Upsert(signal);
            this.OnAfterPut(signal);
            return signal;
        }

        // POST api/Signals/{signal-guid}
        public void Delete(Guid signalId)
        {
            var signalWhere = String.Format("SignalId = '{0}'", signalId);
            var signal = this.SDM.GetAllSignals<Signal>(signalWhere).FirstOrDefault();
            this.OnBeforeDelete(signal);
            this.SDM.Delete(signal);
            this.OnAfterDelete(signal);
        }
    }
}
