using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Device
    {
        private void InitPoco()
        {
            
            this.DeviceId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DeviceId")]
        public Guid DeviceId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateDeviceWhere(IEnumerable<Device> devices)
        {
            if (!devices.Any()) return "1=1";
            else 
            {
                var idList = devices.Select(selectDevice => String.Format("'{0}'", selectDevice.DeviceId));
                var csIdList = String.Join(",", idList);
                return String.Format("DeviceId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Device> devices, string expandString)
        {
            
        }
        
    }
}