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
    public partial class NumeralsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Numeral> Numerals);
        partial void OnAfterGetById(Numeral Numerals, Guid numeralId);
        partial void OnBeforePost(Numeral numeral);
        partial void OnAfterPost(Numeral numeral);
        partial void OnBeforePut(Numeral numeral);
        partial void OnAfterPut(Numeral numeral);
        partial void OnBeforeDelete(Numeral numeral);
        partial void OnAfterDelete(Numeral numeral);
        

        public NumeralsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Numeral
        public IEnumerable<Numeral> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllNumerals<Numeral>();
            Numeral.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Numerals/{numeral-guid}
        public Numeral Get(Guid numeralId)
        {
            var NumeralsWhere = String.Format("NumeralId = '{0}'", numeralId);
            var result = this.SDM.GetAllNumerals<Numeral>(NumeralsWhere).FirstOrDefault();
            this.OnAfterGetById(result, numeralId);
            return result;
        }

        // POST api/Numerals/{numeral-guid}
        public Numeral Post([FromBody]Numeral numeral)
        {
            if (numeral.NumeralId == Guid.Empty) numeral.NumeralId = Guid.NewGuid();
            this.OnBeforePost(numeral);
            this.SDM.Upsert(numeral);
            this.OnAfterPost(numeral);
            return numeral;
        }

        // POST api/Numerals/{numeral-guid}
        public Numeral Put([FromBody]Numeral numeral)
        {
            if (numeral.NumeralId == Guid.Empty) numeral.NumeralId = Guid.NewGuid();
            this.OnBeforePut(numeral);
            this.SDM.Upsert(numeral);
            this.OnAfterPut(numeral);
            return numeral;
        }

        // POST api/Numerals/{numeral-guid}
        public void Delete(Guid numeralId)
        {
            var numeralWhere = String.Format("NumeralId = '{0}'", numeralId);
            var numeral = this.SDM.GetAllNumerals<Numeral>(numeralWhere).FirstOrDefault();
            this.OnBeforeDelete(numeral);
            this.SDM.Delete(numeral);
            this.OnAfterDelete(numeral);
        }
    }
}
