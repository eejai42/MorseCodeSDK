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
    public partial class UnitsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Unit> Units);
        partial void OnAfterGetById(Unit Units, Guid unitId);
        partial void OnBeforePost(Unit unit);
        partial void OnAfterPost(Unit unit);
        partial void OnBeforePut(Unit unit);
        partial void OnAfterPut(Unit unit);
        partial void OnBeforeDelete(Unit unit);
        partial void OnAfterDelete(Unit unit);
        

        public UnitsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Unit
        public IEnumerable<Unit> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllUnits<Unit>();
            Unit.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Units/{unit-guid}
        public Unit Get(Guid unitId)
        {
            var UnitsWhere = String.Format("UnitId = '{0}'", unitId);
            var result = this.SDM.GetAllUnits<Unit>(UnitsWhere).FirstOrDefault();
            this.OnAfterGetById(result, unitId);
            return result;
        }

        // POST api/Units/{unit-guid}
        public Unit Post([FromBody]Unit unit)
        {
            if (unit.UnitId == Guid.Empty) unit.UnitId = Guid.NewGuid();
            this.OnBeforePost(unit);
            this.SDM.Upsert(unit);
            this.OnAfterPost(unit);
            return unit;
        }

        // POST api/Units/{unit-guid}
        public Unit Put([FromBody]Unit unit)
        {
            if (unit.UnitId == Guid.Empty) unit.UnitId = Guid.NewGuid();
            this.OnBeforePut(unit);
            this.SDM.Upsert(unit);
            this.OnAfterPut(unit);
            return unit;
        }

        // POST api/Units/{unit-guid}
        public void Delete(Guid unitId)
        {
            var unitWhere = String.Format("UnitId = '{0}'", unitId);
            var unit = this.SDM.GetAllUnits<Unit>(unitWhere).FirstOrDefault();
            this.OnBeforeDelete(unit);
            this.SDM.Delete(unit);
            this.OnAfterDelete(unit);
        }
    }
}
