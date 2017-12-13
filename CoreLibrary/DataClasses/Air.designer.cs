using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Air
    {
        private void InitPoco()
        {
            
            this.AirId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AirId")]
        public Guid AirId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateAirWhere(IEnumerable<Air> airs)
        {
            if (!airs.Any()) return "1=1";
            else 
            {
                var idList = airs.Select(selectAir => String.Format("'{0}'", selectAir.AirId));
                var csIdList = String.Join(",", idList);
                return String.Format("AirId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Air> airs, string expandString)
        {
            
        }
        
    }
}