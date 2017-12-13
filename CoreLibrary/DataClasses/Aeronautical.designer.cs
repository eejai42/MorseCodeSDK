using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Aeronautical
    {
        private void InitPoco()
        {
            
            this.AeronauticalId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AeronauticalId")]
        public Guid AeronauticalId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateAeronauticalWhere(IEnumerable<Aeronautical> aeronauticals)
        {
            if (!aeronauticals.Any()) return "1=1";
            else 
            {
                var idList = aeronauticals.Select(selectAeronautical => String.Format("'{0}'", selectAeronautical.AeronauticalId));
                var csIdList = String.Join(",", idList);
                return String.Format("AeronauticalId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Aeronautical> aeronauticals, string expandString)
        {
            
        }
        
    }
}