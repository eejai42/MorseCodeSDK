using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Aviation
    {
        private void InitPoco()
        {
            
            this.AviationId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AviationId")]
        public Guid AviationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateAviationWhere(IEnumerable<Aviation> aviations)
        {
            if (!aviations.Any()) return "1=1";
            else 
            {
                var idList = aviations.Select(selectAviation => String.Format("'{0}'", selectAviation.AviationId));
                var csIdList = String.Join(",", idList);
                return String.Format("AviationId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Aviation> aviations, string expandString)
        {
            
        }
        
    }
}