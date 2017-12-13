using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Airtrafficcontroller
    {
        private void InitPoco()
        {
            
            this.AirtrafficcontrollerId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AirtrafficcontrollerId")]
        public Guid AirtrafficcontrollerId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateAirtrafficcontrollerWhere(IEnumerable<Airtrafficcontroller> airtrafficcontrollers)
        {
            if (!airtrafficcontrollers.Any()) return "1=1";
            else 
            {
                var idList = airtrafficcontrollers.Select(selectAirtrafficcontroller => String.Format("'{0}'", selectAirtrafficcontroller.AirtrafficcontrollerId));
                var csIdList = String.Join(",", idList);
                return String.Format("AirtrafficcontrollerId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Airtrafficcontroller> airtrafficcontrollers, string expandString)
        {
            
        }
        
    }
}