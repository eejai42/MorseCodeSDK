using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using MorseCodeSDK.Lib.SqlDataManagement;
using CoreLibrary.Extensions;

namespace MorseCodeSDK.Lib.DataClasses
{                            
    public partial class Practice
    {
        private void InitPoco()
        {
            
            this.PracticeId = Guid.NewGuid();
            

        }

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PracticeId")]
        public Guid PracticeId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    

        

        

        private static string CreatePracticeWhere(IEnumerable<Practice> practices)
        {
            if (!practices.Any()) return "1=1";
            else 
            {
                var idList = practices.Select(selectPractice => String.Format("'{0}'", selectPractice.PracticeId));
                var csIdList = String.Join(",", idList);
                return String.Format("PracticeId in ({0})", csIdList);
            }
        }
        
        public static void CheckExpand(SqlDataManager sdm, IEnumerable<Practice> practices, string expandString)
        {
            
        }
        
    }
}