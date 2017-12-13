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
    public partial class SamuelfbmorsesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Samuelfbmorse> Samuelfbmorses);
        partial void OnAfterGetById(Samuelfbmorse Samuelfbmorses, Guid samuelfbmorseId);
        partial void OnBeforePost(Samuelfbmorse samuelfbmorse);
        partial void OnAfterPost(Samuelfbmorse samuelfbmorse);
        partial void OnBeforePut(Samuelfbmorse samuelfbmorse);
        partial void OnAfterPut(Samuelfbmorse samuelfbmorse);
        partial void OnBeforeDelete(Samuelfbmorse samuelfbmorse);
        partial void OnAfterDelete(Samuelfbmorse samuelfbmorse);
        

        public SamuelfbmorsesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Samuelfbmorse
        public IEnumerable<Samuelfbmorse> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSamuelfbmorses<Samuelfbmorse>();
            Samuelfbmorse.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Samuelfbmorses/{samuelfbmorse-guid}
        public Samuelfbmorse Get(Guid samuelfbmorseId)
        {
            var SamuelfbmorsesWhere = String.Format("SamuelfbmorseId = '{0}'", samuelfbmorseId);
            var result = this.SDM.GetAllSamuelfbmorses<Samuelfbmorse>(SamuelfbmorsesWhere).FirstOrDefault();
            this.OnAfterGetById(result, samuelfbmorseId);
            return result;
        }

        // POST api/Samuelfbmorses/{samuelfbmorse-guid}
        public Samuelfbmorse Post([FromBody]Samuelfbmorse samuelfbmorse)
        {
            if (samuelfbmorse.SamuelfbmorseId == Guid.Empty) samuelfbmorse.SamuelfbmorseId = Guid.NewGuid();
            this.OnBeforePost(samuelfbmorse);
            this.SDM.Upsert(samuelfbmorse);
            this.OnAfterPost(samuelfbmorse);
            return samuelfbmorse;
        }

        // POST api/Samuelfbmorses/{samuelfbmorse-guid}
        public Samuelfbmorse Put([FromBody]Samuelfbmorse samuelfbmorse)
        {
            if (samuelfbmorse.SamuelfbmorseId == Guid.Empty) samuelfbmorse.SamuelfbmorseId = Guid.NewGuid();
            this.OnBeforePut(samuelfbmorse);
            this.SDM.Upsert(samuelfbmorse);
            this.OnAfterPut(samuelfbmorse);
            return samuelfbmorse;
        }

        // POST api/Samuelfbmorses/{samuelfbmorse-guid}
        public void Delete(Guid samuelfbmorseId)
        {
            var samuelfbmorseWhere = String.Format("SamuelfbmorseId = '{0}'", samuelfbmorseId);
            var samuelfbmorse = this.SDM.GetAllSamuelfbmorses<Samuelfbmorse>(samuelfbmorseWhere).FirstOrDefault();
            this.OnBeforeDelete(samuelfbmorse);
            this.SDM.Delete(samuelfbmorse);
            this.OnAfterDelete(samuelfbmorse);
        }
    }
}
