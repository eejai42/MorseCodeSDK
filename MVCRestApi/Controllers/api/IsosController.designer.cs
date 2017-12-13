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
    public partial class IsosController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Iso> Isos);
        partial void OnAfterGetById(Iso Isos, Guid isoId);
        partial void OnBeforePost(Iso iso);
        partial void OnAfterPost(Iso iso);
        partial void OnBeforePut(Iso iso);
        partial void OnAfterPut(Iso iso);
        partial void OnBeforeDelete(Iso iso);
        partial void OnAfterDelete(Iso iso);
        

        public IsosController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Iso
        public IEnumerable<Iso> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllIsos<Iso>();
            Iso.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Isos/{iso-guid}
        public Iso Get(Guid isoId)
        {
            var IsosWhere = String.Format("IsoId = '{0}'", isoId);
            var result = this.SDM.GetAllIsos<Iso>(IsosWhere).FirstOrDefault();
            this.OnAfterGetById(result, isoId);
            return result;
        }

        // POST api/Isos/{iso-guid}
        public Iso Post([FromBody]Iso iso)
        {
            if (iso.IsoId == Guid.Empty) iso.IsoId = Guid.NewGuid();
            this.OnBeforePost(iso);
            this.SDM.Upsert(iso);
            this.OnAfterPost(iso);
            return iso;
        }

        // POST api/Isos/{iso-guid}
        public Iso Put([FromBody]Iso iso)
        {
            if (iso.IsoId == Guid.Empty) iso.IsoId = Guid.NewGuid();
            this.OnBeforePut(iso);
            this.SDM.Upsert(iso);
            this.OnAfterPut(iso);
            return iso;
        }

        // POST api/Isos/{iso-guid}
        public void Delete(Guid isoId)
        {
            var isoWhere = String.Format("IsoId = '{0}'", isoId);
            var iso = this.SDM.GetAllIsos<Iso>(isoWhere).FirstOrDefault();
            this.OnBeforeDelete(iso);
            this.SDM.Delete(iso);
            this.OnAfterDelete(iso);
        }
    }
}
