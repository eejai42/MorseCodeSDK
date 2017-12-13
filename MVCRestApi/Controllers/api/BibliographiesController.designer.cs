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
    public partial class BibliographiesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Bibliography> Bibliographies);
        partial void OnAfterGetById(Bibliography Bibliographies, Guid bibliographyId);
        partial void OnBeforePost(Bibliography bibliography);
        partial void OnAfterPost(Bibliography bibliography);
        partial void OnBeforePut(Bibliography bibliography);
        partial void OnAfterPut(Bibliography bibliography);
        partial void OnBeforeDelete(Bibliography bibliography);
        partial void OnAfterDelete(Bibliography bibliography);
        

        public BibliographiesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Bibliography
        public IEnumerable<Bibliography> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllBibliographies<Bibliography>();
            Bibliography.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Bibliographies/{bibliography-guid}
        public Bibliography Get(Guid bibliographyId)
        {
            var BibliographiesWhere = String.Format("BibliographyId = '{0}'", bibliographyId);
            var result = this.SDM.GetAllBibliographies<Bibliography>(BibliographiesWhere).FirstOrDefault();
            this.OnAfterGetById(result, bibliographyId);
            return result;
        }

        // POST api/Bibliographies/{bibliography-guid}
        public Bibliography Post([FromBody]Bibliography bibliography)
        {
            if (bibliography.BibliographyId == Guid.Empty) bibliography.BibliographyId = Guid.NewGuid();
            this.OnBeforePost(bibliography);
            this.SDM.Upsert(bibliography);
            this.OnAfterPost(bibliography);
            return bibliography;
        }

        // POST api/Bibliographies/{bibliography-guid}
        public Bibliography Put([FromBody]Bibliography bibliography)
        {
            if (bibliography.BibliographyId == Guid.Empty) bibliography.BibliographyId = Guid.NewGuid();
            this.OnBeforePut(bibliography);
            this.SDM.Upsert(bibliography);
            this.OnAfterPut(bibliography);
            return bibliography;
        }

        // POST api/Bibliographies/{bibliography-guid}
        public void Delete(Guid bibliographyId)
        {
            var bibliographyWhere = String.Format("BibliographyId = '{0}'", bibliographyId);
            var bibliography = this.SDM.GetAllBibliographies<Bibliography>(bibliographyWhere).FirstOrDefault();
            this.OnBeforeDelete(bibliography);
            this.SDM.Delete(bibliography);
            this.OnAfterDelete(bibliography);
        }
    }
}
