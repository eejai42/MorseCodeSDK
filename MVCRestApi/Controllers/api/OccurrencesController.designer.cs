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
    public partial class OccurrencesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Occurrence> Occurrences);
        partial void OnAfterGetById(Occurrence Occurrences, Guid occurrenceId);
        partial void OnBeforePost(Occurrence occurrence);
        partial void OnAfterPost(Occurrence occurrence);
        partial void OnBeforePut(Occurrence occurrence);
        partial void OnAfterPut(Occurrence occurrence);
        partial void OnBeforeDelete(Occurrence occurrence);
        partial void OnAfterDelete(Occurrence occurrence);
        

        public OccurrencesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Occurrence
        public IEnumerable<Occurrence> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllOccurrences<Occurrence>();
            Occurrence.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Occurrences/{occurrence-guid}
        public Occurrence Get(Guid occurrenceId)
        {
            var OccurrencesWhere = String.Format("OccurrenceId = '{0}'", occurrenceId);
            var result = this.SDM.GetAllOccurrences<Occurrence>(OccurrencesWhere).FirstOrDefault();
            this.OnAfterGetById(result, occurrenceId);
            return result;
        }

        // POST api/Occurrences/{occurrence-guid}
        public Occurrence Post([FromBody]Occurrence occurrence)
        {
            if (occurrence.OccurrenceId == Guid.Empty) occurrence.OccurrenceId = Guid.NewGuid();
            this.OnBeforePost(occurrence);
            this.SDM.Upsert(occurrence);
            this.OnAfterPost(occurrence);
            return occurrence;
        }

        // POST api/Occurrences/{occurrence-guid}
        public Occurrence Put([FromBody]Occurrence occurrence)
        {
            if (occurrence.OccurrenceId == Guid.Empty) occurrence.OccurrenceId = Guid.NewGuid();
            this.OnBeforePut(occurrence);
            this.SDM.Upsert(occurrence);
            this.OnAfterPut(occurrence);
            return occurrence;
        }

        // POST api/Occurrences/{occurrence-guid}
        public void Delete(Guid occurrenceId)
        {
            var occurrenceWhere = String.Format("OccurrenceId = '{0}'", occurrenceId);
            var occurrence = this.SDM.GetAllOccurrences<Occurrence>(occurrenceWhere).FirstOrDefault();
            this.OnBeforeDelete(occurrence);
            this.SDM.Delete(occurrence);
            this.OnAfterDelete(occurrence);
        }
    }
}
