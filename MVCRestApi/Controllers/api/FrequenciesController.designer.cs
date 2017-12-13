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
    public partial class FrequenciesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Frequency> Frequencies);
        partial void OnAfterGetById(Frequency Frequencies, Guid frequencyId);
        partial void OnBeforePost(Frequency frequency);
        partial void OnAfterPost(Frequency frequency);
        partial void OnBeforePut(Frequency frequency);
        partial void OnAfterPut(Frequency frequency);
        partial void OnBeforeDelete(Frequency frequency);
        partial void OnAfterDelete(Frequency frequency);
        

        public FrequenciesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Frequency
        public IEnumerable<Frequency> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllFrequencies<Frequency>();
            Frequency.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Frequencies/{frequency-guid}
        public Frequency Get(Guid frequencyId)
        {
            var FrequenciesWhere = String.Format("FrequencyId = '{0}'", frequencyId);
            var result = this.SDM.GetAllFrequencies<Frequency>(FrequenciesWhere).FirstOrDefault();
            this.OnAfterGetById(result, frequencyId);
            return result;
        }

        // POST api/Frequencies/{frequency-guid}
        public Frequency Post([FromBody]Frequency frequency)
        {
            if (frequency.FrequencyId == Guid.Empty) frequency.FrequencyId = Guid.NewGuid();
            this.OnBeforePost(frequency);
            this.SDM.Upsert(frequency);
            this.OnAfterPost(frequency);
            return frequency;
        }

        // POST api/Frequencies/{frequency-guid}
        public Frequency Put([FromBody]Frequency frequency)
        {
            if (frequency.FrequencyId == Guid.Empty) frequency.FrequencyId = Guid.NewGuid();
            this.OnBeforePut(frequency);
            this.SDM.Upsert(frequency);
            this.OnAfterPut(frequency);
            return frequency;
        }

        // POST api/Frequencies/{frequency-guid}
        public void Delete(Guid frequencyId)
        {
            var frequencyWhere = String.Format("FrequencyId = '{0}'", frequencyId);
            var frequency = this.SDM.GetAllFrequencies<Frequency>(frequencyWhere).FirstOrDefault();
            this.OnBeforeDelete(frequency);
            this.SDM.Delete(frequency);
            this.OnAfterDelete(frequency);
        }
    }
}
