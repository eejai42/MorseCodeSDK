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
    public partial class ExtensionsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Extension> Extensions);
        partial void OnAfterGetById(Extension Extensions, Guid extensionId);
        partial void OnBeforePost(Extension extension);
        partial void OnAfterPost(Extension extension);
        partial void OnBeforePut(Extension extension);
        partial void OnAfterPut(Extension extension);
        partial void OnBeforeDelete(Extension extension);
        partial void OnAfterDelete(Extension extension);
        

        public ExtensionsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Extension
        public IEnumerable<Extension> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllExtensions<Extension>();
            Extension.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Extensions/{extension-guid}
        public Extension Get(Guid extensionId)
        {
            var ExtensionsWhere = String.Format("ExtensionId = '{0}'", extensionId);
            var result = this.SDM.GetAllExtensions<Extension>(ExtensionsWhere).FirstOrDefault();
            this.OnAfterGetById(result, extensionId);
            return result;
        }

        // POST api/Extensions/{extension-guid}
        public Extension Post([FromBody]Extension extension)
        {
            if (extension.ExtensionId == Guid.Empty) extension.ExtensionId = Guid.NewGuid();
            this.OnBeforePost(extension);
            this.SDM.Upsert(extension);
            this.OnAfterPost(extension);
            return extension;
        }

        // POST api/Extensions/{extension-guid}
        public Extension Put([FromBody]Extension extension)
        {
            if (extension.ExtensionId == Guid.Empty) extension.ExtensionId = Guid.NewGuid();
            this.OnBeforePut(extension);
            this.SDM.Upsert(extension);
            this.OnAfterPut(extension);
            return extension;
        }

        // POST api/Extensions/{extension-guid}
        public void Delete(Guid extensionId)
        {
            var extensionWhere = String.Format("ExtensionId = '{0}'", extensionId);
            var extension = this.SDM.GetAllExtensions<Extension>(extensionWhere).FirstOrDefault();
            this.OnBeforeDelete(extension);
            this.SDM.Delete(extension);
            this.OnAfterDelete(extension);
        }
    }
}
