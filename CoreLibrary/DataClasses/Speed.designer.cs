using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Speed
    {
        private void InitPoco()
        {
            
            this.SpeedId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SpeedId")]
        public Guid SpeedId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateSpeedWhere(IEnumerable<Speed> speeds)
        {
            if (!speeds.Any()) return "1=1";
            else 
            {
                var idList = speeds.Select(selectSpeed => String.Format("'{0}'", selectSpeed.SpeedId));
                var csIdList = String.Join(",", idList);
                return String.Format("SpeedId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Speed> speeds, string expandString)
        {
            
        }
        
    }
}