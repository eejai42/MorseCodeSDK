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
    public partial class VhfomnidirectionalrangesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Vhfomnidirectionalrange> Vhfomnidirectionalranges);
        partial void OnAfterGetById(Vhfomnidirectionalrange Vhfomnidirectionalranges, Guid vhfomnidirectionalrangeId);
        partial void OnBeforePost(Vhfomnidirectionalrange vhfomnidirectionalrange);
        partial void OnAfterPost(Vhfomnidirectionalrange vhfomnidirectionalrange);
        partial void OnBeforePut(Vhfomnidirectionalrange vhfomnidirectionalrange);
        partial void OnAfterPut(Vhfomnidirectionalrange vhfomnidirectionalrange);
        partial void OnBeforeDelete(Vhfomnidirectionalrange vhfomnidirectionalrange);
        partial void OnAfterDelete(Vhfomnidirectionalrange vhfomnidirectionalrange);
        

        public VhfomnidirectionalrangesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Vhfomnidirectionalrange
        public IEnumerable<Vhfomnidirectionalrange> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllVhfomnidirectionalranges<Vhfomnidirectionalrange>();
            Vhfomnidirectionalrange.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Vhfomnidirectionalranges/{vhfomnidirectionalrange-guid}
        public Vhfomnidirectionalrange Get(Guid vhfomnidirectionalrangeId)
        {
            var VhfomnidirectionalrangesWhere = String.Format("VhfomnidirectionalrangeId = '{0}'", vhfomnidirectionalrangeId);
            var result = this.SDM.GetAllVhfomnidirectionalranges<Vhfomnidirectionalrange>(VhfomnidirectionalrangesWhere).FirstOrDefault();
            this.OnAfterGetById(result, vhfomnidirectionalrangeId);
            return result;
        }

        // POST api/Vhfomnidirectionalranges/{vhfomnidirectionalrange-guid}
        public Vhfomnidirectionalrange Post([FromBody]Vhfomnidirectionalrange vhfomnidirectionalrange)
        {
            if (vhfomnidirectionalrange.VhfomnidirectionalrangeId == Guid.Empty) vhfomnidirectionalrange.VhfomnidirectionalrangeId = Guid.NewGuid();
            this.OnBeforePost(vhfomnidirectionalrange);
            this.SDM.Upsert(vhfomnidirectionalrange);
            this.OnAfterPost(vhfomnidirectionalrange);
            return vhfomnidirectionalrange;
        }

        // POST api/Vhfomnidirectionalranges/{vhfomnidirectionalrange-guid}
        public Vhfomnidirectionalrange Put([FromBody]Vhfomnidirectionalrange vhfomnidirectionalrange)
        {
            if (vhfomnidirectionalrange.VhfomnidirectionalrangeId == Guid.Empty) vhfomnidirectionalrange.VhfomnidirectionalrangeId = Guid.NewGuid();
            this.OnBeforePut(vhfomnidirectionalrange);
            this.SDM.Upsert(vhfomnidirectionalrange);
            this.OnAfterPut(vhfomnidirectionalrange);
            return vhfomnidirectionalrange;
        }

        // POST api/Vhfomnidirectionalranges/{vhfomnidirectionalrange-guid}
        public void Delete(Guid vhfomnidirectionalrangeId)
        {
            var vhfomnidirectionalrangeWhere = String.Format("VhfomnidirectionalrangeId = '{0}'", vhfomnidirectionalrangeId);
            var vhfomnidirectionalrange = this.SDM.GetAllVhfomnidirectionalranges<Vhfomnidirectionalrange>(vhfomnidirectionalrangeWhere).FirstOrDefault();
            this.OnBeforeDelete(vhfomnidirectionalrange);
            this.SDM.Delete(vhfomnidirectionalrange);
            this.OnAfterDelete(vhfomnidirectionalrange);
        }
    }
}
