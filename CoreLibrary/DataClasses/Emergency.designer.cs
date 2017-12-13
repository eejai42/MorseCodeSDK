using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Emergency
    {
        private void InitPoco()
        {
            
            this.EmergencyId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "EmergencyId")]
        public Guid EmergencyId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateEmergencyWhere(IEnumerable<Emergency> emergencies)
        {
            if (!emergencies.Any()) return "1=1";
            else 
            {
                var idList = emergencies.Select(selectEmergency => String.Format("'{0}'", selectEmergency.EmergencyId));
                var csIdList = String.Join(",", idList);
                return String.Format("EmergencyId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Emergency> emergencies, string expandString)
        {
            
        }
        
    }
}