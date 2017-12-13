using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Light
    {
        private void InitPoco()
        {
            
            this.LightId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LightId")]
        public Guid LightId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateLightWhere(IEnumerable<Light> lights)
        {
            if (!lights.Any()) return "1=1";
            else 
            {
                var idList = lights.Select(selectLight => String.Format("'{0}'", selectLight.LightId));
                var csIdList = String.Join(",", idList);
                return String.Format("LightId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Light> lights, string expandString)
        {
            
        }
        
    }
}