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
    public partial class IsobasiclatinalphabetsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Isobasiclatinalphabet> Isobasiclatinalphabets);
        partial void OnAfterGetById(Isobasiclatinalphabet Isobasiclatinalphabets, Guid isobasiclatinalphabetId);
        partial void OnBeforePost(Isobasiclatinalphabet isobasiclatinalphabet);
        partial void OnAfterPost(Isobasiclatinalphabet isobasiclatinalphabet);
        partial void OnBeforePut(Isobasiclatinalphabet isobasiclatinalphabet);
        partial void OnAfterPut(Isobasiclatinalphabet isobasiclatinalphabet);
        partial void OnBeforeDelete(Isobasiclatinalphabet isobasiclatinalphabet);
        partial void OnAfterDelete(Isobasiclatinalphabet isobasiclatinalphabet);
        

        public IsobasiclatinalphabetsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Isobasiclatinalphabet
        public IEnumerable<Isobasiclatinalphabet> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllIsobasiclatinalphabets<Isobasiclatinalphabet>();
            Isobasiclatinalphabet.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Isobasiclatinalphabets/{isobasiclatinalphabet-guid}
        public Isobasiclatinalphabet Get(Guid isobasiclatinalphabetId)
        {
            var IsobasiclatinalphabetsWhere = String.Format("IsobasiclatinalphabetId = '{0}'", isobasiclatinalphabetId);
            var result = this.SDM.GetAllIsobasiclatinalphabets<Isobasiclatinalphabet>(IsobasiclatinalphabetsWhere).FirstOrDefault();
            this.OnAfterGetById(result, isobasiclatinalphabetId);
            return result;
        }

        // POST api/Isobasiclatinalphabets/{isobasiclatinalphabet-guid}
        public Isobasiclatinalphabet Post([FromBody]Isobasiclatinalphabet isobasiclatinalphabet)
        {
            if (isobasiclatinalphabet.IsobasiclatinalphabetId == Guid.Empty) isobasiclatinalphabet.IsobasiclatinalphabetId = Guid.NewGuid();
            this.OnBeforePost(isobasiclatinalphabet);
            this.SDM.Upsert(isobasiclatinalphabet);
            this.OnAfterPost(isobasiclatinalphabet);
            return isobasiclatinalphabet;
        }

        // POST api/Isobasiclatinalphabets/{isobasiclatinalphabet-guid}
        public Isobasiclatinalphabet Put([FromBody]Isobasiclatinalphabet isobasiclatinalphabet)
        {
            if (isobasiclatinalphabet.IsobasiclatinalphabetId == Guid.Empty) isobasiclatinalphabet.IsobasiclatinalphabetId = Guid.NewGuid();
            this.OnBeforePut(isobasiclatinalphabet);
            this.SDM.Upsert(isobasiclatinalphabet);
            this.OnAfterPut(isobasiclatinalphabet);
            return isobasiclatinalphabet;
        }

        // POST api/Isobasiclatinalphabets/{isobasiclatinalphabet-guid}
        public void Delete(Guid isobasiclatinalphabetId)
        {
            var isobasiclatinalphabetWhere = String.Format("IsobasiclatinalphabetId = '{0}'", isobasiclatinalphabetId);
            var isobasiclatinalphabet = this.SDM.GetAllIsobasiclatinalphabets<Isobasiclatinalphabet>(isobasiclatinalphabetWhere).FirstOrDefault();
            this.OnBeforeDelete(isobasiclatinalphabet);
            this.SDM.Delete(isobasiclatinalphabet);
            this.OnAfterDelete(isobasiclatinalphabet);
        }
    }
}
