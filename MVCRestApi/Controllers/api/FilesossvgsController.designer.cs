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
    public partial class FilesossvgsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Filesossvg> Filesossvgs);
        partial void OnAfterGetById(Filesossvg Filesossvgs, Guid filesossvgId);
        partial void OnBeforePost(Filesossvg filesossvg);
        partial void OnAfterPost(Filesossvg filesossvg);
        partial void OnBeforePut(Filesossvg filesossvg);
        partial void OnAfterPut(Filesossvg filesossvg);
        partial void OnBeforeDelete(Filesossvg filesossvg);
        partial void OnAfterDelete(Filesossvg filesossvg);
        

        public FilesossvgsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Filesossvg
        public IEnumerable<Filesossvg> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllFilesossvgs<Filesossvg>();
            Filesossvg.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Filesossvgs/{filesossvg-guid}
        public Filesossvg Get(Guid filesossvgId)
        {
            var FilesossvgsWhere = String.Format("FilesossvgId = '{0}'", filesossvgId);
            var result = this.SDM.GetAllFilesossvgs<Filesossvg>(FilesossvgsWhere).FirstOrDefault();
            this.OnAfterGetById(result, filesossvgId);
            return result;
        }

        // POST api/Filesossvgs/{filesossvg-guid}
        public Filesossvg Post([FromBody]Filesossvg filesossvg)
        {
            if (filesossvg.FilesossvgId == Guid.Empty) filesossvg.FilesossvgId = Guid.NewGuid();
            this.OnBeforePost(filesossvg);
            this.SDM.Upsert(filesossvg);
            this.OnAfterPost(filesossvg);
            return filesossvg;
        }

        // POST api/Filesossvgs/{filesossvg-guid}
        public Filesossvg Put([FromBody]Filesossvg filesossvg)
        {
            if (filesossvg.FilesossvgId == Guid.Empty) filesossvg.FilesossvgId = Guid.NewGuid();
            this.OnBeforePut(filesossvg);
            this.SDM.Upsert(filesossvg);
            this.OnAfterPut(filesossvg);
            return filesossvg;
        }

        // POST api/Filesossvgs/{filesossvg-guid}
        public void Delete(Guid filesossvgId)
        {
            var filesossvgWhere = String.Format("FilesossvgId = '{0}'", filesossvgId);
            var filesossvg = this.SDM.GetAllFilesossvgs<Filesossvg>(filesossvgWhere).FirstOrDefault();
            this.OnBeforeDelete(filesossvg);
            this.SDM.Delete(filesossvg);
            this.OnAfterDelete(filesossvg);
        }
    }
}
