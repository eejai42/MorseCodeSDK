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
    public partial class UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng> Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngs);
        partial void OnAfterGetById(Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngs, Guid uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId);
        partial void OnBeforePost(Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
        partial void OnAfterPost(Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
        partial void OnBeforePut(Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
        partial void OnAfterPut(Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
        partial void OnBeforeDelete(Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
        partial void OnAfterDelete(Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
        

        public UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng
        public IEnumerable<Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllUploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngs<Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng>();
            Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngs/{uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng-guid}
        public Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng Get(Guid uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId)
        {
            var UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngsWhere = String.Format("UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId = '{0}'", uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId);
            var result = this.SDM.GetAllUploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngs<Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng>(UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngsWhere).FirstOrDefault();
            this.OnAfterGetById(result, uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId);
            return result;
        }

        // POST api/Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngs/{uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng-guid}
        public Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng Post([FromBody]Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng)
        {
            if (uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng.UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId == Guid.Empty) uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng.UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId = Guid.NewGuid();
            this.OnBeforePost(uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
            this.SDM.Upsert(uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
            this.OnAfterPost(uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
            return uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng;
        }

        // POST api/Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngs/{uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng-guid}
        public Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng Put([FromBody]Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng)
        {
            if (uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng.UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId == Guid.Empty) uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng.UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId = Guid.NewGuid();
            this.OnBeforePut(uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
            this.SDM.Upsert(uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
            this.OnAfterPut(uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
            return uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng;
        }

        // POST api/Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngs/{uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng-guid}
        public void Delete(Guid uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId)
        {
            var uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngWhere = String.Format("UploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId = '{0}'", uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngId);
            var uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng = this.SDM.GetAllUploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngs<Uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng>(uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpngWhere).FirstOrDefault();
            this.OnBeforeDelete(uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
            this.SDM.Delete(uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
            this.OnAfterDelete(uploadwikimediaorgwikipediacommonsthumbfsossvgpxsossvgpng);
        }
    }
}
