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
    public partial class EquipmentsController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Equipment> Equipments);
        partial void OnAfterGetById(Equipment Equipments, Guid equipmentId);
        partial void OnBeforePost(Equipment equipment);
        partial void OnAfterPost(Equipment equipment);
        partial void OnBeforePut(Equipment equipment);
        partial void OnAfterPut(Equipment equipment);
        partial void OnBeforeDelete(Equipment equipment);
        partial void OnAfterDelete(Equipment equipment);
        

        public EquipmentsController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Equipment
        public IEnumerable<Equipment> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllEquipments<Equipment>();
            Equipment.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Equipments/{equipment-guid}
        public Equipment Get(Guid equipmentId)
        {
            var EquipmentsWhere = String.Format("EquipmentId = '{0}'", equipmentId);
            var result = this.SDM.GetAllEquipments<Equipment>(EquipmentsWhere).FirstOrDefault();
            this.OnAfterGetById(result, equipmentId);
            return result;
        }

        // POST api/Equipments/{equipment-guid}
        public Equipment Post([FromBody]Equipment equipment)
        {
            if (equipment.EquipmentId == Guid.Empty) equipment.EquipmentId = Guid.NewGuid();
            this.OnBeforePost(equipment);
            this.SDM.Upsert(equipment);
            this.OnAfterPost(equipment);
            return equipment;
        }

        // POST api/Equipments/{equipment-guid}
        public Equipment Put([FromBody]Equipment equipment)
        {
            if (equipment.EquipmentId == Guid.Empty) equipment.EquipmentId = Guid.NewGuid();
            this.OnBeforePut(equipment);
            this.SDM.Upsert(equipment);
            this.OnAfterPut(equipment);
            return equipment;
        }

        // POST api/Equipments/{equipment-guid}
        public void Delete(Guid equipmentId)
        {
            var equipmentWhere = String.Format("EquipmentId = '{0}'", equipmentId);
            var equipment = this.SDM.GetAllEquipments<Equipment>(equipmentWhere).FirstOrDefault();
            this.OnBeforeDelete(equipment);
            this.SDM.Delete(equipment);
            this.OnAfterDelete(equipment);
        }
    }
}
