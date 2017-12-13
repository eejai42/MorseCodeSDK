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
    public partial class SequencesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Sequence> Sequences);
        partial void OnAfterGetById(Sequence Sequences, Guid sequenceId);
        partial void OnBeforePost(Sequence sequence);
        partial void OnAfterPost(Sequence sequence);
        partial void OnBeforePut(Sequence sequence);
        partial void OnAfterPut(Sequence sequence);
        partial void OnBeforeDelete(Sequence sequence);
        partial void OnAfterDelete(Sequence sequence);
        

        public SequencesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Sequence
        public IEnumerable<Sequence> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSequences<Sequence>();
            Sequence.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Sequences/{sequence-guid}
        public Sequence Get(Guid sequenceId)
        {
            var SequencesWhere = String.Format("SequenceId = '{0}'", sequenceId);
            var result = this.SDM.GetAllSequences<Sequence>(SequencesWhere).FirstOrDefault();
            this.OnAfterGetById(result, sequenceId);
            return result;
        }

        // POST api/Sequences/{sequence-guid}
        public Sequence Post([FromBody]Sequence sequence)
        {
            if (sequence.SequenceId == Guid.Empty) sequence.SequenceId = Guid.NewGuid();
            this.OnBeforePost(sequence);
            this.SDM.Upsert(sequence);
            this.OnAfterPost(sequence);
            return sequence;
        }

        // POST api/Sequences/{sequence-guid}
        public Sequence Put([FromBody]Sequence sequence)
        {
            if (sequence.SequenceId == Guid.Empty) sequence.SequenceId = Guid.NewGuid();
            this.OnBeforePut(sequence);
            this.SDM.Upsert(sequence);
            this.OnAfterPut(sequence);
            return sequence;
        }

        // POST api/Sequences/{sequence-guid}
        public void Delete(Guid sequenceId)
        {
            var sequenceWhere = String.Format("SequenceId = '{0}'", sequenceId);
            var sequence = this.SDM.GetAllSequences<Sequence>(sequenceWhere).FirstOrDefault();
            this.OnBeforeDelete(sequence);
            this.SDM.Delete(sequence);
            this.OnAfterDelete(sequence);
        }
    }
}
