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
    public partial class FileinternationalmorsecodesvgsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Fileinternationalmorsecodesvg> Fileinternationalmorsecodesvgs);
        partial void OnAfterGetById(Fileinternationalmorsecodesvg Fileinternationalmorsecodesvgs, Guid fileinternationalmorsecodesvgId);
        partial void OnBeforePost(Fileinternationalmorsecodesvg fileinternationalmorsecodesvg);
        partial void OnAfterPost(Fileinternationalmorsecodesvg fileinternationalmorsecodesvg);
        partial void OnBeforePut(Fileinternationalmorsecodesvg fileinternationalmorsecodesvg);
        partial void OnAfterPut(Fileinternationalmorsecodesvg fileinternationalmorsecodesvg);
        partial void OnBeforeDelete(Fileinternationalmorsecodesvg fileinternationalmorsecodesvg);
        partial void OnAfterDelete(Fileinternationalmorsecodesvg fileinternationalmorsecodesvg);
        

        public FileinternationalmorsecodesvgsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Fileinternationalmorsecodesvg
        public IEnumerable<Fileinternationalmorsecodesvg> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllFileinternationalmorsecodesvgs<Fileinternationalmorsecodesvg>();
            Fileinternationalmorsecodesvg.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Fileinternationalmorsecodesvgs/{fileinternationalmorsecodesvg-guid}
        public Fileinternationalmorsecodesvg Get(Guid fileinternationalmorsecodesvgId)
        {
            var FileinternationalmorsecodesvgsWhere = String.Format("FileinternationalmorsecodesvgId = '{0}'", fileinternationalmorsecodesvgId);
            var result = this.SDM.GetAllFileinternationalmorsecodesvgs<Fileinternationalmorsecodesvg>(FileinternationalmorsecodesvgsWhere).FirstOrDefault();
            this.OnAfterGetById(result, fileinternationalmorsecodesvgId);
            return result;
        }

        // POST api/Fileinternationalmorsecodesvgs/{fileinternationalmorsecodesvg-guid}
        public Fileinternationalmorsecodesvg Post([FromBody]Fileinternationalmorsecodesvg fileinternationalmorsecodesvg)
        {
            if (fileinternationalmorsecodesvg.FileinternationalmorsecodesvgId == Guid.Empty) fileinternationalmorsecodesvg.FileinternationalmorsecodesvgId = Guid.NewGuid();
            this.OnBeforePost(fileinternationalmorsecodesvg);
            this.SDM.Upsert(fileinternationalmorsecodesvg);
            this.OnAfterPost(fileinternationalmorsecodesvg);
            return fileinternationalmorsecodesvg;
        }

        // POST api/Fileinternationalmorsecodesvgs/{fileinternationalmorsecodesvg-guid}
        public Fileinternationalmorsecodesvg Put([FromBody]Fileinternationalmorsecodesvg fileinternationalmorsecodesvg)
        {
            if (fileinternationalmorsecodesvg.FileinternationalmorsecodesvgId == Guid.Empty) fileinternationalmorsecodesvg.FileinternationalmorsecodesvgId = Guid.NewGuid();
            this.OnBeforePut(fileinternationalmorsecodesvg);
            this.SDM.Upsert(fileinternationalmorsecodesvg);
            this.OnAfterPut(fileinternationalmorsecodesvg);
            return fileinternationalmorsecodesvg;
        }

        // POST api/Fileinternationalmorsecodesvgs/{fileinternationalmorsecodesvg-guid}
        public void Delete(Guid fileinternationalmorsecodesvgId)
        {
            var fileinternationalmorsecodesvgWhere = String.Format("FileinternationalmorsecodesvgId = '{0}'", fileinternationalmorsecodesvgId);
            var fileinternationalmorsecodesvg = this.SDM.GetAllFileinternationalmorsecodesvgs<Fileinternationalmorsecodesvg>(fileinternationalmorsecodesvgWhere).FirstOrDefault();
            this.OnBeforeDelete(fileinternationalmorsecodesvg);
            this.SDM.Delete(fileinternationalmorsecodesvg);
            this.OnAfterDelete(fileinternationalmorsecodesvg);
        }
    }
}
