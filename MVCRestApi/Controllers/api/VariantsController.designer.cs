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
    public partial class VariantsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Variant> Variants);
        partial void OnAfterGetById(Variant Variants, Guid variantId);
        partial void OnBeforePost(Variant variant);
        partial void OnAfterPost(Variant variant);
        partial void OnBeforePut(Variant variant);
        partial void OnAfterPut(Variant variant);
        partial void OnBeforeDelete(Variant variant);
        partial void OnAfterDelete(Variant variant);
        

        public VariantsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Variant
        public IEnumerable<Variant> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllVariants<Variant>();
            Variant.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Variants/{variant-guid}
        public Variant Get(Guid variantId)
        {
            var VariantsWhere = String.Format("VariantId = '{0}'", variantId);
            var result = this.SDM.GetAllVariants<Variant>(VariantsWhere).FirstOrDefault();
            this.OnAfterGetById(result, variantId);
            return result;
        }

        // POST api/Variants/{variant-guid}
        public Variant Post([FromBody]Variant variant)
        {
            if (variant.VariantId == Guid.Empty) variant.VariantId = Guid.NewGuid();
            this.OnBeforePost(variant);
            this.SDM.Upsert(variant);
            this.OnAfterPost(variant);
            return variant;
        }

        // POST api/Variants/{variant-guid}
        public Variant Put([FromBody]Variant variant)
        {
            if (variant.VariantId == Guid.Empty) variant.VariantId = Guid.NewGuid();
            this.OnBeforePut(variant);
            this.SDM.Upsert(variant);
            this.OnAfterPut(variant);
            return variant;
        }

        // POST api/Variants/{variant-guid}
        public void Delete(Guid variantId)
        {
            var variantWhere = String.Format("VariantId = '{0}'", variantId);
            var variant = this.SDM.GetAllVariants<Variant>(variantWhere).FirstOrDefault();
            this.OnBeforeDelete(variant);
            this.SDM.Delete(variant);
            this.OnAfterDelete(variant);
        }
    }
}
