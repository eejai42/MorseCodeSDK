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
    public partial class UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng> Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngs);
        partial void OnAfterGetById(Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngs, Guid uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId);
        partial void OnBeforePost(Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
        partial void OnAfterPost(Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
        partial void OnBeforePut(Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
        partial void OnAfterPut(Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
        partial void OnBeforeDelete(Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
        partial void OnAfterDelete(Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
        

        public UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng
        public IEnumerable<Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllUploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngs<Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng>();
            Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngs/{uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng-guid}
        public Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng Get(Guid uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId)
        {
            var UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngsWhere = String.Format("UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId = '{0}'", uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId);
            var result = this.SDM.GetAllUploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngs<Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng>(UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngsWhere).FirstOrDefault();
            this.OnAfterGetById(result, uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId);
            return result;
        }

        // POST api/Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngs/{uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng-guid}
        public Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng Post([FromBody]Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng)
        {
            if (uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng.UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId == Guid.Empty) uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng.UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId = Guid.NewGuid();
            this.OnBeforePost(uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
            this.SDM.Upsert(uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
            this.OnAfterPost(uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
            return uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng;
        }

        // POST api/Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngs/{uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng-guid}
        public Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng Put([FromBody]Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng)
        {
            if (uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng.UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId == Guid.Empty) uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng.UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId = Guid.NewGuid();
            this.OnBeforePut(uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
            this.SDM.Upsert(uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
            this.OnAfterPut(uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
            return uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng;
        }

        // POST api/Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngs/{uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng-guid}
        public void Delete(Guid uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId)
        {
            var uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngWhere = String.Format("UploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId = '{0}'", uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngId);
            var uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng = this.SDM.GetAllUploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngs<Uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng>(uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpngWhere).FirstOrDefault();
            this.OnBeforeDelete(uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
            this.SDM.Delete(uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
            this.OnAfterDelete(uploadwikimediaorgwikipediacommonsthumbbbinternationalmorsecodesvgpxinternationalmorsecodesvgpng);
        }
    }
}
