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
    public partial class DevicesController : ApiController
    {
        public SqlDataManager SDM { get; }

        partial void OnConstructor();
        partial void OnBeforeGet();
        partial void OnAfterGet(IEnumerable<Device> Devices);
        partial void OnAfterGetById(Device Devices, Guid deviceId);
        partial void OnBeforePost(Device device);
        partial void OnAfterPost(Device device);
        partial void OnBeforePut(Device device);
        partial void OnAfterPut(Device device);
        partial void OnBeforeDelete(Device device);
        partial void OnAfterDelete(Device device);
        

        public DevicesController()
        {
            this.SDM = new SqlDataManager();
            this.OnConstructor();
        }
        // GET api/Device
        public IEnumerable<Device> Get()
        {
            this.OnBeforeGet();
            var results = this.SDM.GetAllDevices<Device>();
            Device.CheckExpand(this.SDM, results, HttpContext.Current.Request["expand"]);
            this.OnAfterGet(results);
            return results;
        }

        // GET api/Devices/{device-guid}
        public Device Get(Guid deviceId)
        {
            var DevicesWhere = String.Format("DeviceId = '{0}'", deviceId);
            var result = this.SDM.GetAllDevices<Device>(DevicesWhere).FirstOrDefault();
            this.OnAfterGetById(result, deviceId);
            return result;
        }

        // POST api/Devices/{device-guid}
        public Device Post([FromBody]Device device)
        {
            if (device.DeviceId == Guid.Empty) device.DeviceId = Guid.NewGuid();
            this.OnBeforePost(device);
            this.SDM.Upsert(device);
            this.OnAfterPost(device);
            return device;
        }

        // POST api/Devices/{device-guid}
        public Device Put([FromBody]Device device)
        {
            if (device.DeviceId == Guid.Empty) device.DeviceId = Guid.NewGuid();
            this.OnBeforePut(device);
            this.SDM.Upsert(device);
            this.OnAfterPut(device);
            return device;
        }

        // POST api/Devices/{device-guid}
        public void Delete(Guid deviceId)
        {
            var deviceWhere = String.Format("DeviceId = '{0}'", deviceId);
            var device = this.SDM.GetAllDevices<Device>(deviceWhere).FirstOrDefault();
            this.OnBeforeDelete(device);
            this.SDM.Delete(device);
            this.OnAfterDelete(device);
        }
    }
}
