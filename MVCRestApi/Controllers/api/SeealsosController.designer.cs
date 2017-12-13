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
    public partial class SeealsosController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Seealso> Seealsos);
        partial void OnAfterGetById(Seealso Seealsos, Guid seealsoId);
        partial void OnBeforePost(Seealso seealso);
        partial void OnAfterPost(Seealso seealso);
        partial void OnBeforePut(Seealso seealso);
        partial void OnAfterPut(Seealso seealso);
        partial void OnBeforeDelete(Seealso seealso);
        partial void OnAfterDelete(Seealso seealso);
        

        public SeealsosController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Seealso
        public IEnumerable<Seealso> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSeealsos<Seealso>();
            Seealso.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Seealsos/{seealso-guid}
        public Seealso Get(Guid seealsoId)
        {
            var SeealsosWhere = String.Format("SeealsoId = '{0}'", seealsoId);
            var result = this.SDM.GetAllSeealsos<Seealso>(SeealsosWhere).FirstOrDefault();
            this.OnAfterGetById(result, seealsoId);
            return result;
        }

        // POST api/Seealsos/{seealso-guid}
        public Seealso Post([FromBody]Seealso seealso)
        {
            if (seealso.SeealsoId == Guid.Empty) seealso.SeealsoId = Guid.NewGuid();
            this.OnBeforePost(seealso);
            this.SDM.Upsert(seealso);
            this.OnAfterPost(seealso);
            return seealso;
        }

        // POST api/Seealsos/{seealso-guid}
        public Seealso Put([FromBody]Seealso seealso)
        {
            if (seealso.SeealsoId == Guid.Empty) seealso.SeealsoId = Guid.NewGuid();
            this.OnBeforePut(seealso);
            this.SDM.Upsert(seealso);
            this.OnAfterPut(seealso);
            return seealso;
        }

        // POST api/Seealsos/{seealso-guid}
        public void Delete(Guid seealsoId)
        {
            var seealsoWhere = String.Format("SeealsoId = '{0}'", seealsoId);
            var seealso = this.SDM.GetAllSeealsos<Seealso>(seealsoWhere).FirstOrDefault();
            this.OnBeforeDelete(seealso);
            this.SDM.Delete(seealso);
            this.OnAfterDelete(seealso);
        }
    }
}
