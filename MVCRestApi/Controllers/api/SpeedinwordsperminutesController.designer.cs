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
    public partial class SpeedinwordsperminutesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Speedinwordsperminute> Speedinwordsperminutes);
        partial void OnAfterGetById(Speedinwordsperminute Speedinwordsperminutes, Guid speedinwordsperminuteId);
        partial void OnBeforePost(Speedinwordsperminute speedinwordsperminute);
        partial void OnAfterPost(Speedinwordsperminute speedinwordsperminute);
        partial void OnBeforePut(Speedinwordsperminute speedinwordsperminute);
        partial void OnAfterPut(Speedinwordsperminute speedinwordsperminute);
        partial void OnBeforeDelete(Speedinwordsperminute speedinwordsperminute);
        partial void OnAfterDelete(Speedinwordsperminute speedinwordsperminute);
        

        public SpeedinwordsperminutesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Speedinwordsperminute
        public IEnumerable<Speedinwordsperminute> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllSpeedinwordsperminutes<Speedinwordsperminute>();
            Speedinwordsperminute.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Speedinwordsperminutes/{speedinwordsperminute-guid}
        public Speedinwordsperminute Get(Guid speedinwordsperminuteId)
        {
            var SpeedinwordsperminutesWhere = String.Format("SpeedinwordsperminuteId = '{0}'", speedinwordsperminuteId);
            var result = this.SDM.GetAllSpeedinwordsperminutes<Speedinwordsperminute>(SpeedinwordsperminutesWhere).FirstOrDefault();
            this.OnAfterGetById(result, speedinwordsperminuteId);
            return result;
        }

        // POST api/Speedinwordsperminutes/{speedinwordsperminute-guid}
        public Speedinwordsperminute Post([FromBody]Speedinwordsperminute speedinwordsperminute)
        {
            if (speedinwordsperminute.SpeedinwordsperminuteId == Guid.Empty) speedinwordsperminute.SpeedinwordsperminuteId = Guid.NewGuid();
            this.OnBeforePost(speedinwordsperminute);
            this.SDM.Upsert(speedinwordsperminute);
            this.OnAfterPost(speedinwordsperminute);
            return speedinwordsperminute;
        }

        // POST api/Speedinwordsperminutes/{speedinwordsperminute-guid}
        public Speedinwordsperminute Put([FromBody]Speedinwordsperminute speedinwordsperminute)
        {
            if (speedinwordsperminute.SpeedinwordsperminuteId == Guid.Empty) speedinwordsperminute.SpeedinwordsperminuteId = Guid.NewGuid();
            this.OnBeforePut(speedinwordsperminute);
            this.SDM.Upsert(speedinwordsperminute);
            this.OnAfterPut(speedinwordsperminute);
            return speedinwordsperminute;
        }

        // POST api/Speedinwordsperminutes/{speedinwordsperminute-guid}
        public void Delete(Guid speedinwordsperminuteId)
        {
            var speedinwordsperminuteWhere = String.Format("SpeedinwordsperminuteId = '{0}'", speedinwordsperminuteId);
            var speedinwordsperminute = this.SDM.GetAllSpeedinwordsperminutes<Speedinwordsperminute>(speedinwordsperminuteWhere).FirstOrDefault();
            this.OnBeforeDelete(speedinwordsperminute);
            this.SDM.Delete(speedinwordsperminute);
            this.OnAfterDelete(speedinwordsperminute);
        }
    }
}
