using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class TelegraphOperator
    {
        private void InitPoco()
        {
            
            this.TelegraphOperatorId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "OperatorId")]
        public Guid TelegraphOperatorId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateTelegraphOperatorWhere(IEnumerable<TelegraphOperator> telegraphOperators)
        {
            if (!telegraphOperators.Any()) return "1=1";
            else 
            {
                var idList = telegraphOperators.Select(selectTelegraphOperator => String.Format("'{0}'", selectTelegraphOperator.TelegraphOperatorId));
                var csIdList = String.Join(",", idList);
                return String.Format("TelegraphOperatorId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<TelegraphOperator> telegraphOperators, string expandString)
        {
            
        }
        
    }
}