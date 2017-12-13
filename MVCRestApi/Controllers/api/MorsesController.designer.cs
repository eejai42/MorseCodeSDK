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
    public partial class MorsesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Morse> Morses);
        partial void OnAfterGetById(Morse Morses, Guid morseId);
        partial void OnBeforePost(Morse morse);
        partial void OnAfterPost(Morse morse);
        partial void OnBeforePut(Morse morse);
        partial void OnAfterPut(Morse morse);
        partial void OnBeforeDelete(Morse morse);
        partial void OnAfterDelete(Morse morse);
        

        public MorsesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Morse
        public IEnumerable<Morse> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllMorses<Morse>();
            Morse.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Morses/{morse-guid}
        public Morse Get(Guid morseId)
        {
            var MorsesWhere = String.Format("MorseId = '{0}'", morseId);
            var result = this.SDM.GetAllMorses<Morse>(MorsesWhere).FirstOrDefault();
            this.OnAfterGetById(result, morseId);
            return result;
        }

        // POST api/Morses/{morse-guid}
        public Morse Post([FromBody]Morse morse)
        {
            if (morse.MorseId == Guid.Empty) morse.MorseId = Guid.NewGuid();
            this.OnBeforePost(morse);
            this.SDM.Upsert(morse);
            this.OnAfterPost(morse);
            return morse;
        }

        // POST api/Morses/{morse-guid}
        public Morse Put([FromBody]Morse morse)
        {
            if (morse.MorseId == Guid.Empty) morse.MorseId = Guid.NewGuid();
            this.OnBeforePut(morse);
            this.SDM.Upsert(morse);
            this.OnAfterPut(morse);
            return morse;
        }

        // POST api/Morses/{morse-guid}
        public void Delete(Guid morseId)
        {
            var morseWhere = String.Format("MorseId = '{0}'", morseId);
            var morse = this.SDM.GetAllMorses<Morse>(morseWhere).FirstOrDefault();
            this.OnBeforeDelete(morse);
            this.SDM.Delete(morse);
            this.OnAfterDelete(morse);
        }
    }
}
