using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Learningmethod
    {
        private void InitPoco()
        {
            
            this.LearningmethodId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "LearningmethodId")]
        public Guid LearningmethodId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreateLearningmethodWhere(IEnumerable<Learningmethod> learningmethods)
        {
            if (!learningmethods.Any()) return "1=1";
            else 
            {
                var idList = learningmethods.Select(selectLearningmethod => String.Format("'{0}'", selectLearningmethod.LearningmethodId));
                var csIdList = String.Join(",", idList);
                return String.Format("LearningmethodId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Learningmethod> learningmethods, string expandString)
        {
            
        }
        
    }
}