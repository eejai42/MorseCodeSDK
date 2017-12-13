using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Pilot
    {
        private void InitPoco()
        {
            
            this.PilotId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PilotId")]
        public Guid PilotId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreatePilotWhere(IEnumerable<Pilot> pilots)
        {
            if (!pilots.Any()) return "1=1";
            else 
            {
                var idList = pilots.Select(selectPilot => String.Format("'{0}'", selectPilot.PilotId));
                var csIdList = String.Join(",", idList);
                return String.Format("PilotId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Pilot> pilots, string expandString)
        {
            
        }
        
    }
}