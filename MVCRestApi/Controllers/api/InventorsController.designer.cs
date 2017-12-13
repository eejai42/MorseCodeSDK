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
    public partial class InventorsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Inventor> Inventors);
        partial void OnAfterGetById(Inventor Inventors, Guid inventorId);
        partial void OnBeforePost(Inventor inventor);
        partial void OnAfterPost(Inventor inventor);
        partial void OnBeforePut(Inventor inventor);
        partial void OnAfterPut(Inventor inventor);
        partial void OnBeforeDelete(Inventor inventor);
        partial void OnAfterDelete(Inventor inventor);
        

        public InventorsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Inventor
        public IEnumerable<Inventor> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllInventors<Inventor>();
            Inventor.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Inventors/{inventor-guid}
        public Inventor Get(Guid inventorId)
        {
            var InventorsWhere = String.Format("InventorId = '{0}'", inventorId);
            var result = this.SDM.GetAllInventors<Inventor>(InventorsWhere).FirstOrDefault();
            this.OnAfterGetById(result, inventorId);
            return result;
        }

        // POST api/Inventors/{inventor-guid}
        public Inventor Post([FromBody]Inventor inventor)
        {
            if (inventor.InventorId == Guid.Empty) inventor.InventorId = Guid.NewGuid();
            this.OnBeforePost(inventor);
            this.SDM.Upsert(inventor);
            this.OnAfterPost(inventor);
            return inventor;
        }

        // POST api/Inventors/{inventor-guid}
        public Inventor Put([FromBody]Inventor inventor)
        {
            if (inventor.InventorId == Guid.Empty) inventor.InventorId = Guid.NewGuid();
            this.OnBeforePut(inventor);
            this.SDM.Upsert(inventor);
            this.OnAfterPut(inventor);
            return inventor;
        }

        // POST api/Inventors/{inventor-guid}
        public void Delete(Guid inventorId)
        {
            var inventorWhere = String.Format("InventorId = '{0}'", inventorId);
            var inventor = this.SDM.GetAllInventors<Inventor>(inventorWhere).FirstOrDefault();
            this.OnBeforeDelete(inventor);
            this.SDM.Delete(inventor);
            this.OnAfterDelete(inventor);
        }
    }
}
