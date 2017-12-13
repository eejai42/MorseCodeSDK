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
    public partial class SpeechsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Speech> Speechs);
        partial void OnAfterGetById(Speech Speechs, Guid speechId);
        partial void OnBeforePost(Speech speech);
        partial void OnAfterPost(Speech speech);
        partial void OnBeforePut(Speech speech);
        partial void OnAfterPut(Speech speech);
        partial void OnBeforeDelete(Speech speech);
        partial void OnAfterDelete(Speech speech);
        

        public SpeechsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Speech
        public IEnumerable<Speech> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSpeechs<Speech>();
            Speech.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Speechs/{speech-guid}
        public Speech Get(Guid speechId)
        {
            var SpeechsWhere = String.Format("SpeechId = '{0}'", speechId);
            var result = this.SDM.GetAllSpeechs<Speech>(SpeechsWhere).FirstOrDefault();
            this.OnAfterGetById(result, speechId);
            return result;
        }

        // POST api/Speechs/{speech-guid}
        public Speech Post([FromBody]Speech speech)
        {
            if (speech.SpeechId == Guid.Empty) speech.SpeechId = Guid.NewGuid();
            this.OnBeforePost(speech);
            this.SDM.Upsert(speech);
            this.OnAfterPost(speech);
            return speech;
        }

        // POST api/Speechs/{speech-guid}
        public Speech Put([FromBody]Speech speech)
        {
            if (speech.SpeechId == Guid.Empty) speech.SpeechId = Guid.NewGuid();
            this.OnBeforePut(speech);
            this.SDM.Upsert(speech);
            this.OnAfterPut(speech);
            return speech;
        }

        // POST api/Speechs/{speech-guid}
        public void Delete(Guid speechId)
        {
            var speechWhere = String.Format("SpeechId = '{0}'", speechId);
            var speech = this.SDM.GetAllSpeechs<Speech>(speechWhere).FirstOrDefault();
            this.OnBeforeDelete(speech);
            this.SDM.Delete(speech);
            this.OnAfterDelete(speech);
        }
    }
}
