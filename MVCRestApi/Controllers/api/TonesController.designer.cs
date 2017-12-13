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
    public partial class TonesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Tone> Tones);
        partial void OnAfterGetById(Tone Tones, Guid toneId);
        partial void OnBeforePost(Tone tone);
        partial void OnAfterPost(Tone tone);
        partial void OnBeforePut(Tone tone);
        partial void OnAfterPut(Tone tone);
        partial void OnBeforeDelete(Tone tone);
        partial void OnAfterDelete(Tone tone);
        

        public TonesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Tone
        public IEnumerable<Tone> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllTones<Tone>();
            Tone.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Tones/{tone-guid}
        public Tone Get(Guid toneId)
        {
            var TonesWhere = String.Format("ToneId = '{0}'", toneId);
            var result = this.SDM.GetAllTones<Tone>(TonesWhere).FirstOrDefault();
            this.OnAfterGetById(result, toneId);
            return result;
        }

        // POST api/Tones/{tone-guid}
        public Tone Post([FromBody]Tone tone)
        {
            if (tone.ToneId == Guid.Empty) tone.ToneId = Guid.NewGuid();
            this.OnBeforePost(tone);
            this.SDM.Upsert(tone);
            this.OnAfterPost(tone);
            return tone;
        }

        // POST api/Tones/{tone-guid}
        public Tone Put([FromBody]Tone tone)
        {
            if (tone.ToneId == Guid.Empty) tone.ToneId = Guid.NewGuid();
            this.OnBeforePut(tone);
            this.SDM.Upsert(tone);
            this.OnAfterPut(tone);
            return tone;
        }

        // POST api/Tones/{tone-guid}
        public void Delete(Guid toneId)
        {
            var toneWhere = String.Format("ToneId = '{0}'", toneId);
            var tone = this.SDM.GetAllTones<Tone>(toneWhere).FirstOrDefault();
            this.OnBeforeDelete(tone);
            this.SDM.Delete(tone);
            this.OnAfterDelete(tone);
        }
    }
}
