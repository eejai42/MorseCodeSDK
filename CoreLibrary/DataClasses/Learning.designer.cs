using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Learning
    {
        private void InitPoco()
        {
            
            this.LearningId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LearningId")]
        public Guid LearningId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateLearningWhere(IEnumerable<Learning> learnings)
        {
            if (!learnings.Any()) return "1=1";
            else 
            {
                var idList = learnings.Select(selectLearning => String.Format("'{0}'", selectLearning.LearningId));
                var csIdList = String.Join(",", idList);
                return String.Format("LearningId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Learning> learnings, string expandString)
        {
            
        }
        
    }
}