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
    public partial class DelimitersController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Delimiter> Delimiters);
        partial void OnAfterGetById(Delimiter Delimiters, Guid delimiterId);
        partial void OnBeforePost(Delimiter delimiter);
        partial void OnAfterPost(Delimiter delimiter);
        partial void OnBeforePut(Delimiter delimiter);
        partial void OnAfterPut(Delimiter delimiter);
        partial void OnBeforeDelete(Delimiter delimiter);
        partial void OnAfterDelete(Delimiter delimiter);
        

        public DelimitersController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Delimiter
        public IEnumerable<Delimiter> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllDelimiters<Delimiter>();
            Delimiter.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Delimiters/{delimiter-guid}
        public Delimiter Get(Guid delimiterId)
        {
            var DelimitersWhere = String.Format("DelimiterId = '{0}'", delimiterId);
            var result = this.SDM.GetAllDelimiters<Delimiter>(DelimitersWhere).FirstOrDefault();
            this.OnAfterGetById(result, delimiterId);
            return result;
        }

        // POST api/Delimiters/{delimiter-guid}
        public Delimiter Post([FromBody]Delimiter delimiter)
        {
            if (delimiter.DelimiterId == Guid.Empty) delimiter.DelimiterId = Guid.NewGuid();
            this.OnBeforePost(delimiter);
            this.SDM.Upsert(delimiter);
            this.OnAfterPost(delimiter);
            return delimiter;
        }

        // POST api/Delimiters/{delimiter-guid}
        public Delimiter Put([FromBody]Delimiter delimiter)
        {
            if (delimiter.DelimiterId == Guid.Empty) delimiter.DelimiterId = Guid.NewGuid();
            this.OnBeforePut(delimiter);
            this.SDM.Upsert(delimiter);
            this.OnAfterPut(delimiter);
            return delimiter;
        }

        // POST api/Delimiters/{delimiter-guid}
        public void Delete(Guid delimiterId)
        {
            var delimiterWhere = String.Format("DelimiterId = '{0}'", delimiterId);
            var delimiter = this.SDM.GetAllDelimiters<Delimiter>(delimiterWhere).FirstOrDefault();
            this.OnBeforeDelete(delimiter);
            this.SDM.Delete(delimiter);
            this.OnAfterDelete(delimiter);
        }
    }
}
