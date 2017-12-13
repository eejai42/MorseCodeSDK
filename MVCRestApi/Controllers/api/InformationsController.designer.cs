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
    public partial class InformationsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Information> Informations);
        partial void OnAfterGetById(Information Informations, Guid informationId);
        partial void OnBeforePost(Information information);
        partial void OnAfterPost(Information information);
        partial void OnBeforePut(Information information);
        partial void OnAfterPut(Information information);
        partial void OnBeforeDelete(Information information);
        partial void OnAfterDelete(Information information);
        

        public InformationsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Information
        public IEnumerable<Information> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllInformations<Information>();
            Information.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Informations/{information-guid}
        public Information Get(Guid informationId)
        {
            var InformationsWhere = String.Format("InformationId = '{0}'", informationId);
            var result = this.SDM.GetAllInformations<Information>(InformationsWhere).FirstOrDefault();
            this.OnAfterGetById(result, informationId);
            return result;
        }

        // POST api/Informations/{information-guid}
        public Information Post([FromBody]Information information)
        {
            if (information.InformationId == Guid.Empty) information.InformationId = Guid.NewGuid();
            this.OnBeforePost(information);
            this.SDM.Upsert(information);
            this.OnAfterPost(information);
            return information;
        }

        // POST api/Informations/{information-guid}
        public Information Put([FromBody]Information information)
        {
            if (information.InformationId == Guid.Empty) information.InformationId = Guid.NewGuid();
            this.OnBeforePut(information);
            this.SDM.Upsert(information);
            this.OnAfterPut(information);
            return information;
        }

        // POST api/Informations/{information-guid}
        public void Delete(Guid informationId)
        {
            var informationWhere = String.Format("InformationId = '{0}'", informationId);
            var information = this.SDM.GetAllInformations<Information>(informationWhere).FirstOrDefault();
            this.OnBeforeDelete(information);
            this.SDM.Delete(information);
            this.OnAfterDelete(information);
        }
    }
}
