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
    public partial class MorsecodeasanassistivetechnologiesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Morsecodeasanassistivetechnology> Morsecodeasanassistivetechnologies);
        partial void OnAfterGetById(Morsecodeasanassistivetechnology Morsecodeasanassistivetechnologies, Guid morsecodeasanassistivetechnologyId);
        partial void OnBeforePost(Morsecodeasanassistivetechnology morsecodeasanassistivetechnology);
        partial void OnAfterPost(Morsecodeasanassistivetechnology morsecodeasanassistivetechnology);
        partial void OnBeforePut(Morsecodeasanassistivetechnology morsecodeasanassistivetechnology);
        partial void OnAfterPut(Morsecodeasanassistivetechnology morsecodeasanassistivetechnology);
        partial void OnBeforeDelete(Morsecodeasanassistivetechnology morsecodeasanassistivetechnology);
        partial void OnAfterDelete(Morsecodeasanassistivetechnology morsecodeasanassistivetechnology);
        

        public MorsecodeasanassistivetechnologiesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Morsecodeasanassistivetechnology
        public IEnumerable<Morsecodeasanassistivetechnology> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllMorsecodeasanassistivetechnologies<Morsecodeasanassistivetechnology>();
            Morsecodeasanassistivetechnology.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Morsecodeasanassistivetechnologies/{morsecodeasanassistivetechnology-guid}
        public Morsecodeasanassistivetechnology Get(Guid morsecodeasanassistivetechnologyId)
        {
            var MorsecodeasanassistivetechnologiesWhere = String.Format("MorsecodeasanassistivetechnologyId = '{0}'", morsecodeasanassistivetechnologyId);
            var result = this.SDM.GetAllMorsecodeasanassistivetechnologies<Morsecodeasanassistivetechnology>(MorsecodeasanassistivetechnologiesWhere).FirstOrDefault();
            this.OnAfterGetById(result, morsecodeasanassistivetechnologyId);
            return result;
        }

        // POST api/Morsecodeasanassistivetechnologies/{morsecodeasanassistivetechnology-guid}
        public Morsecodeasanassistivetechnology Post([FromBody]Morsecodeasanassistivetechnology morsecodeasanassistivetechnology)
        {
            if (morsecodeasanassistivetechnology.MorsecodeasanassistivetechnologyId == Guid.Empty) morsecodeasanassistivetechnology.MorsecodeasanassistivetechnologyId = Guid.NewGuid();
            this.OnBeforePost(morsecodeasanassistivetechnology);
            this.SDM.Upsert(morsecodeasanassistivetechnology);
            this.OnAfterPost(morsecodeasanassistivetechnology);
            return morsecodeasanassistivetechnology;
        }

        // POST api/Morsecodeasanassistivetechnologies/{morsecodeasanassistivetechnology-guid}
        public Morsecodeasanassistivetechnology Put([FromBody]Morsecodeasanassistivetechnology morsecodeasanassistivetechnology)
        {
            if (morsecodeasanassistivetechnology.MorsecodeasanassistivetechnologyId == Guid.Empty) morsecodeasanassistivetechnology.MorsecodeasanassistivetechnologyId = Guid.NewGuid();
            this.OnBeforePut(morsecodeasanassistivetechnology);
            this.SDM.Upsert(morsecodeasanassistivetechnology);
            this.OnAfterPut(morsecodeasanassistivetechnology);
            return morsecodeasanassistivetechnology;
        }

        // POST api/Morsecodeasanassistivetechnologies/{morsecodeasanassistivetechnology-guid}
        public void Delete(Guid morsecodeasanassistivetechnologyId)
        {
            var morsecodeasanassistivetechnologyWhere = String.Format("MorsecodeasanassistivetechnologyId = '{0}'", morsecodeasanassistivetechnologyId);
            var morsecodeasanassistivetechnology = this.SDM.GetAllMorsecodeasanassistivetechnologies<Morsecodeasanassistivetechnology>(morsecodeasanassistivetechnologyWhere).FirstOrDefault();
            this.OnBeforeDelete(morsecodeasanassistivetechnology);
            this.SDM.Delete(morsecodeasanassistivetechnology);
            this.OnAfterDelete(morsecodeasanassistivetechnology);
        }
    }
}
