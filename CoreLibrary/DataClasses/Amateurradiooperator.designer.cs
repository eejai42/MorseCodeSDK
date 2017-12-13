using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Amateurradiooperator
    {
        private void InitPoco()
        {
            
            this.AmateurradiooperatorId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AmateurradiooperatorId")]
        public Guid AmateurradiooperatorId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateAmateurradiooperatorWhere(IEnumerable<Amateurradiooperator> amateurradiooperators)
        {
            if (!amateurradiooperators.Any()) return "1=1";
            else 
            {
                var idList = amateurradiooperators.Select(selectAmateurradiooperator => String.Format("'{0}'", selectAmateurradiooperator.AmateurradiooperatorId));
                var csIdList = String.Join(",", idList);
                return String.Format("AmateurradiooperatorId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Amateurradiooperator> amateurradiooperators, string expandString)
        {
            
        }
        
    }
}