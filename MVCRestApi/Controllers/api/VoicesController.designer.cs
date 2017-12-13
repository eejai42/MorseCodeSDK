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
    public partial class VoicesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Voice> Voices);
        partial void OnAfterGetById(Voice Voices, Guid voiceId);
        partial void OnBeforePost(Voice voice);
        partial void OnAfterPost(Voice voice);
        partial void OnBeforePut(Voice voice);
        partial void OnAfterPut(Voice voice);
        partial void OnBeforeDelete(Voice voice);
        partial void OnAfterDelete(Voice voice);
        

        public VoicesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Voice
        public IEnumerable<Voice> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllVoices<Voice>();
            Voice.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Voices/{voice-guid}
        public Voice Get(Guid voiceId)
        {
            var VoicesWhere = String.Format("VoiceId = '{0}'", voiceId);
            var result = this.SDM.GetAllVoices<Voice>(VoicesWhere).FirstOrDefault();
            this.OnAfterGetById(result, voiceId);
            return result;
        }

        // POST api/Voices/{voice-guid}
        public Voice Post([FromBody]Voice voice)
        {
            if (voice.VoiceId == Guid.Empty) voice.VoiceId = Guid.NewGuid();
            this.OnBeforePost(voice);
            this.SDM.Upsert(voice);
            this.OnAfterPost(voice);
            return voice;
        }

        // POST api/Voices/{voice-guid}
        public Voice Put([FromBody]Voice voice)
        {
            if (voice.VoiceId == Guid.Empty) voice.VoiceId = Guid.NewGuid();
            this.OnBeforePut(voice);
            this.SDM.Upsert(voice);
            this.OnAfterPut(voice);
            return voice;
        }

        // POST api/Voices/{voice-guid}
        public void Delete(Guid voiceId)
        {
            var voiceWhere = String.Format("VoiceId = '{0}'", voiceId);
            var voice = this.SDM.GetAllVoices<Voice>(voiceWhere).FirstOrDefault();
            this.OnBeforeDelete(voice);
            this.SDM.Delete(voice);
            this.OnAfterDelete(voice);
        }
    }
}
