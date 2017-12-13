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
    public partial class ArabicnumeralsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Arabicnumeral> Arabicnumerals);
        partial void OnAfterGetById(Arabicnumeral Arabicnumerals, Guid arabicnumeralId);
        partial void OnBeforePost(Arabicnumeral arabicnumeral);
        partial void OnAfterPost(Arabicnumeral arabicnumeral);
        partial void OnBeforePut(Arabicnumeral arabicnumeral);
        partial void OnAfterPut(Arabicnumeral arabicnumeral);
        partial void OnBeforeDelete(Arabicnumeral arabicnumeral);
        partial void OnAfterDelete(Arabicnumeral arabicnumeral);
        

        public ArabicnumeralsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Arabicnumeral
        public IEnumerable<Arabicnumeral> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllArabicnumerals<Arabicnumeral>();
            Arabicnumeral.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Arabicnumerals/{arabicnumeral-guid}
        public Arabicnumeral Get(Guid arabicnumeralId)
        {
            var ArabicnumeralsWhere = String.Format("ArabicnumeralId = '{0}'", arabicnumeralId);
            var result = this.SDM.GetAllArabicnumerals<Arabicnumeral>(ArabicnumeralsWhere).FirstOrDefault();
            this.OnAfterGetById(result, arabicnumeralId);
            return result;
        }

        // POST api/Arabicnumerals/{arabicnumeral-guid}
        public Arabicnumeral Post([FromBody]Arabicnumeral arabicnumeral)
        {
            if (arabicnumeral.ArabicnumeralId == Guid.Empty) arabicnumeral.ArabicnumeralId = Guid.NewGuid();
            this.OnBeforePost(arabicnumeral);
            this.SDM.Upsert(arabicnumeral);
            this.OnAfterPost(arabicnumeral);
            return arabicnumeral;
        }

        // POST api/Arabicnumerals/{arabicnumeral-guid}
        public Arabicnumeral Put([FromBody]Arabicnumeral arabicnumeral)
        {
            if (arabicnumeral.ArabicnumeralId == Guid.Empty) arabicnumeral.ArabicnumeralId = Guid.NewGuid();
            this.OnBeforePut(arabicnumeral);
            this.SDM.Upsert(arabicnumeral);
            this.OnAfterPut(arabicnumeral);
            return arabicnumeral;
        }

        // POST api/Arabicnumerals/{arabicnumeral-guid}
        public void Delete(Guid arabicnumeralId)
        {
            var arabicnumeralWhere = String.Format("ArabicnumeralId = '{0}'", arabicnumeralId);
            var arabicnumeral = this.SDM.GetAllArabicnumerals<Arabicnumeral>(arabicnumeralWhere).FirstOrDefault();
            this.OnBeforeDelete(arabicnumeral);
            this.SDM.Delete(arabicnumeral);
            this.OnAfterDelete(arabicnumeral);
        }
    }
}
