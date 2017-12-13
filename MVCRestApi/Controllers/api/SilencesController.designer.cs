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
    public partial class SilencesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Silence> Silences);
        partial void OnAfterGetById(Silence Silences, Guid silenceId);
        partial void OnBeforePost(Silence silence);
        partial void OnAfterPost(Silence silence);
        partial void OnBeforePut(Silence silence);
        partial void OnAfterPut(Silence silence);
        partial void OnBeforeDelete(Silence silence);
        partial void OnAfterDelete(Silence silence);
        

        public SilencesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Silence
        public IEnumerable<Silence> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSilences<Silence>();
            Silence.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Silences/{silence-guid}
        public Silence Get(Guid silenceId)
        {
            var SilencesWhere = String.Format("SilenceId = '{0}'", silenceId);
            var result = this.SDM.GetAllSilences<Silence>(SilencesWhere).FirstOrDefault();
            this.OnAfterGetById(result, silenceId);
            return result;
        }

        // POST api/Silences/{silence-guid}
        public Silence Post([FromBody]Silence silence)
        {
            if (silence.SilenceId == Guid.Empty) silence.SilenceId = Guid.NewGuid();
            this.OnBeforePost(silence);
            this.SDM.Upsert(silence);
            this.OnAfterPost(silence);
            return silence;
        }

        // POST api/Silences/{silence-guid}
        public Silence Put([FromBody]Silence silence)
        {
            if (silence.SilenceId == Guid.Empty) silence.SilenceId = Guid.NewGuid();
            this.OnBeforePut(silence);
            this.SDM.Upsert(silence);
            this.OnAfterPut(silence);
            return silence;
        }

        // POST api/Silences/{silence-guid}
        public void Delete(Guid silenceId)
        {
            var silenceWhere = String.Format("SilenceId = '{0}'", silenceId);
            var silence = this.SDM.GetAllSilences<Silence>(silenceWhere).FirstOrDefault();
            this.OnBeforeDelete(silence);
            this.SDM.Delete(silence);
            this.OnAfterDelete(silence);
        }
    }
}
