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
    public partial class TelegraphOperatorsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<TelegraphOperator> TelegraphOperators);
        partial void OnAfterGetById(TelegraphOperator TelegraphOperators, Guid telegraphoperatorId);
        partial void OnBeforePost(TelegraphOperator telegraphoperator);
        partial void OnAfterPost(TelegraphOperator telegraphoperator);
        partial void OnBeforePut(TelegraphOperator telegraphoperator);
        partial void OnAfterPut(TelegraphOperator telegraphoperator);
        partial void OnBeforeDelete(TelegraphOperator telegraphoperator);
        partial void OnAfterDelete(TelegraphOperator telegraphoperator);
        

        public TelegraphOperatorsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/TelegraphOperator
        public IEnumerable<TelegraphOperator> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllTelegraphOperators<TelegraphOperator>();
            TelegraphOperator.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/TelegraphOperators/{telegraphoperator-guid}
        public TelegraphOperator Get(Guid telegraphoperatorId)
        {
            var TelegraphOperatorsWhere = String.Format("TelegraphOperatorId = '{0}'", telegraphoperatorId);
            var result = this.SDM.GetAllTelegraphOperators<TelegraphOperator>(TelegraphOperatorsWhere).FirstOrDefault();
            this.OnAfterGetById(result, telegraphoperatorId);
            return result;
        }

        // POST api/TelegraphOperators/{telegraphoperator-guid}
        public TelegraphOperator Post([FromBody]TelegraphOperator telegraphoperator)
        {
            if (telegraphoperator.TelegraphOperatorId == Guid.Empty) telegraphoperator.TelegraphOperatorId = Guid.NewGuid();
            this.OnBeforePost(telegraphoperator);
            this.SDM.Upsert(telegraphoperator);
            this.OnAfterPost(telegraphoperator);
            return telegraphoperator;
        }

        // POST api/TelegraphOperators/{telegraphoperator-guid}
        public TelegraphOperator Put([FromBody]TelegraphOperator telegraphoperator)
        {
            if (telegraphoperator.TelegraphOperatorId == Guid.Empty) telegraphoperator.TelegraphOperatorId = Guid.NewGuid();
            this.OnBeforePut(telegraphoperator);
            this.SDM.Upsert(telegraphoperator);
            this.OnAfterPut(telegraphoperator);
            return telegraphoperator;
        }

        // POST api/TelegraphOperators/{telegraphoperator-guid}
        public void Delete(Guid telegraphoperatorId)
        {
            var telegraphoperatorWhere = String.Format("TelegraphOperatorId = '{0}'", telegraphoperatorId);
            var telegraphoperator = this.SDM.GetAllTelegraphOperators<TelegraphOperator>(telegraphoperatorWhere).FirstOrDefault();
            this.OnBeforeDelete(telegraphoperator);
            this.SDM.Delete(telegraphoperator);
            this.OnAfterDelete(telegraphoperator);
        }
    }
}
