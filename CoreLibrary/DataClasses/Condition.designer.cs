using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Condition
    {
        private void InitPoco()
        {
            
            this.ConditionId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ConditionId")]
        public Guid ConditionId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateConditionWhere(IEnumerable<Condition> conditions)
        {
            if (!conditions.Any()) return "1=1";
            else 
            {
                var idList = conditions.Select(selectCondition => String.Format("'{0}'", selectCondition.ConditionId));
                var csIdList = String.Join(",", idList);
                return String.Format("ConditionId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Condition> conditions, string expandString)
        {
            
        }
        
    }
}