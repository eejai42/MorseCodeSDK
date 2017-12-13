using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Traffic
    {
        private void InitPoco()
        {
            
            this.TrafficId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TrafficId")]
        public Guid TrafficId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateTrafficWhere(IEnumerable<Traffic> traffics)
        {
            if (!traffics.Any()) return "1=1";
            else 
            {
                var idList = traffics.Select(selectTraffic => String.Format("'{0}'", selectTraffic.TrafficId));
                var csIdList = String.Join(",", idList);
                return String.Format("TrafficId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Traffic> traffics, string expandString)
        {
            
        }
        
    }
}