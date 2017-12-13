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
    public partial class ItursController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Itur> Iturs);
        partial void OnAfterGetById(Itur Iturs, Guid iturId);
        partial void OnBeforePost(Itur itur);
        partial void OnAfterPost(Itur itur);
        partial void OnBeforePut(Itur itur);
        partial void OnAfterPut(Itur itur);
        partial void OnBeforeDelete(Itur itur);
        partial void OnAfterDelete(Itur itur);
        

        public ItursController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Itur
        public IEnumerable<Itur> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllIturs<Itur>();
            Itur.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Iturs/{itur-guid}
        public Itur Get(Guid iturId)
        {
            var ItursWhere = String.Format("IturId = '{0}'", iturId);
            var result = this.SDM.GetAllIturs<Itur>(ItursWhere).FirstOrDefault();
            this.OnAfterGetById(result, iturId);
            return result;
        }

        // POST api/Iturs/{itur-guid}
        public Itur Post([FromBody]Itur itur)
        {
            if (itur.IturId == Guid.Empty) itur.IturId = Guid.NewGuid();
            this.OnBeforePost(itur);
            this.SDM.Upsert(itur);
            this.OnAfterPost(itur);
            return itur;
        }

        // POST api/Iturs/{itur-guid}
        public Itur Put([FromBody]Itur itur)
        {
            if (itur.IturId == Guid.Empty) itur.IturId = Guid.NewGuid();
            this.OnBeforePut(itur);
            this.SDM.Upsert(itur);
            this.OnAfterPut(itur);
            return itur;
        }

        // POST api/Iturs/{itur-guid}
        public void Delete(Guid iturId)
        {
            var iturWhere = String.Format("IturId = '{0}'", iturId);
            var itur = this.SDM.GetAllIturs<Itur>(iturWhere).FirstOrDefault();
            this.OnBeforeDelete(itur);
            this.SDM.Delete(itur);
            this.OnAfterDelete(itur);
        }
    }
}
