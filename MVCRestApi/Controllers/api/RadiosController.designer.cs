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
    public partial class RadiosController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Radio> Radios);
        partial void OnAfterGetById(Radio Radios, Guid radioId);
        partial void OnBeforePost(Radio radio);
        partial void OnAfterPost(Radio radio);
        partial void OnBeforePut(Radio radio);
        partial void OnAfterPut(Radio radio);
        partial void OnBeforeDelete(Radio radio);
        partial void OnAfterDelete(Radio radio);
        

        public RadiosController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Radio
        public IEnumerable<Radio> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllRadios<Radio>();
            Radio.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Radios/{radio-guid}
        public Radio Get(Guid radioId)
        {
            var RadiosWhere = String.Format("RadioId = '{0}'", radioId);
            var result = this.SDM.GetAllRadios<Radio>(RadiosWhere).FirstOrDefault();
            this.OnAfterGetById(result, radioId);
            return result;
        }

        // POST api/Radios/{radio-guid}
        public Radio Post([FromBody]Radio radio)
        {
            if (radio.RadioId == Guid.Empty) radio.RadioId = Guid.NewGuid();
            this.OnBeforePost(radio);
            this.SDM.Upsert(radio);
            this.OnAfterPost(radio);
            return radio;
        }

        // POST api/Radios/{radio-guid}
        public Radio Put([FromBody]Radio radio)
        {
            if (radio.RadioId == Guid.Empty) radio.RadioId = Guid.NewGuid();
            this.OnBeforePut(radio);
            this.SDM.Upsert(radio);
            this.OnAfterPut(radio);
            return radio;
        }

        // POST api/Radios/{radio-guid}
        public void Delete(Guid radioId)
        {
            var radioWhere = String.Format("RadioId = '{0}'", radioId);
            var radio = this.SDM.GetAllRadios<Radio>(radioWhere).FirstOrDefault();
            this.OnBeforeDelete(radio);
            this.SDM.Delete(radio);
            this.OnAfterDelete(radio);
        }
    }
}
