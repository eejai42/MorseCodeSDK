using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Aviator
    {
        private void InitPoco()
        {
            
            this.AviatorId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AviatorId")]
        public Guid AviatorId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateAviatorWhere(IEnumerable<Aviator> aviators)
        {
            if (!aviators.Any()) return "1=1";
            else 
            {
                var idList = aviators.Select(selectAviator => String.Format("'{0}'", selectAviator.AviatorId));
                var csIdList = String.Join(",", idList);
                return String.Format("AviatorId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Aviator> aviators, string expandString)
        {
            
        }
        
    }
}