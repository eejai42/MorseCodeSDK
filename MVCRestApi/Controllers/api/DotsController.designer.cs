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
    public partial class DotsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Dot> Dots);
        partial void OnAfterGetById(Dot Dots, Guid dotId);
        partial void OnBeforePost(Dot dot);
        partial void OnAfterPost(Dot dot);
        partial void OnBeforePut(Dot dot);
        partial void OnAfterPut(Dot dot);
        partial void OnBeforeDelete(Dot dot);
        partial void OnAfterDelete(Dot dot);
        

        public DotsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Dot
        public IEnumerable<Dot> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllDots<Dot>();
            Dot.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Dots/{dot-guid}
        public Dot Get(Guid dotId)
        {
            var DotsWhere = String.Format("DotId = '{0}'", dotId);
            var result = this.SDM.GetAllDots<Dot>(DotsWhere).FirstOrDefault();
            this.OnAfterGetById(result, dotId);
            return result;
        }

        // POST api/Dots/{dot-guid}
        public Dot Post([FromBody]Dot dot)
        {
            if (dot.DotId == Guid.Empty) dot.DotId = Guid.NewGuid();
            this.OnBeforePost(dot);
            this.SDM.Upsert(dot);
            this.OnAfterPost(dot);
            return dot;
        }

        // POST api/Dots/{dot-guid}
        public Dot Put([FromBody]Dot dot)
        {
            if (dot.DotId == Guid.Empty) dot.DotId = Guid.NewGuid();
            this.OnBeforePut(dot);
            this.SDM.Upsert(dot);
            this.OnAfterPut(dot);
            return dot;
        }

        // POST api/Dots/{dot-guid}
        public void Delete(Guid dotId)
        {
            var dotWhere = String.Format("DotId = '{0}'", dotId);
            var dot = this.SDM.GetAllDots<Dot>(dotWhere).FirstOrDefault();
            this.OnBeforeDelete(dot);
            this.SDM.Delete(dot);
            this.OnAfterDelete(dot);
        }
    }
}
